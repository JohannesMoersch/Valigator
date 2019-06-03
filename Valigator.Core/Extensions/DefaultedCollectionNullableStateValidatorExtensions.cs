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
		public static NullableDataSource<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this DefaultedCollectionNullableStateValidator<TValue> defaultedCollection, int? minimumItems = null, int? maximumItems = null)
			=> new NullableDataSource<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>(defaultedCollection, new ItemCountValidator<TValue>(minimumItems, maximumItems));
	}
}
