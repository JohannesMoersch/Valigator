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
		public static NullableDataSource<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this OptionalCollectionNullableStateValidator<TValue> optionalCollection, int? minimumItems = null, int? maximumItems = null)
			=> new NullableDataSource<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>(optionalCollection, new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSource<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this OptionalCollectionNullableStateValidator<TValue> optionalCollection)
			=> new NullableDataSource<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>(optionalCollection, new UniqueValidator<TValue>());
	}
}
