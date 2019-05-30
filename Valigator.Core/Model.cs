using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;

namespace Valigator.Core
{
	public static class Model
	{
		private static readonly ConcurrentDictionary<Type, Func<object, PropertyDescriptor[]>> _getPropertyDescriptorsFunctions = new ConcurrentDictionary<Type, Func<object, PropertyDescriptor[]>>();

		public static PropertyDescriptor[] GetPropertyDescriptors(this object model)
		{
			var modelType = model?.GetType() ?? throw new ArgumentNullException(nameof(model));

			if (!_getPropertyDescriptorsFunctions.TryGetValue(modelType, out var function))
			{
				function = CreatePropertyDescriptorsFunction(modelType);

				_getPropertyDescriptorsFunctions.TryAdd(modelType, function);
			}

			return function.Invoke(model);
		}

		private static Func<object, PropertyDescriptor[]> CreatePropertyDescriptorsFunction(Type modelType)
		{
			var modelParameter = Expression.Parameter(typeof(object), "model");

			var modelExpression = Expression.Convert(modelParameter, modelType);

			var propertyDescriptors = modelType
				.GetProperties()
				.Where(property => property.PropertyType.IsConstructedGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Data<>))
				.Select(property => CreatePropertyDescriptor(modelExpression, property));

			var arrayInitializer = Expression.NewArrayInit(typeof(PropertyDescriptor), propertyDescriptors);

			return Expression.Lambda<Func<object, PropertyDescriptor[]>>(arrayInitializer, modelParameter).Compile();
		}

		private static Expression CreatePropertyDescriptor(Expression modelExpression, PropertyInfo property)
		{
			var data = Expression.Property(modelExpression, property);

			var dataDescriptor = Expression.Property(data, nameof(Data<object>.DataDescriptor));

			var constructor = typeof(PropertyDescriptor).GetConstructor(new[] { typeof(string), typeof(Type), typeof(IStateDescriptor), typeof(IEnumerable<IValueDescriptor>) });

			var propertyType = Expression.Property(dataDescriptor, nameof(DataDescriptor.PropertyType));

			var stateDescriptor = Expression.Property(dataDescriptor, nameof(DataDescriptor.StateDescriptor));

			var valueDescriptors = Expression.Property(dataDescriptor, nameof(DataDescriptor.ValueDescriptors));

			return Expression.New(constructor, Expression.Constant(property.Name, typeof(string)), propertyType, stateDescriptor, valueDescriptors);
		}

		private static readonly ConcurrentDictionary<Type, Func<object, ValidationError[]>> _verifyModelFunctions = new ConcurrentDictionary<Type, Func<object, ValidationError[]>>();

		public static Result<Unit, ValidationError[]> Verify(object model)
		{
			var modelType = model?.GetType() ?? throw new ArgumentNullException(nameof(model));

			if (!_verifyModelFunctions.TryGetValue(modelType, out var function))
			{
				function = CreateVerifyFunction(modelType);

				_verifyModelFunctions.TryAdd(modelType, function);
			}

			var validationErrors = function.Invoke(model);

			return Result.Create(!validationErrors.Any(error => error != null), () => Unit.Value, () => validationErrors.OfType<ValidationError>().ToArray());
		}

		public static Func<object, ValidationError[]> CreateVerifyFunction(Type modelType)
		{
			var modelParameter = Expression.Parameter(typeof(object), "model");

			var modelExpression = Expression.Convert(modelParameter, modelType);

			var validationErrors = modelType
				.GetProperties()
				.Where(property => property.PropertyType.IsConstructedGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Data<>))
				.Select(property => VerifyProperty(modelExpression, property));

			var arrayInitializer = Expression.NewArrayInit(typeof(ValidationError), validationErrors);

			return Expression.Lambda<Func<object, ValidationError[]>>(arrayInitializer, modelParameter).Compile();
		}

		private static Expression VerifyProperty(Expression modelExpression, PropertyInfo property)
		{
			var methods = GetVerifySupportMethods(property.PropertyType);

			var dataProperty = Expression.Property(modelExpression, property);

			var result = Expression.Call(dataProperty, methods.verify, modelExpression);

			var isSuccess = Expression.Call(methods.isSuccess, result);

			var getSuccess = Expression.Call(methods.getSuccess, result);

			var getFailure = Expression.Call(methods.getFailure, result);

			var onSuccess = Expression.Block(Expression.Assign(dataProperty, getSuccess), Expression.Constant(null, typeof(ValidationError)));

			return Expression.Condition(isSuccess, onSuccess, getFailure, typeof(ValidationError));
		}

		private static readonly ConcurrentDictionary<Type, (MethodInfo verify, MethodInfo isSuccess, MethodInfo getSuccess, MethodInfo getFailure)> _getVerifySupportMethods = new ConcurrentDictionary<Type, (MethodInfo verify, MethodInfo isSuccess, MethodInfo getSuccess, MethodInfo getFailure)>();

		private static (MethodInfo verify, MethodInfo isSuccess, MethodInfo getSuccess, MethodInfo getFailure) GetVerifySupportMethods(Type dataType)
		{
			if (!_getVerifySupportMethods.TryGetValue(dataType, out var methods))
			{
				methods = CreateVerifySupportMethods(dataType);

				_getVerifySupportMethods.TryAdd(dataType, methods);
			}

			return methods;
		}

		private static (MethodInfo verify, MethodInfo isSuccess, MethodInfo getSuccess, MethodInfo getFailure) CreateVerifySupportMethods(Type dataType)
		{
			var valueType = dataType.GetGenericArguments()[0];

			var verify = dataType.GetMethod(nameof(Data<object>.Verify), new[] { typeof(object) });

			var isSuccess = typeof(Model).GetMethod(nameof(IsSuccess), BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(valueType);

			var getSuccess = typeof(Model).GetMethod(nameof(GetSuccess), BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(valueType);

			var getFailure = typeof(Model).GetMethod(nameof(GetFailure), BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(valueType);

			return (verify, isSuccess, getSuccess, getFailure);
		}

		private static bool IsSuccess<TValue>(Result<Data<TValue>, ValidationError> result)
			=> result.Match(_ => true, _ => false);

		private static Data<TValue> GetSuccess<TValue>(Result<Data<TValue>, ValidationError> result)
			=> result.Match(_ => _, _ => default);

		private static ValidationError GetFailure<TValue>(Result<Data<TValue>, ValidationError> result)
			=> result.Match(_ => default, _ => _);
	}
}
