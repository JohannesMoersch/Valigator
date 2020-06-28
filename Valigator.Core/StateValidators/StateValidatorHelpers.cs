using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core.StateValidators
{
	public static class StateValidatorHelpers
	{
		public static TValue GetDefaultValue<TValue>(Option<TValue> defaultValue, Func<TValue> defaultValueFactory)
		{
			if (defaultValueFactory != null)
			{
				var value = defaultValueFactory.Invoke();

				if (value == null)
					throw new NullDefaultException();

				return value;
			}

			return defaultValue.TryGetValue(out var some) ? some : default;
		}

		public static Option<object[]> GetDefaultValueForDescriptor<TValue>(Option<TValue[]> defaultValue, Func<TValue[]> defaultValueFactory)
			=> Option
				.Some
				(
					GetDefaultValue(defaultValue, defaultValueFactory)
					.Cast<object>()
					.ToArray()
				);

		public static Option<object[]> GetDefaultValueForDescriptor<TDataValue, TValue>(Option<Option<TValue>[]> defaultValue, Func<Option<TValue>[]> defaultValueFactory)
		{
			var values = GetDefaultValue(defaultValue, defaultValueFactory);
			var ret = new object[values.Length];

			for (int i = 0; i < values.Length; ++i)
				ret[i] = values[i].TryGetValue(out var some) ? (object)some : null;

			return Option.Some(ret);
		}

		public static Result<Unit, ValidationError[]> IsCollectionValid<TValue>(Data<TValue> data, Option<object> model, Optional<Option<Option<TValue>[]>> value)
			=> value.TryGetValue(out var some)
				? IsCollectionValid(data, model, some)
				: Result.Unit<ValidationError[]>();

		public static Result<Unit, ValidationError[]> IsCollectionValid<TValue>(Data<TValue> data, Option<object> model, Option<Option<TValue>[]> value)
			=> value.TryGetValue(out var some)
				? IsCollectionValid(data, model, some)
				: Result.Unit<ValidationError[]>();

		public static Result<Unit, ValidationError[]> IsCollectionValid<TValue>(Data<TValue> data, Option<object> model, Optional<Option<TValue[]>> value)
			=> value.TryGetValue(out var some)
				? IsCollectionValid(data, model, some)
				: Result.Unit<ValidationError[]>();

		public static Result<Unit, ValidationError[]> IsCollectionValid<TValue>(Data<TValue> data, Option<object> model, Optional<TValue[]> value)
			=> value.TryGetValue(out var some)
				? IsCollectionValid(data, model, some)
				: Result.Unit<ValidationError[]>();

		public static Result<Unit, ValidationError[]> IsCollectionValid<TValue>(Data<TValue> data, Option<object> model, Option<TValue>[] value)
		{
			List<ValidationError> errors = null;
			for (int i = 0; i < value.Length; ++i)
			{
				if (value[i].TryGetValue(out var some) && !data.WithValidatedValue(some).Verify(model).TryGetValue().TryGetValue(out var _, out var failure))
				{
					foreach (var error in errors)
						error.Path.AddIndex(i);

					if (errors == null)
						errors = new List<ValidationError>();

					errors.AddRange(failure);
				}
			}

			if (errors != null)
				return Result.Failure<Unit, ValidationError[]>(errors.ToArray());

			return Result.Unit<ValidationError[]>();
		}

		public static Result<Unit, ValidationError[]> IsCollectionValid<TValue>(Data<TValue> data, Option<object> model, Option<TValue[]> value)
			=> value.TryGetValue(out var some)
				? IsCollectionValid(data, model, some)
				: Result.Unit<ValidationError[]>();

		public static Result<Unit, ValidationError[]> IsCollectionValid<TValue>(Data<TValue> data, Option<object> model, TValue[] value)
		{
			List<ValidationError> errors = null;
			for (int i = 0; i < value.Length; ++i)
			{
				if (!data.WithValidatedValue(value[i]).Verify(model).TryGetValue().TryGetValue(out var _, out var failure))
				{
					if (errors == null)
						errors = new List<ValidationError>();

					errors.AddRange(failure);

					foreach (var error in failure)
						error.Path.AddIndex(i);
				}
			}

			if (errors != null)
				return Result.Failure<Unit, ValidationError[]>(errors.ToArray());

			return Result.Unit<ValidationError[]>();
		}

		public static Result<TValue[], ValidationError[]> ValidateCollectionNotNull<TValue>(Option<TValue>[] values)
		{
			List<ValidationError> errors = null;

			var results = new TValue[values.Length];

			for (int i = 0; i < values.Length; ++i)
			{
				if (values[i].TryGetValue(out var some))
					results[i] = some;
				else
				{
					var error = ValidationErrors.NotNull();
					error.Path.AddIndex(i);

					if (errors == null)
						errors = new List<ValidationError>();

					errors.Add(error);
				}
			}

			if (errors != null)
				return Result.Failure<TValue[], ValidationError[]>(errors.ToArray());

			return Result.Success<TValue[], ValidationError[]>(results);
		}
	}
}
