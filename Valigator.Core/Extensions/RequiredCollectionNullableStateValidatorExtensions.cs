using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredCollectionNullableStateValidatorExtensions
	{
		public static NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this RequiredCollectionNullableStateValidator<TValue> requiredValidator, Func<RequiredCollectionNullableStateValidator<TValue>, NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(requiredValidator).Invert();

		public static NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this RequiredCollectionNullableStateValidator<TValue> requiredCollection, int? minimumItems = null, int? maximumItems = null)
			=> new NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>(requiredCollection, new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this RequiredCollectionNullableStateValidator<TValue> requiredCollection)
			=> new NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>(requiredCollection, new UniqueValidator<TValue>());
	}
}
