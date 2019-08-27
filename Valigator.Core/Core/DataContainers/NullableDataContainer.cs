using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.DataContainers
{
	internal class NullableDataContainer<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> : IDataContainer<Option<TValue>>, IAcceptValue<Option<TValue>, TSource>
		where TStateValidator : IStateValidator<Option<TValue>, TValue>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
		where TValueValidatorThree : IValueValidator<TValue>
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

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Option<TValue> value)
			=> this.IsValid(model, value, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree);

		Option<ValidationError[]> IDataContainer<Option<TValue>>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
