using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;

namespace Valigator
{
	internal static class CommonStateValidatorExtensions
	{
		// Defaulted Nullable Collection

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]> Add<TValueValidator, TValue>(this DefaultedCollectionNullableStateValidator<TValue> defaultedCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]>(defaultedCollection, valueValidator);

		public static NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DefaultedCollectionNullableStateValidator<TValue> defaultedCollection, Func<DefaultedCollectionNullableStateValidator<TValue>, NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedCollection).InvertOne();

		// Defaulted Collection

		public static DataSourceStandard<DefaultedCollectionStateValidator<TValue>, TValueValidator, TValue[]> Add<TValueValidator, TValue>(this DefaultedCollectionStateValidator<TValue> defaultedCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new DataSourceStandard<DefaultedCollectionStateValidator<TValue>, TValueValidator, TValue[]>(defaultedCollection, valueValidator);

		public static DataSourceInverted<DefaultedCollectionStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DefaultedCollectionStateValidator<TValue> defaultedCollection, Func<DefaultedCollectionStateValidator<TValue>, DataSourceStandard<DefaultedCollectionStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedCollection).InvertOne();

		// Optional Nullable Collection

		public static NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]> Add<TValueValidator, TValue>(this OptionalCollectionNullableStateValidator<TValue> optionalCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]>(optionalCollection, valueValidator);

		public static NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this OptionalCollectionNullableStateValidator<TValue> optionalCollection, Func<OptionalCollectionNullableStateValidator<TValue>, NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(optionalCollection).InvertOne();

		// Optional Collection

		public static NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, TValueValidator, TValue[]> Add<TValueValidator, TValue>(this OptionalCollectionStateValidator<TValue> optionalCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, TValueValidator, TValue[]>(optionalCollection, valueValidator);

		public static NullableDataSourceInverted<OptionalCollectionStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this OptionalCollectionStateValidator<TValue> optionalCollection, Func<OptionalCollectionStateValidator<TValue>, NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(optionalCollection).InvertOne();

		// Required Nullable Collection

		public static NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]> Add<TValueValidator, TValue>(this RequiredCollectionNullableStateValidator<TValue> requiredCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]>(requiredCollection, valueValidator);

		public static NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this RequiredCollectionNullableStateValidator<TValue> requiredCollection, Func<RequiredCollectionNullableStateValidator<TValue>, NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(requiredCollection).InvertOne();

		// Required Collection

		public static DataSourceStandard<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[]> Add<TValueValidator, TValue>(this RequiredCollectionStateValidator<TValue> requiredCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new DataSourceStandard<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[]>(requiredCollection, valueValidator);

		public static DataSourceInverted<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this RequiredCollectionStateValidator<TValue> requiredCollection, Func<RequiredCollectionStateValidator<TValue>, DataSourceStandard<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(requiredCollection).InvertOne();

		// Defaulted Nullable

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, TValueValidator, TValue> Add<TValueValidator, TValue>(this DefaultedNullableStateValidator<TValue> defaulted, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, TValueValidator, TValue>(defaulted, valueValidator);

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this DefaultedNullableStateValidator<TValue> defaulted, Func<DefaultedNullableStateValidator<TValue>, NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(defaulted).InvertOne();

		// Defaulted

		public static DataSourceStandard<DefaultedStateValidator<TValue>, TValueValidator, TValue> Add<TValueValidator, TValue>(this DefaultedStateValidator<TValue> defaulted, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new DataSourceStandard<DefaultedStateValidator<TValue>, TValueValidator, TValue>(defaulted, valueValidator);

		public static DataSourceInverted<DefaultedStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this DefaultedStateValidator<TValue> defaulted, Func<DefaultedStateValidator<TValue>, DataSourceStandard<DefaultedStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(defaulted).InvertOne();

		// Optional Nullable

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, TValueValidator, TValue> Add<TValueValidator, TValue>(this OptionalNullableStateValidator<TValue> optional, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, TValueValidator, TValue>(optional, valueValidator);

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this OptionalNullableStateValidator<TValue> optional, Func<OptionalNullableStateValidator<TValue>, NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(optional).InvertOne();

		// Optional

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, TValueValidator, TValue> Add<TValueValidator, TValue>(this OptionalStateValidator<TValue> optional, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<OptionalStateValidator<TValue>, TValueValidator, TValue>(optional, valueValidator);

		public static NullableDataSourceInverted<OptionalStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this OptionalStateValidator<TValue> optional, Func<OptionalStateValidator<TValue>, NullableDataSourceStandard<OptionalStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(optional).InvertOne();

		// Required Nullable

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, TValueValidator, TValue> Add<TValueValidator, TValue>(this RequiredNullableStateValidator<TValue> required, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, TValueValidator, TValue>(required, valueValidator);

		public static NullableDataSourceInverted<RequiredNullableStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this RequiredNullableStateValidator<TValue> required, Func<RequiredNullableStateValidator<TValue>, NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(required).InvertOne();

		// Required

		public static DataSourceStandard<RequiredStateValidator<TValue>, TValueValidator, TValue> Add<TValueValidator, TValue>(this RequiredStateValidator<TValue> required, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new DataSourceStandard<RequiredStateValidator<TValue>, TValueValidator, TValue>(required, valueValidator);

		public static DataSourceInverted<RequiredStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this RequiredStateValidator<TValue> required, Func<RequiredStateValidator<TValue>, DataSourceStandard<RequiredStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(required).InvertOne();
	}
}
