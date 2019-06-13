using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Functional;
using Valigator.AspNetCore;
using Valigator.Core;
using Valigator.Core.StateValidators;

namespace Valigator
{
	public abstract class ValidateAttribute : Attribute
	{
		public interface IValidateType<TValue>
		{
			Data<TValue> GetData();
		}

		private static readonly object _obj = new object();

		private static readonly ConcurrentDictionary<Type, Func<ValidateAttribute, bool, object, Result<object, ValidationError[]>>> _verifyMethods = new ConcurrentDictionary<Type, Func<ValidateAttribute, bool, object, Result<object, ValidationError[]>>>();

		private static readonly ConcurrentDictionary<Type, Func<ValidateAttribute, DataDescriptor>> _getDescriptorMethods = new ConcurrentDictionary<Type, Func<ValidateAttribute, DataDescriptor>>();

		public DataDescriptor GetDescriptor(Type type)
			=> _getDescriptorMethods
				.GetOrAdd(type, t => GenerateGetDescriptorMethod(type))
				.Invoke(this);

		private static Func<ValidateAttribute, DataDescriptor> GenerateGetDescriptorMethod(Type type)
		{
			var validateType = typeof(IValidateType<>).MakeGenericType(type);

			var validateMethod = typeof(ValidateAttribute).GetMethod("ValidateType", BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(type);
			var getDataMethod = validateType.GetMethod(nameof(IValidateType<object>.GetData), BindingFlags.Public | BindingFlags.Instance);

			var attributeParameter = Expression.Parameter(typeof(ValidateAttribute), "attribute");

			var validate = Expression.Call(validateMethod, attributeParameter);

			var data = Expression.Call(Expression.Convert(attributeParameter, validateType), getDataMethod);

			var descriptor = Expression.Property(data, nameof(Data<object>.DataDescriptor));

			var block = Expression.Block(validate, descriptor);

			return Expression.Lambda<Func<ValidateAttribute, DataDescriptor>>(block, attributeParameter).Compile();
		}

		public Result<object, ValidationError[]> Verify(Type type, object value)
			=> _verifyMethods
				.GetOrAdd(type, t => GenerateVerifyMethod(type))
				.Invoke(this, true, value);

		public Result<object, ValidationError[]> Verify(Type type)
			=> _verifyMethods
				.GetOrAdd(type, t => GenerateVerifyMethod(type))
				.Invoke(this, false, null);

		private static Func<ValidateAttribute, bool, object, Result<object, ValidationError[]>> GenerateVerifyMethod(Type type)
		{
			var validateType = typeof(IValidateType<>).MakeGenericType(type);

			var validateMethod = typeof(ValidateAttribute).GetMethod("ValidateType", BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(type);
			var getDataMethod = validateType.GetMethod(nameof(IValidateType<object>.GetData), BindingFlags.Public | BindingFlags.Instance);
			var verifyMethod = typeof(ValidateAttribute).GetMethod("Verify", BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(type);

			var attributeParameter = Expression.Parameter(typeof(ValidateAttribute), "attribute");
			var isSetParameter = Expression.Parameter(typeof(bool), "isSet");
			var valueParameter = Expression.Parameter(typeof(object), "value");

			var validate = Expression.Call(validateMethod, attributeParameter);

			var data = Expression.Call(Expression.Convert(attributeParameter, validateType), getDataMethod);
			var verified = Expression.Call(verifyMethod, data, isSetParameter, valueParameter);

			var block = Expression.Block(validate, verified);

			return Expression.Lambda<Func<ValidateAttribute, bool, object, Result<object, ValidationError[]>>>(block, attributeParameter, isSetParameter, valueParameter).Compile();
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

		private static void ValidateType<TValue>(ValidateAttribute attribute)
		{
			if (!(attribute is IValidateType<TValue>))
				throw new ValidateAttributeDoesNotSupportTypeException(attribute.GetType(), typeof(TValue));
		}
	}
}
