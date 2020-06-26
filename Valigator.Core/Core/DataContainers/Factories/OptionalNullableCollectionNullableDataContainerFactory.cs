using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.DataContainers.Factories
{
	public struct OptionalNullableCollectionNullableDataContainerFactory<TStateValidator, TSource, TValue> : IDataContainerFactory<Optional<Option<Option<TValue>[]>>, Option<TValue>[]>
		where TStateValidator : struct, ICollectionStateValidator<Optional<Option<Option<TValue>[]>>, TValue>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Mapping<TSource, TValue> _mapping;

		public OptionalNullableCollectionNullableDataContainerFactory(TStateValidator stateValidator, Mapping<TSource, TValue> mapping)
		{
			_stateValidator = stateValidator;
			_mapping = mapping;
		}

		public IDataContainer<Optional<Option<Option<TValue>[]>>> Create<TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree>(TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
			where TValueValidatorOne : struct, IValueValidator<Option<TValue>[]>
			where TValueValidatorTwo : struct, IValueValidator<Option<TValue>[]>
			where TValueValidatorThree : struct, IValueValidator<Option<TValue>[]>
			=> new OptionalNullableCollectionNullableDataContainer<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue>(_mapping, _stateValidator, valueValidatorOne, valueValidatorTwo, valueValidatorThree);
	}
}
