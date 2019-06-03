using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedCollectionNullableStateValidatorExtensions
	{
		public static NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DefaultedCollectionNullableStateValidator<TValue> defaultedValidator, Func<DefaultedCollectionNullableStateValidator<TValue>, NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).Invert();

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this DefaultedCollectionNullableStateValidator<TValue> defaultedCollection, int? minimumItems = null, int? maximumItems = null)
			=> new NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>(defaultedCollection, new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this DefaultedCollectionNullableStateValidator<TValue> defaultedCollection)
			=> new NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>(defaultedCollection, new UniqueValidator<TValue>());
	}
}
