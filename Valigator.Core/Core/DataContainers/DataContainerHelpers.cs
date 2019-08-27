using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core.DataContainers
{
	internal static class DataContainerHelpers
	{
		public static Data<TDataValue> WithMappedValidatedValue<TDataValue, TSource, TValue>(this Data<TDataValue> data, Option<TSource> value, Mapping<TSource, TValue> mapping, IStateValidator<TDataValue, TValue> stateValidator)
		{
			if (value.TryGetValue(out var some))
			{
				if (mapping.Map(some).TryGetValue(out var success, out var failure))
					return data.WithValidatedValue(Option.Some(success), stateValidator);

				return data.WithErrors(failure);
			}

			return data.WithValidatedValue(Option.None<TValue>(), stateValidator);
		}

		public static Data<TDataValue> WithMappedValidatedValue<TDataValue, TSource, TValue>(this Data<TDataValue> data, Option<Option<TSource>[]> value, Mapping<TSource, TValue> mapping, ICollectionStateValidator<TDataValue, TValue> stateValidator)
		{
			if (value.TryGetValue(out var some))
			{
				List<ValidationError> errors = null;
				var mappedValue = new Option<TValue>[some.Length];
				for (int i = 0; i < some.Length; ++i)
				{
					if (some[i].TryGetValue(out var item))
					{
						if (mapping.Map(item).TryGetValue(out var success, out var failure))
							mappedValue[i] = Option.Some(success);
						else
						{
							foreach (var error in failure)
								error.Path.AddIndex(i);

							if (errors == null)
								errors = new List<ValidationError>();
							
							errors.AddRange(failure);
						}
					}
				}

				if (errors != null)
					return data.WithErrors(errors.ToArray());

				return data.WithValidatedValue(Option.Some(mappedValue), stateValidator);
			}

			return data.WithValidatedValue(Option.None<Option<TValue>[]>(), stateValidator);
		}

		public static Data<TDataValue> WithValidatedValue<TDataValue, TValue>(this Data<TDataValue> data, Option<TValue> value, IStateValidator<TDataValue, TValue> stateValidator)
		{
			if (stateValidator.WithValue(value).TryGetValue(out var success, out var failure))
				return data.WithValue(success);

			return data.WithErrors(failure);
		}

		public static Result<Unit, ValidationError[]> IsValid<TValue>(this IDataContainer<Option<TValue>> _, Option<object> model, Option<TValue> value, IValueValidator<TValue> validatorOne, IValueValidator<TValue> validatorTwo, IValueValidator<TValue> validatorThree)
		{
			if (value.TryGetValue(out var some))
				return IsValid(model, some, validatorOne, validatorTwo, validatorThree);

			return Result.Unit<ValidationError[]>();
		}

		public static Result<Unit, ValidationError[]> IsValid<TValue>(this IDataContainer<TValue> _, Option<object> model, TValue value, IValueValidator<TValue> validatorOne, IValueValidator<TValue> validatorTwo, IValueValidator<TValue> validatorThree)
			=> IsValid(model, value, validatorOne, validatorTwo, validatorThree);

		private static Result<Unit, ValidationError[]> IsValid<TValue>(Option<object> model, TValue value, IValueValidator<TValue> validatorOne, IValueValidator<TValue> validatorTwo, IValueValidator<TValue> validatorThree)
		{
			if (!model.TryGetValue(out var _))
			{
				if ((validatorOne?.RequiresModel ?? false) || (validatorTwo?.RequiresModel ?? false) || (validatorThree?.RequiresModel ?? false))
					throw new ModelRequiredException();
			}

			var oneValid = validatorOne?.IsValid(model, value) ?? true;
			var twoValid = validatorTwo?.IsValid(model, value) ?? true;
			var threeValid = validatorThree?.IsValid(model, value) ?? true;

			if (!oneValid || !twoValid || !threeValid)
			{
				var errors = new[]
				{
					!oneValid ? validatorOne.GetError(value, false) : null,
					!twoValid ? validatorTwo.GetError(value, false) : null,
					!threeValid ? validatorThree.GetError(value, false) : null
				};

				return Result.Failure<Unit, ValidationError[]>(errors);
			}

			return Result.Unit<ValidationError[]>();
		}
	}
}
