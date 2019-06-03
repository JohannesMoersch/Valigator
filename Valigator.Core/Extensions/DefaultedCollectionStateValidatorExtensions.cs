using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedCollectionStateValidatorExtensions
	{
		public static DataSourceInverted<DefaultedCollectionStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DefaultedCollectionStateValidator<TValue> defaultedValidator, Func<DefaultedCollectionStateValidator<TValue>, DataSourceStandard<DefaultedCollectionStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).InvertOne();

		public static DataSourceStandard<DefaultedCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this DefaultedCollectionStateValidator<TValue> defaultedCollection, int? minimumItems = null, int? maximumItems = null)
			=> new DataSourceStandard<DefaultedCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>(defaultedCollection, new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandard<DefaultedCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this DefaultedCollectionStateValidator<TValue> defaultedCollection)
			=> new DataSourceStandard<DefaultedCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>(defaultedCollection, new UniqueValidator<TValue>());
	}
}
