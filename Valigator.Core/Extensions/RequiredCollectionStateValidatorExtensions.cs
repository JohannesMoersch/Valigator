using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredCollectionStateValidatorExtensions
	{
		public static DataSource<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this RequiredCollectionStateValidator<TValue> requiredCollection, int? minimumItems = null, int? maximumItems = null)
			=> new DataSource<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>(requiredCollection, new ItemCountValidator<TValue>(minimumItems, maximumItems));
	}
}
