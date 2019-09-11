﻿using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Reflection;
using Functional;
using Valigator.Core;

namespace Valigator.AspNetCore
{
	public static class VerifiableExtensions
	{
		public static Result<object, ValidationError[]> Verify(this IVerifiable validateAttribute, object value)
			=> ExecuteValidator((dynamic)validateAttribute, Option.Some(Option.Create(value != null, value)));

		public static Result<object, ValidationError[]> Verify(this IVerifiable validateAttribute, Option<object> value) 
			=> ExecuteValidator((dynamic)validateAttribute, Option.Some(value));

		public static Result<object, ValidationError[]> Verify(this IVerifiable validateAttribute)
			=> ExecuteValidator((dynamic)validateAttribute, Option.None<Option<object>>());

		private static Result<object, ValidationError[]> ExecuteValidator<TDataValue>(IValidateType<TDataValue> validator, Option<Option<object>> value)
		{
			var data = validator.GetData();

			return ExecuteValidator(data, (dynamic)data.DataContainer, value);
		}

		private static Result<object, ValidationError[]> ExecuteValidator<TDataValue, TValue>(Data<TDataValue> data, IAcceptValue<TDataValue, TValue> dataContainer, Option<Option<object>> value)
			=> value
				.Match(
					success => Option.Some(success.Match(
						s => s is TValue ? success : throw new ValidateAttributeDoesNotSupportTypeException(s.GetType(), typeof(TValue)), 
						() => success
					)),
					() => Option.None<Option<object>>()
				)
				.Match
				(
					some => some
						.Match
						(
							o => dataContainer.WithValue(data, Option.Some((TValue)o)), 
							() => dataContainer.WithNull(data)
						),
					() => data
				)
				.Verify()
				.TryGetValue()
				.Match
				(
					o => Result.Success<object, ValidationError[]>(o),
					Result.Failure<object, ValidationError[]>
				);
	}
}
