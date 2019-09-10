using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core.DataContainers
{
	internal class DataContainer<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> : IDataContainer<TValue>, IAcceptValue<TValue, TSource>
		where TStateValidator : struct, IStateValidator<TValue, TValue>
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

		public DataContainer(Mapping<TSource, TValue> mapping, TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_mapping = mapping;
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		public Data<TValue> WithValue(Data<TValue> data, Option<TSource> value)
			=> data.WithMappedValidatedValue(value, _mapping, _stateValidator);

		public Data<TValue> WithUncheckedValue(Data<TValue> data, TValue value)
			=> data.WithValidatedValue(value);

		public Data<TValue> WithNull(Data<TValue> data)
			=> WithValue(data, Option.None<TSource>());

		public Result<TValue, ValidationError[]> IsValid(Option<object> model, Option<TValue> value)
		{
			if (value.TryGetValue(out var some) || _stateValidator.Validate(Option.None<Option<TValue>>()).TryGetValue(out some, out var failure))
			{
				if (this.IsValid(model, some, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree).TryGetValue(out var _, out failure))
					return Result.Success<TValue, ValidationError[]>(some);
			}

			return Result.Failure<TValue, ValidationError[]>(failure);
		}

		Option<ValidationError[]> IDataContainer<TValue>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
