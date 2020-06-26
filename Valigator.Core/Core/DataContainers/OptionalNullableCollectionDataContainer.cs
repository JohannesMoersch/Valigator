using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core.DataContainers
{
	internal class OptionalNullableCollectionDataContainer<TCollectionStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> : IDataContainer<Optional<Option<TValue[]>>>, IAcceptCollectionValue<Optional<Option<TValue[]>>, TSource>
		where TCollectionStateValidator : struct, ICollectionStateValidator<Optional<Option<TValue[]>>, TValue>
		where TValueValidatorOne : struct, IValueValidator<TValue[]>
		where TValueValidatorTwo : struct, IValueValidator<TValue[]>
		where TValueValidatorThree : struct, IValueValidator<TValue[]>
	{
		private readonly Mapping<TSource, TValue> _mapping;

		private readonly TCollectionStateValidator _stateValidator;

		private readonly TValueValidatorOne _valueValidatorOne;

		private readonly TValueValidatorTwo _valueValidatorTwo;

		private readonly TValueValidatorThree _valueValidatorThree;

		public DataDescriptor DataDescriptor => DataDescriptor.Create(_mapping, _stateValidator, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree);

		public Type ValueType => typeof(TSource);

		public OptionalNullableCollectionDataContainer(Mapping<TSource, TValue> mapping, TCollectionStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_mapping = mapping;
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		public Data<Optional<Option<TValue[]>>> WithValue(Data<Optional<Option<TValue[]>>> data, Option<Option<TSource>[]> value)
			=> data.WithMappedValidatedValue(Optional.Set(value), _mapping, _stateValidator);

		public Data<Optional<Option<TValue[]>>> WithUncheckedValue(Data<Optional<Option<TValue[]>>> data, Optional<Option<TValue[]>> value)
			=> data.WithValidatedValue(value);

		public Data<Optional<Option<TValue[]>>> WithNull(Data<Optional<Option<TValue[]>>> data)
			=> WithValue(data, Option.None<Option<TSource>[]>());

		public Result<Optional<Option<TValue[]>>, ValidationError[]> IsValid(Option<object> model, Optional<Optional<Option<TValue[]>>> value)
		{
			if (value.TryGetValue(out var some) || _stateValidator.Validate(Optional.Unset<Option<Option<TValue>[]>>()).TryGetValue(out some, out var failure))
			{
				if (_stateValidator.IsValid(model, some).TryGetValue(out var _, out var itemErrors) & this.IsValid(model, some, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree).TryGetValue(out var __, out var collectionErrors))
					return Result.Success<Optional<Option<TValue[]>>, ValidationError[]>(some);

				return Result.Failure<Optional<Option<TValue[]>>, ValidationError[]>(collectionErrors.Concat(itemErrors ?? Enumerable.Empty<ValidationError>()).ToArray());
			}

			return Result.Failure<Optional<Option<TValue[]>>, ValidationError[]>(failure);
		}

		Option<ValidationError[]> IDataContainer<Optional<Option<TValue[]>>>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
