using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.DataContainers
{
	internal class CollectionNullableDataContainer<TCollectionStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> : IDataContainer<Option<TValue>[]>, IAcceptCollectionValue<Option<TValue>[], TSource>
		where TCollectionStateValidator : ICollectionStateValidator<Option<TValue>[], TValue>
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

		public CollectionNullableDataContainer(Mapping<TSource, TValue> mapping, TCollectionStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_mapping = mapping;
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		public Data<Option<TValue>[]> WithValue(Data<Option<TValue>[]> data, Option<Option<TSource>[]> value)
			=> data.WithMappedValidatedValue(value, _mapping, _stateValidator);

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Option<TValue>[] value)
			=> this.IsValid(model, value, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree);

		Option<ValidationError[]> IDataContainer<Option<TValue>[]>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
