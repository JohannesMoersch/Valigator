using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.DataContainers
{
	internal class NullableCollectionNullableDataContainer<TCollectionStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> : IDataContainer<Option<Option<TValue>[]>>, IAcceptCollectionValue<Option<Option<TValue>[]>, TSource>
		where TCollectionStateValidator : ICollectionStateValidator<Option<Option<TValue>[]>, TValue>
		where TValueValidatorOne : IValueValidator<Option<TValue>[]>
		where TValueValidatorTwo : IValueValidator<Option<TValue>[]>
		where TValueValidatorThree : IValueValidator<Option<TValue>[]>
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

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Option<Option<TValue>[]> value)
			=> this.IsValid(model, value, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree);

		Option<ValidationError[]> IDataContainer<Option<Option<TValue>[]>>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
