using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Functional;
using Microsoft.CSharp.RuntimeBinder;

namespace Valigator.Core
{
	internal struct PropertyOrFieldData
	{
		public string Name { get; }
		public Type Type { get; }
		public Type ComponentType { get; }
		public Attribute[] CustomAttributes { get; }

		public PropertyOrFieldData(string name, Type type, Type componentType, IEnumerable<Attribute> customAttributes) : this(name, type, componentType, customAttributes.ToArray()) { }

		public PropertyOrFieldData(string name, Type type, Type componentType, Attribute[] customAttributes) : this()
		{
			Name = name;
			Type = type;
			ComponentType = componentType;
			CustomAttributes = customAttributes;
		}
	}

	public abstract class ValigatorAnonymousObjectBase : DynamicObject
	{
		
	}
	public abstract class ValigatorAnonymousObjectBase<T> : ValigatorAnonymousObjectBase, ICustomTypeDescriptor
	{
		public object Inner { get; }
		private readonly InnerCustomTypeDescriptor _innerTypeDescriptor;

		public ValigatorAnonymousObjectBase(object inner)
		{
			Inner = inner;
			_innerTypeDescriptor = new InnerCustomTypeDescriptor(inner);
		}

		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			return base.TryGetMember(binder, out result);
		}

		public virtual AttributeCollection GetAttributes() => _innerTypeDescriptor.GetAttributes();
		public virtual string GetClassName() => _innerTypeDescriptor.GetClassName();
		public string GetComponentName() => _innerTypeDescriptor.GetComponentName();
		public TypeConverter GetConverter() => _innerTypeDescriptor.GetConverter();
		public EventDescriptor GetDefaultEvent() => _innerTypeDescriptor.GetDefaultEvent();
		public System.ComponentModel.PropertyDescriptor GetDefaultProperty() => _innerTypeDescriptor.GetDefaultProperty();
		public object GetEditor(Type editorBaseType) => _innerTypeDescriptor.GetEditor(editorBaseType);
		public EventDescriptorCollection GetEvents() => _innerTypeDescriptor.GetEvents();
		public EventDescriptorCollection GetEvents(Attribute[] attributes) => _innerTypeDescriptor.GetEvents(attributes);
		public PropertyDescriptorCollection GetProperties() => _innerTypeDescriptor.GetProperties();
		public PropertyDescriptorCollection GetProperties(Attribute[] attributes) => _innerTypeDescriptor.GetProperties(attributes);
		public object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) => _innerTypeDescriptor.GetPropertyOwner(pd);

		private class InnerCustomTypeDescriptor : CustomTypeDescriptor
		{
			protected readonly object _inner;
			protected readonly IDictionary<string, object> _dictionary = new Dictionary<string, object>();

			public InnerCustomTypeDescriptor(object inner)
			{
				_inner = inner;
				SetupDictionary();
			}

			private void SetupDictionary()
			{
				foreach (var property in _inner.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
					_dictionary.Add(property.Name, property.GetValue(_inner));
			}

			public override PropertyDescriptorCollection GetProperties()
				=> new PropertyDescriptorCollection(base.GetProperties().OfType<System.ComponentModel.PropertyDescriptor>().Concat(GetExpandoProperties()).ToArray());

			private IEnumerable<System.ComponentModel.PropertyDescriptor> GetExpandoProperties()
				=> _dictionary.Select(property => new ExpandoPropertyDescriptor(_dictionary, property.Key));

			public override string GetClassName()
				=> $"{nameof(ValigatorAnonymousObjectBase)}_{_inner.GetType().Name}";
		}

		private class ExpandoPropertyDescriptor : System.ComponentModel.PropertyDescriptor
		{
			private readonly IDictionary<string, object> _dictionary;
			private readonly string _name;

			public ExpandoPropertyDescriptor(IDictionary<string, object> expando, string name)
				: base(name, null)
			{
				_dictionary = expando;
				_name = name;
			}

			public override Type PropertyType => _dictionary[_name].GetType();
			public override void SetValue(object component, object value) => _dictionary[_name] = value;
			public override object GetValue(object component) => _dictionary[_name];
			public override bool IsReadOnly { get; } = false;
			public override Type ComponentType { get; } = null;
			public override bool CanResetValue(object component) => false;
			public override void ResetValue(object component) { }
			public override bool ShouldSerializeValue(object component) => false;
			public override string Category { get; } = String.Empty;
			public override string Description { get; } = String.Empty;
		}
	}

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
						_verifyMethod = CreateVerifyFunction(model);
				}
			}

			var validationErrors = _verifyMethod
				.Invoke(model)
				.OfType<ValidationError[]>()
				.SelectMany(_ => _)
				.ToArray();

			return Result.Create(validationErrors.Length == 0, Unit.Value, validationErrors);
		}

		private static Func<TModel, ValidationError[][]> CreateVerifyFunction(TModel model)
		{
			var modelParameter = Expression.Parameter(typeof(TModel), "model");

			var modelExpression = Expression.Convert(modelParameter, typeof(TModel));

			var properties = GetAllProperties(model);
			var fields = GetAllFields(typeof(TModel));

			var (dataProperties, validateContentsMembers) = FilterToDataPropertiesAndValidateContentsMembers(properties, fields);

			var validationErrors = Enumerable
				.Empty<Expression>()
				.Concat(dataProperties
					.Select(property => VerifyDataProperty(modelExpression, property, model))
				)
				.Concat(validateContentsMembers
					.Select(propertyOrField => VerifyPropertyOrFieldContents(modelExpression, propertyOrField))
				);

			var arrayInitializer = Expression.NewArrayInit(typeof(ValidationError[]), validationErrors);

			return Expression.Lambda<Func<TModel, ValidationError[][]>>(arrayInitializer, modelParameter).Compile();
		}

		private static Expression CreateExpression(Expression modelParameter, PropertyOrFieldData data, TModel model)
		{
			if (!(model is ValigatorAnonymousObjectBase))
				return Expression.Property(modelParameter, data.Name);

			var innerType = model.GetType().GenericTypeArguments.First();
			var innerProperty = Expression.Property(modelParameter, model.GetType().GetProperty(nameof(ValigatorAnonymousObjectBase<object>.Inner), BindingFlags.Public | BindingFlags.Instance));
			var castedInner = Expression.Convert(innerProperty, innerType);
			var property = Expression.Property(castedInner, data.Name);
			return property;
		}

		private static PropertyOrFieldData[] GetAllProperties(TModel model)
			=> GetBaseProperties(model)
				.Concat(GetExplicitProperties(typeof(TModel)))
				.ToArray();

		private static FieldInfo[] GetAllFields(Type type)
			=> type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

		private static (PropertyOrFieldData[] dataProperties, PropertyOrFieldData[] validateContentsMembers) FilterToDataPropertiesAndValidateContentsMembers(PropertyOrFieldData[] properties, FieldInfo[] fields)
		{
			var dataProperties = properties
				.Where(p => IsValigatorDataType(p.Type))
				.ToArray();

			var validateContentsProperties = properties
				.Where(p => !IsValigatorDataType(p.Type))
				.Where(p => p.CustomAttributes.OfType<ValidateContentsAttribute>().FirstOrDefault() != null)
				.ToArray();

			//var noGetters = dataProperties
			//	.Concat(validateContentsProperties)
			//	.Where(x => x.GetMethod == null)
			//	.ToArray();

			//var noSetters = dataProperties
			//	.Where(x => x.SetMethod == null)
			//	.ToArray();

			//if (noGetters.Any() || noSetters.Any())
			//	throw new MissingAccessorsException(noGetters, noSetters);

			var validateContentsFields = fields
				.Where(p => p.GetCustomAttribute<ValidateContentsAttribute>() != null)
				.Select(member => new PropertyOrFieldData(member.Name, member.FieldType, member.DeclaringType, member.GetCustomAttributes()))
				.ToArray();

			var validateContentsMembers = Enumerable
				.Empty<PropertyOrFieldData>()
				.Concat(validateContentsProperties)
				.Concat(validateContentsFields)
				.ToArray();

			return (dataProperties, validateContentsMembers);
		}

		private static MethodInfo _modelVerify;
		private static MethodInfo _isSuccess;
		private static MethodInfo _getFailure;

		private static Expression VerifyPropertyOrFieldContents(Expression modelExpression, PropertyOrFieldData propertyOrField)
		{
			var valueAccessor = Expression.Property(modelExpression, propertyOrField.Name);
			var valueType = propertyOrField.Type;

			var valueName = propertyOrField.CustomAttributes.OfType<ValidateContentsAttribute>().First().MemberName;

			var modelVerifyGeneric = _modelVerify ?? (_modelVerify = typeof(Model).GetMethod(nameof(Model.Verify), BindingFlags.Public | BindingFlags.Static));

			var modelVerify = modelVerifyGeneric.MakeGenericMethod(valueType);

			var isSuccessMethod = _isSuccess ?? (_isSuccess = typeof(Model<TModel>).GetMethod(nameof(IsUnitResultSuccess), BindingFlags.NonPublic | BindingFlags.Static));
			var getFailureMethod = _getFailure ?? (_getFailure = typeof(Model<TModel>).GetMethod(nameof(GetUnitResultFailure), BindingFlags.NonPublic | BindingFlags.Static));

			var result = Expression.Variable(typeof(Result<Unit, ValidationError[]>), "result");

			var assignedResult = Expression.Assign(result, Expression.Call(null, modelVerify, valueAccessor));

			var isSuccess = Expression.Call(isSuccessMethod, result);

			var addPathsToErrorsMethod = _addPathsToErrorsMethod ?? (_addPathsToErrorsMethod = typeof(Model<object>).GetMethod(nameof(AddPropertyToErrors), BindingFlags.NonPublic | BindingFlags.Static));

			var getFailure = Expression.Call(addPathsToErrorsMethod, Expression.Call(getFailureMethod, result), Expression.Constant(valueName, typeof(string)), Expression.Constant(false, typeof(bool)));

			var onSuccess = Expression.Constant(null, typeof(ValidationError[]));

			var condition = Expression.Condition(isSuccess, onSuccess, getFailure, typeof(ValidationError[]));

			return Expression.Block(new[] { result }, assignedResult, condition);
		}

		private static IEnumerable<PropertyOrFieldData> GetBaseProperties(TModel model)
		{
			var currentLevelProperties = GetProperties(typeof(TModel), BindingFlags.NonPublic | BindingFlags.Instance)
				.Concat(TypeDescriptor.GetProperties(model).OfType<System.ComponentModel.PropertyDescriptor>().Select(property => new PropertyOrFieldData(property.Name, property.PropertyType, property.ComponentType, property.PropertyType.GetCustomAttributes().ToArray())))
				.Where(p => !IsExplicitInterfaceImplementation(p));

			foreach (var currentProperty in currentLevelProperties)
			{
				if (currentProperty.ComponentType != null)
				{
					var method = currentProperty.ComponentType.GetProperty(currentProperty.Name).GetGetMethod() ?? currentProperty.ComponentType.GetProperty(currentProperty.Name).GetSetMethod();

					var baseType = method.GetBaseDefinition().DeclaringType;
					if (baseType != typeof(TModel))
						yield return GetProperty(baseType, currentProperty.Name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
				}
				else
					yield return currentProperty;
			}
		}

		private static IEnumerable<PropertyOrFieldData> GetExplicitProperties(Type type)
		{
			var currentType = type;
			while (currentType != null)
			{
				var explicitProperties = GetProperties(currentType, BindingFlags.NonPublic | BindingFlags.Instance)
					.Where(p => IsExplicitInterfaceImplementation(p));

				foreach (var property in explicitProperties)
					yield return property;

				currentType = currentType.BaseType;
			}
		}

		private static PropertyOrFieldData GetProperty(Type type, string name, BindingFlags bindingFlags)
		{
			var property = type.GetProperty(name, bindingFlags);
			return new PropertyOrFieldData(property.Name, property.PropertyType, property.DeclaringType, property.GetCustomAttributes());
		}

		private static PropertyOrFieldData[] GetProperties(Type type, BindingFlags bindingFlags)
			=> type
				.GetProperties(bindingFlags)
				.Select(property => new PropertyOrFieldData(property.Name, property.PropertyType, property.DeclaringType, property.GetCustomAttributes()))
				.ToArray();

		private static bool IsValigatorDataType(Type type)
			=> type.IsConstructedGenericType && type.GetGenericTypeDefinition() == typeof(Data<>);


		private static bool IsExplicitInterfaceImplementation(PropertyOrFieldData prop)
			=> prop.Name.Contains(".");

		private static Expression VerifyDataProperty(Expression modelExpression, PropertyOrFieldData property, TModel model)
		{
			var methods = GetVerifySupportMethods(property.Type);

			var dataProperty = CreateExpression(modelExpression, property, model);// Expression.Property(modelExpression, property.Name);

			var isValid = Expression.Equal(Expression.Property(dataProperty, nameof(Data<object>.State)), Expression.Constant(DataState.Valid, typeof(DataState)));

			var isInvalid = Expression.Equal(Expression.Property(dataProperty, nameof(Data<object>.State)), Expression.Constant(DataState.Invalid, typeof(DataState)));

			var isVerified = Expression.Variable(typeof(bool), "isVerified");

			var assignIsVerified = Expression.Assign(isVerified, Expression.Or(isValid, isInvalid));

			var verifiedData = Expression.Assign(dataProperty, Expression.Call(dataProperty, methods.verify, modelExpression));

			var data = Expression.Condition(Expression.OrElse(isValid, isInvalid), dataProperty, verifiedData);

			var result = Expression.Variable(typeof(Result<,>).MakeGenericType(property.Type.GetGenericArguments()[0], typeof(ValidationError[])), "result");

			var assignedResult = Expression.Assign(result, Expression.Call(data, methods.tryGetValue));

			var isSuccess = Expression.Call(methods.isSuccess, result);

			var addPathsToErrorsMethod = _addPathsToErrorsMethod ?? (_addPathsToErrorsMethod = typeof(Model<object>).GetMethod(nameof(AddPropertyToErrors), BindingFlags.NonPublic | BindingFlags.Static));

			var getFailure = Expression.Call(addPathsToErrorsMethod, Expression.Call(methods.getFailure, result), Expression.Constant(property.Name, typeof(string)), isVerified);

			var onSuccess = Expression.Constant(null, typeof(ValidationError[]));

			var condition = Expression.Condition(isSuccess, onSuccess, getFailure, typeof(ValidationError[]));

			return Expression.Block(new[] { isVerified, result }, assignIsVerified, assignedResult, condition);
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
			=> result.Match(_ => default, _ => _);

		private static MethodInfo _addPathsToErrorsMethod;

		private static ValidationError[] AddPropertyToErrors(ValidationError[] errors, string propertyName, bool skip)
		{
			if (!skip && errors != null && !String.IsNullOrEmpty(propertyName))
			{
				foreach (var error in errors)
					error.Path.AddProperty(propertyName);
			}

			return errors;
		}
	}
}
