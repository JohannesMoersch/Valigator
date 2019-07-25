using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Reflection;
using Functional;

namespace Valigator
{
	internal static class VerifiableExtensions
	{
		private static readonly object _obj = new object();

		private static readonly ConcurrentDictionary<Type, Func<IVerifiable, bool, object, Result<object, ValidationError[]>>> _verifyMethods = new ConcurrentDictionary<Type, Func<IVerifiable, bool, object, Result<object, ValidationError[]>>>();

		public static Result<object, ValidationError[]> VerifyObject(this IVerifiable validateAttribute, Type type, object value)
			=> _verifyMethods
				.GetOrAdd(type, t => GenerateVerifyMethod(type))
				.Invoke(validateAttribute, true, value);

		public static Result<object, ValidationError[]> VerifyObject(this IVerifiable validateAttribute, Type type)
			=> _verifyMethods
				.GetOrAdd(type, t => GenerateVerifyMethod(type))
				.Invoke(validateAttribute, false, null);

		private static Func<IVerifiable, bool, object, Result<object, ValidationError[]>> GenerateVerifyMethod(Type type)
		{
			var validateType = typeof(IValidateType<>).MakeGenericType(type);

			var validateMethod = typeof(ValidationHelpers).GetMethod(nameof(ValidationHelpers.ValidateType), BindingFlags.Public | BindingFlags.Static).MakeGenericMethod(type);
			var getDataMethod = validateType.GetMethod(nameof(IValidateType<object>.GetData), BindingFlags.Public | BindingFlags.Instance);
			var verifyMethod = typeof(VerifiableExtensions).GetMethod(nameof(PerformVerification), BindingFlags.NonPublic | BindingFlags.Static).MakeGenericMethod(type);

			var attributeParameter = Expression.Parameter(typeof(IVerifiable), "attribute");
			var convertedAttributeParameter = Expression.Convert(attributeParameter, typeof(object));
			var isSetParameter = Expression.Parameter(typeof(bool), "isSet");
			var valueParameter = Expression.Parameter(typeof(object), "value");

			var validate = Expression.Call(validateMethod, convertedAttributeParameter);

			var data = Expression.Call(Expression.Convert(attributeParameter, validateType), getDataMethod);
			var verified = Expression.Call(verifyMethod, data, isSetParameter, valueParameter);

			var block = Expression.Block(validate, verified);

			return Expression.Lambda<Func<IVerifiable, bool, object, Result<object, ValidationError[]>>>(block, attributeParameter, isSetParameter, valueParameter).Compile();
		}

		private static Result<object, ValidationError[]> PerformVerification<TValue>(Data<TValue> data, bool isSet, object value)
			=> (isSet ? data.WithValue((TValue)value) : data)
				.Verify(_obj)
				.TryGetValue()
				.Match
				(
					v => Result.Success<object, ValidationError[]>(v),
					Result.Failure<object, ValidationError[]>
				);
	}
}
