using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core.DataContainers
{
	internal class NullableCollectionNullableDataContainer<TCollectionStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> : IDataContainer<Option<Option<TValue>[]>>, IAcceptCollectionValue<Option<Option<TValue>[]>, TSource>
		where TCollectionStateValidator : struct, ICollectionStateValidator<Option<Option<TValue>[]>, TValue>
		where TValueValidatorOne : struct, IValueValidator<Option<TValue>[]>
		where TValueValidatorTwo : struct, IValueValidator<Option<TValue>[]>
		where TValueValidatorThree : struct, IValueValidator<Option<TValue>[]>
	{
		private readonly Mapping<TSource, TValue> _mapping;

		private readonly TCollectionStateValidator _stateValidator;

		private readonly TValueValidatorOne _valueValidatorOne;

		private readonly TValueValidatorTwo _valueValidatorTwo;

		private readonly TValueValidatorThree _valueValidatorThree;

		public DataDescriptor DataDescriptor => DataDescriptor.Create(_mapping, _stateValidator, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree);

		public NullableCollectionNullableDataContainer(Mapping<TSource, TValue> mapping, TCollectionStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_mapping = mapping;
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		public Data<Option<Option<TValue>[]>> WithValue(Data<Option<Option<TValue>[]>> data, Option<Option<TSource>[]> value)
			=> data.WithMappedValidatedValue(value, _mapping, _stateValidator);

		public Data<Option<Option<TValue>[]>> WithNull(Data<Option<Option<TValue>[]>> data)
			=> WithValue(data, Option.None<Option<TSource>[]>());

		public Result<Option<Option<TValue>[]>, ValidationError[]> IsValid(Option<object> model, Option<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var some) || _stateValidator.Validate(Option.None<Option<Option<TValue>[]>>()).TryGetValue(out some, out var failure))
			{
				if (_stateValidator.IsValid(model, some).TryGetValue(out var _, out var itemErrors) & this.IsValid(model, some, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree).TryGetValue(out var __, out var collectionErrors))
					return Result.Success<Option<Option<TValue>[]>, ValidationError[]>(some);

				return Result.Failure<Option<Option<TValue>[]>, ValidationError[]>(collectionErrors.Concat(itemErrors).ToArray());
			}

			return Result.Failure<Option<Option<TValue>[]>, ValidationError[]>(failure);
		}

		Option<ValidationError[]> IDataContainer<Option<Option<TValue>[]>>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
