using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.DataContainers.Factories
{
	internal struct CollectionNullableDataContainerFactory<TStateValidator, TSource, TValue> : IDataContainerFactory<Option<TValue>[], Option<TValue>[]>
		where TStateValidator : struct, ICollectionStateValidator<Option<TValue>[], TValue>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Mapping<TSource, TValue> _mapping;

		public CollectionNullableDataContainerFactory(TStateValidator stateValidator, Mapping<TSource, TValue> mapping)
		{
			_stateValidator = stateValidator;
			_mapping = mapping;
		}

		public IDataContainer<Option<TValue>[]> Create<TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree>(TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
			where TValueValidatorOne : struct, IValueValidator<Option<TValue>[]>
			where TValueValidatorTwo : struct, IValueValidator<Option<TValue>[]>
			where TValueValidatorThree : struct, IValueValidator<Option<TValue>[]>
			=> new CollectionNullableDataContainer<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue>(_mapping, _stateValidator, valueValidatorOne, valueValidatorTwo, valueValidatorThree);
	}
}
