using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core.DataContainers
{
	internal class CollectionDataContainer<TCollectionStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue> : IDataContainer<TValue[]>, IAcceptCollectionValue<TValue[], TValue>
		where TCollectionStateValidator : ICollectionStateValidator<TValue, TValue>
		where TValueValidatorOne : IValueValidator<TValue[]>
		where TValueValidatorTwo : IValueValidator<TValue[]>
		where TValueValidatorThree : IValueValidator<TValue[]>
	{
		private readonly TCollectionStateValidator _stateValidator;

		private readonly TValueValidatorOne _valueValidatorOne;

		private readonly TValueValidatorTwo _valueValidatorTwo;

		private readonly TValueValidatorThree _valueValidatorThree;

		public DataDescriptor DataDescriptor { get; }

		public CollectionDataContainer(TCollectionStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		public Data<TValue[]> WithValue(Data<TValue[]> data, Option<Option<TValue>[]> value)
		{
			if (_stateValidator.WithValue(value).TryGetValue(out var success, out var failure))
				return data.WithValue(success);

			return data.WithErrors(failure);
		}

		public Result<Unit, ValidationError[]> IsValid(object model, TValue[] value)
		{
			var oneValid = _valueValidatorOne?.IsValid(value) ?? true;
			var twoValid = _valueValidatorTwo?.IsValid(value) ?? true;
			var threeValid = _valueValidatorThree?.IsValid(value) ?? true;

			if (!oneValid || !twoValid || !threeValid)
			{
				var errors = new[]
				{
					!oneValid ? _valueValidatorOne.GetError(value, false) : null,
					!twoValid ? _valueValidatorTwo.GetError(value, false) : null,
					!threeValid ? _valueValidatorThree.GetError(value, false) : null
				};

				return Result.Failure<Unit, ValidationError[]>(errors);
			}

			return Result.Unit<ValidationError[]>();
		}

		Option<ValidationError[]> IDataContainer<TValue[]>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
