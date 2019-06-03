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
		public static NullableDataSource<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this OptionalCollectionStateValidator<TValue> optionalCollection, int? minimumItems = null, int? maximumItems = null)
			=> new NullableDataSource<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>(optionalCollection, new ItemCountValidator<TValue>(minimumItems, maximumItems));
	}
}
