using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core.DataContainers
{
	internal class NullableOptionalDataContainer<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> : IDataContainer<Optional<Option<TValue>>>, IAcceptValue<Optional<Option<TValue>>, TSource>
		where TStateValidator : struct, IStateValidator<Optional<Option<TValue>>, TValue>
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

		public NullableOptionalDataContainer(Mapping<TSource, TValue> mapping, TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_mapping = mapping;
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		public Data<Optional<Option<TValue>>> WithValue(Data<Optional<Option<TValue>>> data, Option<TSource> value)
			=> data.WithMappedValidatedValue(value, _mapping, _stateValidator);

		public Data<Optional<Option<TValue>>> WithUncheckedValue(Data<Optional<Option<TValue>>> data, Optional<Option<TValue>> value)
			=> data.WithValidatedValue(value);

		public Data<Optional<Option<TValue>>> WithNull(Data<Optional<Option<TValue>>> data)
			=> WithValue(data, Option.None<TSource>());

		public Result<Optional<Option<TValue>>, ValidationError[]> IsValid(Option<object> model, Optional<Optional<Option<TValue>>> value)
		{
			if (value.TryGetValue(out var some) || _stateValidator.Validate(Optional.Unset<Option<TValue>>()).TryGetValue(out some, out var failure))
			{
				if (this.IsValid(model, some, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree).TryGetValue(out var _, out failure))
					return Result.Success<Optional<Option<TValue>>, ValidationError[]>(some);
			}

			return Result.Failure<Optional<Option<TValue>>, ValidationError[]>(failure);
		}

		Option<ValidationError[]> IDataContainer<Optional<Option<TValue>>>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
