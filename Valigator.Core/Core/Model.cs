﻿using System;
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
		private static Func<TModel, ValidationError[][]> _verifyMethod;

		public static Result<Unit, ValidationError[]> Verify(TModel model)
		{
			if (typeof(TModel).IsPrimitive || typeof(TModel).IsArray)
				return Result.Unit<ValidationError[]>();

			if (_verifyMethod == null)
			{
				lock (_verifyModelLockObj)
				{
					if (_verifyMethod == null)
						_verifyMethod = CreateVerifyFunction();
				}
			}

			var validationErrors = _verifyMethod
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

			var properties = GetAllProperties(typeof(TModel));
			var fields = GetAllFields(typeof(TModel));

			var (dataProperties, validateContentsMembers) = FilterToDataPropertiesAndValidateContentsMembers(properties, fields);

			var validationErrors = Enumerable
				.Empty<Expression>()
				.Concat(dataProperties
					.Select(property => VerifyDataProperty(modelExpression, property))
				)
				.Concat(validateContentsMembers
					.Select(propertyOrField => VerifyPropertyOrFieldContents(modelExpression, propertyOrField))
				);

			var arrayInitializer = Expression.NewArrayInit(typeof(ValidationError[]), validationErrors);

			return Expression.Lambda<Func<TModel, ValidationError[][]>>(arrayInitializer, modelParameter).Compile();
		}

		private static PropertyInfo[] GetAllProperties(Type type)
			=> GetBaseProperties(type)
				.Concat(GetExplicitProperties(type))
				.ToArray();

		private static FieldInfo[] GetAllFields(Type type)
			=> type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

		private static (PropertyInfo[] dataProperties, MemberInfo[] validateContentsMembers) FilterToDataPropertiesAndValidateContentsMembers(PropertyInfo[] properties, FieldInfo[] fields)
		{
			var dataProperties = properties
				.Where(p => IsValigatorDataType(p.PropertyType))
				.ToArray();

			var validateContentsProperties = properties
				.Where(p => !IsValigatorDataType(p.PropertyType))
				.Where(p => p.GetCustomAttribute<ValidateContentsAttribute>() != null)
				.ToArray();

			var noGetters = dataProperties
				.Concat(validateContentsProperties)
				.Where(x => x.GetMethod == null)
				.ToArray();

			var noSetters = dataProperties
				.Where(x => x.SetMethod == null)
				.ToArray();

			if (noGetters.Any() || noSetters.Any())
				throw new MissingAccessorsException(noGetters, noSetters);

			var validateContentsFields = fields
				.Where(p => p.GetCustomAttribute<ValidateContentsAttribute>() != null)
				.ToArray();

			var validateContentsMembers = Enumerable
				.Empty<MemberInfo>()
				.Concat(validateContentsProperties)
				.Concat(validateContentsFields)
				.ToArray();

			return (dataProperties, validateContentsMembers);
		}

		private static MethodInfo _modelVerify;
		private static MethodInfo _isSuccess;
		private static MethodInfo _getFailure;

		private static Expression VerifyPropertyOrFieldContents(Expression modelExpression, MemberInfo propertyOrField)
		{
			Expression valueAccessor;
			Type valueType;
			if (propertyOrField is PropertyInfo property)
			{
				valueAccessor = Expression.Property(modelExpression, property);
				valueType = property.PropertyType;
			}
			else if (propertyOrField is FieldInfo field)
			{
				valueAccessor = Expression.Field(modelExpression, field);
				valueType = field.FieldType;
			}
			else
				throw new ArgumentException("Value was not of type PropertyInfo or FieldInfo.", nameof(propertyOrField));

			var valueName = propertyOrField.GetCustomAttribute<ValidateContentsAttribute>().MemberName;

			var modelVerifyGeneric = _modelVerify ?? (_modelVerify = typeof(Model).GetMethod(nameof(Model.Verify), BindingFlags.Public | BindingFlags.Static));

			var modelVerify = modelVerifyGeneric.MakeGenericMethod(valueType);

			var isSuccessMethod = _isSuccess ?? (_isSuccess = typeof(Model<TModel>).GetMethod(nameof(IsUnitResultSuccess), BindingFlags.NonPublic | BindingFlags.Static));
			var getFailureMethod = _getFailure ?? (_getFailure = typeof(Model<TModel>).GetMethod(nameof(GetUnitResultFailure), BindingFlags.NonPublic | BindingFlags.Static));

			var result = Expression.Variable(typeof(Result<Unit, ValidationError[]>), "result");

			var assignedResult = Expression.Assign(result, Expression.Call(null, modelVerify, valueAccessor));

			var isSuccess = Expression.Call(isSuccessMethod, result);

			var addPathsToErrorsMethod = _addPathsToErrorsMethod ?? (_addPathsToErrorsMethod = typeof(Model<object>).GetMethod(nameof(AddPropertyToErrors), BindingFlags.NonPublic | BindingFlags.Static));

			var getFailure = Expression.Call(addPathsToErrorsMethod, Expression.Call(getFailureMethod, result), Expression.Constant(valueName, typeof(string)));

			var onSuccess = Expression.Constant(null, typeof(ValidationError[]));

			var condition = Expression.Condition(isSuccess, onSuccess, getFailure, typeof(ValidationError[]));

			return Expression.Block(new[] { result }, assignedResult, condition);
		}

		private static IEnumerable<PropertyInfo> GetBaseProperties(Type type)
		{
			var currentLevelProperties = type
				.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
				.Where(p => !IsExplicitInterfaceImplementation(p));

			foreach (var currentProperty in currentLevelProperties)
			{
				var propertyToUse = currentProperty;
				var method = currentProperty.GetGetMethod(true) ?? currentProperty.GetSetMethod(true);

				var baseType = method.GetBaseDefinition().DeclaringType;
				if (baseType != type)
					propertyToUse = baseType.GetProperty(currentProperty.Name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

				yield return propertyToUse;
			}
		}

		private static IEnumerable<PropertyInfo> GetExplicitProperties(Type type)
		{
			var currentType = type;
			while (currentType != null)
			{
				var explicitProperties = currentType
					.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance)
					.Where(p => IsExplicitInterfaceImplementation(p));

				foreach (var property in currentType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance).Where(p => IsExplicitInterfaceImplementation(p)))
					yield return property;

				currentType = currentType.BaseType;
			}
		}

		private static bool IsValigatorDataType(Type type)
			=> type.IsConstructedGenericType && type.GetGenericTypeDefinition() == typeof(Data<>);


		private static bool IsExplicitInterfaceImplementation(PropertyInfo prop)
			=> prop.Name.Contains(".");

		private static Expression VerifyDataProperty(Expression modelExpression, PropertyInfo property)
		{
			var methods = GetVerifySupportMethods(property.PropertyType);

			var dataProperty = Expression.Property(modelExpression, property);

			var isValid = Expression.Equal(Expression.Property(dataProperty, nameof(Data<object>.State)), Expression.Constant(DataState.Valid, typeof(DataState)));

			var isInvalid = Expression.Equal(Expression.Property(dataProperty, nameof(Data<object>.State)), Expression.Constant(DataState.Invalid, typeof(DataState)));

			var verifiedData = Expression.Assign(dataProperty, Expression.Call(dataProperty, methods.verify, modelExpression));

			var data = Expression.Condition(Expression.OrElse(isValid, isInvalid), dataProperty, verifiedData);

			var result = Expression.Variable(typeof(Result<,>).MakeGenericType(property.PropertyType.GetGenericArguments()[0], typeof(ValidationError[])), "result");

			var assignedResult = Expression.Assign(result, Expression.Call(data, methods.tryGetValue));

			var isSuccess = Expression.Call(methods.isSuccess, result);

			var addPathsToErrorsMethod = _addPathsToErrorsMethod ?? (_addPathsToErrorsMethod = typeof(Model<object>).GetMethod(nameof(AddPropertyToErrors), BindingFlags.NonPublic | BindingFlags.Static));

			var getFailure = Expression.Call(addPathsToErrorsMethod, Expression.Call(methods.getFailure, result), Expression.Constant(property.Name, typeof(string)));

			var onSuccess = Expression.Constant(null, typeof(ValidationError[]));

			var condition = Expression.Condition(isSuccess, onSuccess, getFailure, typeof(ValidationError[]));

			return Expression.Block(new[] { result }, assignedResult, condition);
		}

		private static readonly ConcurrentDictionary<Type, (MethodInfo verify, MethodInfo tryGetValue, MethodInfo isSuccess, MethodInfo getFailure)> _getVerifySupportMethods = new ConcurrentDictionary<Type, (MethodInfo verify, MethodInfo tryGetValue, MethodInfo isSuccess, MethodInfo getFailure)>();

		private static (MethodInfo verify, MethodInfo tryGetValue, MethodInfo isSuccess, MethodInfo getFailure) GetVerifySupportMethods(Type dataType)
		{
			if (!_getVerifySupportMethods.TryGetValue(dataType, out var methods))
			{
				methods = CreateVerifySupportMethods(dataType);

				_getVerifySupportMethods.TryAdd(dataType, methods);
			}

			return methods;
		}

		private static (MethodInfo verify, MethodInfo tryGetValue, MethodInfo isSuccess, MethodInfo getFailure) CreateVerifySupportMethods(Type dataType)
		{
			var valueType = dataType.GetGenericArguments()[0];

			var verify = dataType.GetMethod(nameof(Data<object>.Verify), new[] { typeof(object) });

			var tryGetValue = dataType.GetMethod(nameof(Data<object>.TryGetValue), Type.EmptyTypes);

			var isSuccess = typeof(Model<TModel>).GetMethod(nameof(IsResultSuccess), BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(valueType);

			var getFailure = typeof(Model<TModel>).GetMethod(nameof(GetResultFailure), BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(valueType);

			return (verify, tryGetValue, isSuccess, getFailure);
		}

		private static bool IsUnitResultSuccess(Result<Unit, ValidationError[]> result)
			=> result.Match(_ => true, _ => false);

		private static ValidationError[] GetUnitResultFailure(Result<Unit, ValidationError[]> result)
			=> result.Match(_ => default, _ => _);

		private static bool IsResultSuccess<TValue>(Result<TValue, ValidationError[]> result)
			=> result.Match(_ => true, _ => false);

		private static ValidationError[] GetResultFailure<TValue>(Result<TValue, ValidationError[]> result)
			=> result
				.Match(_ => default, errors => errors);

		private static MethodInfo _addPathsToErrorsMethod;

		private static ValidationError[] AddPropertyToErrors(ValidationError[] errors, string propertyName)
			=> (errors == null || String.IsNullOrEmpty(propertyName)) ? errors : AddPropertyToErrorsInternal(errors, propertyName).ToArray();

		private static IEnumerable<ValidationError> AddPropertyToErrorsInternal(ValidationError[] errors, string propertyName)
		{
			foreach (var error in errors)
				error.Path.AddProperty(propertyName);
			return errors;
		}
	}
}
