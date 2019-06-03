using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalCollectionStateValidatorExtensions
	{
		public static NullableDataSourceInverted<OptionalCollectionStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this OptionalCollectionStateValidator<TValue> optionalValidator, Func<OptionalCollectionStateValidator<TValue>, NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(optionalValidator).Invert();

		public static NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this OptionalCollectionStateValidator<TValue> optionalCollection, int? minimumItems = null, int? maximumItems = null)
			=> new NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>(optionalCollection, new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this OptionalCollectionStateValidator<TValue> optionalCollection)
			=> new NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>(optionalCollection, new UniqueValidator<TValue>());
	}
}
