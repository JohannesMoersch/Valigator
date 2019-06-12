using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Functional;
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

		private static readonly ConcurrentDictionary<Type, Func<ValidateAttribute, object, Result<object, ValidationError[]>>> _verifyMethods = new ConcurrentDictionary<Type, Func<ValidateAttribute, object, Result<object, ValidationError[]>>>();

		public Result<object, ValidationError[]> Verify(Type type, object value)
			=> _verifyMethods
				.GetOrAdd(type, t => GenerateVerifyFunction(type))
				.Invoke(this, value);

		private static Func<ValidateAttribute, object, Result<object, ValidationError[]>> GenerateVerifyFunction(Type type)
		{
			var validateType = typeof(IValidateType<>).MakeGenericType(type);

			var getDataMethod = validateType.GetMethod(nameof(IValidateType<object>.GetData), BindingFlags.Public | BindingFlags.Instance);
			var verifyMethod = typeof(ValidateAttribute).GetMethod("Verify", BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(type);

			var attributeParameter = Expression.Parameter(typeof(ValidateAttribute), "attribute");
			var valueParameter = Expression.Parameter(typeof(object), "value");

			var data = Expression.Call(Expression.Convert(attributeParameter, validateType), getDataMethod);
			var verified = Expression.Call(verifyMethod, data, valueParameter);

			return Expression.Lambda<Func<ValidateAttribute, object, Result<object, ValidationError[]>>>(verified, attributeParameter, valueParameter).Compile();
		}

		private static Result<object, ValidationError[]> Verify<TValue>(Data<TValue> data, object value)
			=> data
				.WithValue((TValue)value)
				.Verify(_obj)
				.Match
				(
					v => Result.Success<object, ValidationError[]>(v.Value),
					Result.Failure<object, ValidationError[]>
				);
	}
}
