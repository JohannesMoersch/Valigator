using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core.DataContainers
{
	internal static class DataContainerHelpers
	{
		public static Data<TDataValue> WithMappedValidatedValue<TDataValue, TSource, TValue, TStateValidator>(this Data<TDataValue> data, Optional<Option<TSource>> value, Mapping<TSource, TValue> mapping, TStateValidator stateValidator)
			where TStateValidator : struct, IStateValidator<TDataValue, TValue>
		{
			if (value.TryGetValue(out var set))
			{
				if (set.TryGetValue(out var some))
				{
					if (mapping.Map(some).TryGetValue(out var success, out var failure))
						return data.WithValidatedValue(Optional.Set(success), stateValidator);

					return data.WithErrors(failure);
				}

				return data.WithValidatedValue(Optional.Set(Option.None<TValue>()), stateValidator);
			}

			return data.WithValidatedValue(Optional.Unset<Option<TValue>>(), stateValidator);
		}

		public static Data<TDataValue> WithMappedValidatedValue<TDataValue, TSource, TValue, TCollectionStateValidator>(this Data<TDataValue> data, Optional<Option<Option<TSource>[]>> value, Mapping<TSource, TValue> mapping, TCollectionStateValidator stateValidator)
			where TCollectionStateValidator : struct, ICollectionStateValidator<TDataValue, TValue>
		{
			if (value.TryGetValue(out var set))
			{
				if (set.TryGetValue(out var some))
				{
					List<ValidationError> errors = null;
					var mappedValue = new Option<TValue>[some.Length];
					for (int i = 0; i < some.Length; ++i)
					{
						if (some[i].TryGetValue(out var item))
						{
							if (mapping.Map(item).TryGetValue(out var success, out var failure))
								mappedValue[i] = success;
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

					return data.WithValidatedValue(Optional.Set(Option.Some(mappedValue)), stateValidator);
				}
				
				return data.WithValidatedValue(Optional.Set(Option.None<Option<TValue>[]>()), stateValidator);
			}

			return data.WithValidatedValue(Optional.Unset<Option<Option<TValue>[]>>(), stateValidator);
		}

		public static Data<TDataValue> WithValidatedValue<TDataValue, TValue, TStateValidator>(this Data<TDataValue> data, Optional<Option<TValue>> value, TStateValidator stateValidator)
			where TStateValidator : struct, IStateValidator<TDataValue, TValue>
		{
			if (stateValidator.Validate(value).TryGetValue(out var success, out var failure))
				return data.WithValidatedValue(success);

			return data.WithErrors(failure);
		}

		public static Result<Unit, ValidationError[]> IsValid<TValue, TValidatorOne, TValidatorTwo, TValidatorThree>(this IDataContainer<Option<TValue>> _, Option<object> model, Option<TValue> value, TValidatorOne validatorOne, TValidatorTwo validatorTwo, TValidatorThree validatorThree)
			where TValidatorOne : struct, IValueValidator<TValue>
			where TValidatorTwo : struct, IValueValidator<TValue>
			where TValidatorThree : struct, IValueValidator<TValue>
		{
			if (value.TryGetValue(out var some))
				return IsValid(model, some, validatorOne, validatorTwo, validatorThree);

			return Result.Unit<ValidationError[]>();
		}

		public static Result<Unit, ValidationError[]> IsValid<TValue, TValidatorOne, TValidatorTwo, TValidatorThree>(this IDataContainer<Optional<TValue>> _, Option<object> model, Optional<TValue> value, TValidatorOne validatorOne, TValidatorTwo validatorTwo, TValidatorThree validatorThree)
			where TValidatorOne : struct, IValueValidator<TValue>
			where TValidatorTwo : struct, IValueValidator<TValue>
			where TValidatorThree : struct, IValueValidator<TValue>
		{
			if (value.TryGetValue(out var set))
				return IsValid(model, set, validatorOne, validatorTwo, validatorThree);

			return Result.Unit<ValidationError[]>();
		}

		public static Result<Unit, ValidationError[]> IsValid<TValue, TValidatorOne, TValidatorTwo, TValidatorThree>(this IDataContainer<Optional<Option<TValue>>> _, Option<object> model, Optional<Option<TValue>> value, TValidatorOne validatorOne, TValidatorTwo validatorTwo, TValidatorThree validatorThree)
			where TValidatorOne : struct, IValueValidator<TValue>
			where TValidatorTwo : struct, IValueValidator<TValue>
			where TValidatorThree : struct, IValueValidator<TValue>
		{
			if (value.TryGetValue(out var set) && set.TryGetValue(out var some))
				return IsValid(model, some, validatorOne, validatorTwo, validatorThree);

			return Result.Unit<ValidationError[]>();
		}

		public static Result<Unit, ValidationError[]> IsValid<TValue, TValidatorOne, TValidatorTwo, TValidatorThree>(this IDataContainer<TValue> _, Option<object> model, TValue value, TValidatorOne validatorOne, TValidatorTwo validatorTwo, TValidatorThree validatorThree)
			where TValidatorOne : struct, IValueValidator<TValue>
			where TValidatorTwo : struct, IValueValidator<TValue>
			where TValidatorThree : struct, IValueValidator<TValue>
			=> IsValid(model, value, validatorOne, validatorTwo, validatorThree);

		private static Result<Unit, ValidationError[]> IsValid<TValue, TValidatorOne, TValidatorTwo, TValidatorThree>(Option<object> model, TValue value, TValidatorOne validatorOne, TValidatorTwo validatorTwo, TValidatorThree validatorThree)
			where TValidatorOne : struct, IValueValidator<TValue>
			where TValidatorTwo : struct, IValueValidator<TValue>
			where TValidatorThree : struct, IValueValidator<TValue>
		{
			if (!model.TryGetValue(out var _))
			{
				if (validatorOne.RequiresModel || validatorTwo.RequiresModel || validatorThree.RequiresModel)
					throw new ModelRequiredException();
			}

			var innerValid = Model.Verify(value).TryGetValue(out var _, out var innerErrors);

			var oneValid = validatorOne.IsValid(model, value);
			var twoValid = validatorTwo.IsValid(model, value);
			var threeValid = validatorThree.IsValid(model, value);

			int count = (oneValid ? 0 : 1) + (twoValid ? 0 : 1) + (threeValid ? 0 : 1) + (innerErrors?.Length ?? 0);
			if (count > 0 || !innerValid)
			{
				var errors = new ValidationError[count];
				int index = 0;

				if (!oneValid)
					errors[index++] = validatorOne.GetError(value, false);

				if (!twoValid)
					errors[index++] = validatorTwo.GetError(value, false);

				if (!threeValid)
					errors[index++] = validatorThree.GetError(value, false);

				if (!innerValid)
				{
					foreach (var error in innerErrors)
						errors[index++] = error;
				}

				return Result.Failure<Unit, ValidationError[]>(errors);
			}

			return Result.Unit<ValidationError[]>();
		}
	}
}
