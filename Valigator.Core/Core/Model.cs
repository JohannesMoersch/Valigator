using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Functional;

namespace Valigator.Core
{
	internal static class Model<TModel>
	{
		private static object _getPropertyDescriptorsLockObj = new object();
		private static Func<TModel, PropertyDescriptor[]> _getPropertyDescriptors;

		public static PropertyDescriptor[] GetPropertyDescriptors(TModel model)
		{
			if (typeof(TModel).IsPrimitive)
				return Array.Empty<PropertyDescriptor>();

			if (_getPropertyDescriptors == null)
			{
				lock (_getPropertyDescriptorsLockObj)
				{
					if (_getPropertyDescriptors == null)
						_getPropertyDescriptors = CreatePropertyDescriptorsFunction();
				}
			}

			return _getPropertyDescriptors.Invoke(model);
		}

		private static Func<TModel, PropertyDescriptor[]> CreatePropertyDescriptorsFunction()
		{
			var modelExpression = Expression.Parameter(typeof(TModel), "model");

			var propertyDescriptors = typeof(TModel)
				.GetProperties()
				.Where(property => property.PropertyType.IsConstructedGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Data<>))
				.Select(property => CreatePropertyDescriptor(modelExpression, property));

			var arrayInitializer = Expression.NewArrayInit(typeof(PropertyDescriptor), propertyDescriptors);

			return Expression.Lambda<Func<TModel, PropertyDescriptor[]>>(arrayInitializer, modelExpression).Compile();
		}

		private static Expression CreatePropertyDescriptor(Expression modelExpression, PropertyInfo property)
		{
			var data = Expression.Property(modelExpression, property);

			var dataDescriptor = Expression.Property(data, nameof(Data<object>.DataDescriptor));

			var constructor = typeof(PropertyDescriptor).GetConstructor(new[] { typeof(string), typeof(DataDescriptor) });

			return Expression.New(constructor, Expression.Constant(property.Name, typeof(string)), dataDescriptor);
		}

		private static object _verifyModelLockObj = new object();
		private static Func<TModel, ValidationError[][]> _verifyModel;

		public static Result<Unit, ValidationError[]> Verify(TModel model)
		{
			if (typeof(TModel).IsPrimitive || typeof(TModel).IsArray)
				return Result.Unit<ValidationError[]>();

			if (_verifyModel == null)
			{
				lock (_verifyModelLockObj)
				{
					if (_verifyModel == null)
						_verifyModel = CreateVerifyFunction();
				}
			}

			var validationErrors = _verifyModel
				.Invoke(model)
				.OfType<ValidationError[]>()
				.SelectMany(_ => _)
				.ToArray();

			return Result.Create(validationErrors.Length == 0, Unit.Value, validationErrors);
		}

		private static Func<TModel, ValidationError[][]> CreateVerifyFunction()
		{
			var modelParameter = Expression.Parameter(typeof(TModel), "model");

			var modelExpression = Expression.Convert(modelParameter, typeof(TModel));

			var validationErrors = typeof(TModel)
				.GetProperties()
				.Where(property => property.PropertyType.IsConstructedGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Data<>))
				.Select(property => VerifyProperty(modelExpression, property));

			var arrayInitializer = Expression.NewArrayInit(typeof(ValidationError[]), validationErrors);

			return Expression.Lambda<Func<TModel, ValidationError[][]>>(arrayInitializer, modelParameter).Compile();
		}

		private static Expression VerifyProperty(Expression modelExpression, PropertyInfo property)
		{
			var methods = GetVerifySupportMethods(property.PropertyType);

			var dataProperty = Expression.Property(modelExpression, property);

			var result = Expression.Variable(typeof(Result<,>).MakeGenericType(property.PropertyType, typeof(ValidationError[])), "result");

			var assignedResult = Expression.Assign(result, Expression.Call(dataProperty, methods.verify, modelExpression));

			var isSuccess = Expression.Call(methods.isSuccess, result);

			var getSuccess = Expression.Call(methods.getSuccess, result);

			var addPathsToErrorsMethod = _addPathsToErrorsMethod ?? (_addPathsToErrorsMethod = typeof(Model<object>).GetMethod(nameof(AddPropertyToErrors), BindingFlags.NonPublic | BindingFlags.Static));

			var getFailure = Expression.Call(addPathsToErrorsMethod, Expression.Call(methods.getFailure, result), Expression.Constant(property.Name, typeof(string)));

			var onSuccess = Expression.Block(Expression.Assign(dataProperty, getSuccess), Expression.Constant(null, typeof(ValidationError[])));

			var condition = Expression.Condition(isSuccess, onSuccess, getFailure, typeof(ValidationError[]));

			return Expression.Block(new[] { result }, assignedResult, condition);
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

			var isSuccess = typeof(Model<TModel>).GetMethod(nameof(IsSuccess), BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(valueType);

			var getSuccess = typeof(Model<TModel>).GetMethod(nameof(GetSuccess), BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(valueType);

			var getFailure = typeof(Model<TModel>).GetMethod(nameof(GetFailure), BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(valueType);

			return (verify, isSuccess, getSuccess, getFailure);
		}

		private static bool IsSuccess<TValue>(Result<Data<TValue>, ValidationError[]> result)
			=> result.Match(_ => true, _ => false);

		private static Data<TValue> GetSuccess<TValue>(Result<Data<TValue>, ValidationError[]> result)
			=> result.Match(_ => _, _ => default);

		private static ValidationError[] GetFailure<TValue>(Result<Data<TValue>, ValidationError[]> result)
			=> result.Match(_ => default, _ => _);

		private static MethodInfo _addPathsToErrorsMethod;

		private static ValidationError[] AddPropertyToErrors(ValidationError[] errors, string propertyName)
		{
			if (errors != null)
			{
				foreach (var error in errors)
					error.Path.AddProperty(propertyName);
			}

			return errors;
		}
	}
}
