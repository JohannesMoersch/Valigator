using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core.DataContainers
{
	internal class NullableDataContainer<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> : IDataContainer<Option<TValue>>, IAcceptValue<Option<TValue>, TSource>
		where TStateValidator : struct, IStateValidator<Option<TValue>, TValue>
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

		public NullableDataContainer(Mapping<TSource, TValue> mapping, TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_mapping = mapping;
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		public Data<Option<TValue>> WithValue(Data<Option<TValue>> data, Option<TSource> value)
			=> data.WithMappedValidatedValue(value, _mapping, _stateValidator);

		public Data<Option<TValue>> WithUncheckedValue(Data<Option<TValue>> data, Option<TValue> value)
			=> data.WithValidatedValue(value);

		public Data<Option<TValue>> WithNull(Data<Option<TValue>> data)
			=> WithValue(data, Option.None<TSource>());

		public Result<Option<TValue>, ValidationError[]> IsValid(Option<object> model, Option<Option<TValue>> value)
		{
			if (value.TryGetValue(out var some) || _stateValidator.Validate(Option.None<Option<TValue>>()).TryGetValue(out some, out var failure))
			{
				if (this.IsValid(model, some, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree).TryGetValue(out var _, out failure))
					return Result.Success<Option<TValue>, ValidationError[]>(some);
			}

			return Result.Failure<Option<TValue>, ValidationError[]>(failure);
		}

		Option<ValidationError[]> IDataContainer<Option<TValue>>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
