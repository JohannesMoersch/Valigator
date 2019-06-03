using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalCollectionNullableStateValidatorExtensions
	{
		public static NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this OptionalCollectionNullableStateValidator<TValue> optionalValidator, Func<OptionalCollectionNullableStateValidator<TValue>, NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(optionalValidator).InvertOne();

		public static NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this OptionalCollectionNullableStateValidator<TValue> optionalCollection, int? minimumItems = null, int? maximumItems = null)
			=> new NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>(optionalCollection, new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this OptionalCollectionNullableStateValidator<TValue> optionalCollection)
			=> new NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>(optionalCollection, new UniqueValidator<TValue>());
	}
}
