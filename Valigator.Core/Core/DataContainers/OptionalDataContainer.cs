using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core.DataContainers
{
	internal class OptionalDataContainer<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> : IDataContainer<Optional<TValue>>, IAcceptValue<Optional<TValue>, TSource>
		where TStateValidator : struct, IStateValidator<Optional<TValue>, TValue>
		where TValueValidatorOne : struct, IValueValidator<TValue>
		where TValueValidatorTwo : struct, IValueValidator<TValue>
		where TValueValidatorThree : struct, IValueValidator<TValue>
	{
		private readonly Mapping<TSource, TValue> _mapping;

		private readonly TStateValidator _stateValidator;

		private readonly TValueValidatorOne _valueValidatorOne;

		private readonly TValueValidatorTwo _valueValidatorTwo;

		private readonly TValueValidatorThree _valueValidatorThree;

		public DataDescriptor DataDescriptor => DataDescriptor.Create(_mapping, _stateValidator, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree);

		public Type ValueType => typeof(TSource);

		public OptionalDataContainer(Mapping<TSource, TValue> mapping, TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_mapping = mapping;
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		public Data<Optional<TValue>> WithValue(Data<Optional<TValue>> data, Option<TSource> value)
			=> data.WithMappedValidatedValue(Optional.Set(value), _mapping, _stateValidator);

		public Data<Optional<TValue>> WithUncheckedValue(Data<Optional<TValue>> data, Optional<TValue> value)
			=> data.WithValidatedValue(value);

		public Data<Optional<TValue>> WithNull(Data<Optional<TValue>> data)
			=> WithValue(data, Option.None<TSource>());

		public Result<Optional<TValue>, ValidationError[]> IsValid(Option<object> model, Optional<Optional<TValue>> value)
		{
			if (value.TryGetValue(out var some) || _stateValidator.Validate(Optional.Unset<Option<TValue>>()).TryGetValue(out some, out var failure))
			{
				if (this.IsValid(model, some, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree).TryGetValue(out var _, out failure))
					return Result.Success<Optional<TValue>, ValidationError[]>(some);
			}

			return Result.Failure<Optional<TValue>, ValidationError[]>(failure);
		}

		Option<ValidationError[]> IDataContainer<Optional<TValue>>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
