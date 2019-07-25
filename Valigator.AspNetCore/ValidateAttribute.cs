using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Functional;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Valigator.AspNetCore;
using Valigator.Core;

namespace Valigator
{
	public abstract class ValidateModelBinderAttribute : Attribute, IModelNameProvider, IBinderTypeProviderMetadata, IBindingSourceMetadata, IModelBinder, IVerifiable, IDescriptor
	{
		public ValidateModelBinderAttribute()
		{
			BinderType = GetType();
		}

		/// <inheritdoc />
		public virtual string Name { get; set; }

		/// <inheritdoc />
		public Type BinderType { get; }

		/// <inheritdoc />
		public BindingSource BindingSource { get; }

		/// <inheritdoc />
		public async Task BindModelAsync(ModelBindingContext bindingContext)
		{
			(await BindModel(bindingContext))
				.Match(
					s => Result.Success<object, ValidationError[]>(s),
					Result.Failure<object, ValidationError[]>
				)
				.Match(
					value => Verify(value.GetType(), value),
					Result.Failure<object, ValidationError[]>
				)
				.Match(
					s =>
					{
						bindingContext.Model = Result.Success<object, ValidationError[]>(s);
						bindingContext.Result = ModelBindingResult.Success(s);
						return Unit.Value;
					},
					f =>
					{
						var name = bindingContext.BinderModelName ?? bindingContext.ModelMetadata?.ParameterName ?? bindingContext.ModelMetadata?.PropertyName ?? bindingContext?.ModelMetadata?.DisplayName ?? String.Empty;
						bindingContext.ModelState.TryAddModelException("ValigatorModelError", new ValigatorModelStateException(name, bindingContext.BindingSource, f));
						bindingContext.Result = ModelBindingResult.Failed();
						return Unit.Value;
					}
				);
			//TODO: make sure this comes out right
		}

		public abstract Task<Result<object, ValidationError[]>> BindModel(ModelBindingContext bindingContext);
		public DataDescriptor GetDescriptor(Type type) => StaticThingy.GetDescriptor(this, type);
		public Result<object, ValidationError[]> Verify(Type type, object value) => StaticThingy.Verify(this, type, value);
		public Result<object, ValidationError[]> Verify(Type type) => StaticThingy.Verify(this, type);

		//tODO: binder errors to filter
	}

	//todo: nathan
	internal class ValigatorModelStateException : Exception
	{
		public ValigatorModelStateException(string name, BindingSource source, params ValidationError[] errors)
		{
			Name = name;
			Source = source;
			ValidationErrors = errors;
		}

		public string Name { get; }
		public BindingSource Source { get; }
		public ValidationError[] ValidationErrors { get; }
	}

	internal static class StaticThingy
	{
		private static readonly object _obj = new object();

		private static readonly ConcurrentDictionary<Type, Func<IVerifiable, bool, object, Result<object, ValidationError[]>>> _verifyMethods = new ConcurrentDictionary<Type, Func<IVerifiable, bool, object, Result<object, ValidationError[]>>>();

		private static readonly ConcurrentDictionary<Type, Func<IDescriptor, DataDescriptor>> _getDescriptorMethods = new ConcurrentDictionary<Type, Func<IDescriptor, DataDescriptor>>();

		public static DataDescriptor GetDescriptor(this IDescriptor validateAttribute, Type type)
			=> _getDescriptorMethods
				.GetOrAdd(type, t => GenerateGetDescriptorMethod(type))
				.Invoke(validateAttribute);

		private static Func<IDescriptor, DataDescriptor> GenerateGetDescriptorMethod(Type type)
		{
			var validateType = typeof(IValidateType<>).MakeGenericType(type);

			var validateMethod = typeof(IDescriptor).GetMethod(nameof(StaticThingy.ValidateType), BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(type);
			var getDataMethod = validateType.GetMethod(nameof(IValidateType<object>.GetData), BindingFlags.Public | BindingFlags.Instance);

			var attributeParameter = Expression.Parameter(typeof(IDescriptor), "attribute");

			var validate = Expression.Call(validateMethod, attributeParameter);

			var data = Expression.Call(Expression.Convert(attributeParameter, validateType), getDataMethod);

			var descriptor = Expression.Property(data, nameof(Data<object>.DataDescriptor));

			var block = Expression.Block(validate, descriptor);

			return Expression.Lambda<Func<IDescriptor, DataDescriptor>>(block, attributeParameter).Compile();
		}

		public static Result<object, ValidationError[]> Verify(this IVerifiable validateAttribute, Type type, object value)
			=> _verifyMethods
				.GetOrAdd(type, t => GenerateVerifyMethod(type))
				.Invoke(validateAttribute, true, value);

		public static Result<object, ValidationError[]> Verify(this IVerifiable validateAttribute, Type type)
			=> _verifyMethods
				.GetOrAdd(type, t => GenerateVerifyMethod(type))
				.Invoke(validateAttribute, false, null);

		private static Func<IVerifiable, bool, object, Result<object, ValidationError[]>> GenerateVerifyMethod(Type type)
		{
			var validateType = typeof(IValidateType<>).MakeGenericType(type);

			var validateMethod = typeof(StaticThingy).GetMethod(nameof(ValidateType), BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(type);
			var getDataMethod = validateType.GetMethod(nameof(IValidateType<object>.GetData), BindingFlags.Public | BindingFlags.Instance);
			var verifyMethod = typeof(StaticThingy).GetMethod(nameof(StaticThingy.Verify), BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(type);

			var attributeParameter = Expression.Parameter(typeof(IVerifiable), "attribute");
			var isSetParameter = Expression.Parameter(typeof(bool), "isSet");
			var valueParameter = Expression.Parameter(typeof(object), "value");

			var validate = Expression.Call(validateMethod, attributeParameter);

			var data = Expression.Call(Expression.Convert(attributeParameter, validateType), getDataMethod);
			var verified = Expression.Call(verifyMethod, data, isSetParameter, valueParameter);

			var block = Expression.Block(validate, verified);

			return Expression.Lambda<Func<IVerifiable, bool, object, Result<object, ValidationError[]>>>(block, attributeParameter, isSetParameter, valueParameter).Compile();
		}

		private static Result<object, ValidationError[]> Verify<TValue>(Data<TValue> data, bool isSet, object value)
			=> (isSet ? data.WithValue((TValue)value) : data)
				.Verify(_obj)
				.TryGetValue()
				.Match
				(
					v => Result.Success<object, ValidationError[]>(v),
					Result.Failure<object, ValidationError[]>
				);

		private static void ValidateType<TValue>(IVerifiable attribute)
		{
			if (!(attribute is IValidateType<TValue>))
				throw new ValidateAttributeDoesNotSupportTypeException(attribute.GetType(), typeof(TValue));
		}
	}

	public interface IValidateType<TValue>
	{
		Data<TValue> GetData();
	}

	public interface IVerifiable
	{
		Result<object, ValidationError[]> Verify(Type type, object value);
		Result<object, ValidationError[]> Verify(Type type);
	}

	public interface IDescriptor
	{
		DataDescriptor GetDescriptor(Type type);
	}

	public abstract class ValidateAttribute : Attribute, IVerifiable, IDescriptor
	{
		public DataDescriptor GetDescriptor(Type type) => StaticThingy.GetDescriptor(this, type);
		public Result<object, ValidationError[]> Verify(Type type, object value) => StaticThingy.Verify(this, type, value);
		public Result<object, ValidationError[]> Verify(Type type) => StaticThingy.Verify(this, type);
	}
}
