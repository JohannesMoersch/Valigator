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
		public static DataSourceInverted<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this RequiredCollectionStateValidator<TValue> requiredValidator, Func<RequiredCollectionStateValidator<TValue>, DataSourceStandard<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(requiredValidator).InvertOne();

		public static DataSourceStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this RequiredCollectionStateValidator<TValue> requiredCollection, int? minimumItems = null, int? maximumItems = null)
			=> new DataSourceStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>(requiredCollection, new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this RequiredCollectionStateValidator<TValue> requiredCollection)
			=> new DataSourceStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>(requiredCollection, new UniqueValidator<TValue>());
	}
}
