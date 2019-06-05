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

		// Defaulted Collection

		public static DataSourceStandard<DefaultedCollectionStateValidator<TValue>, TValueValidator, TValue[]> Add<TValueValidator, TValue>(this DefaultedCollectionStateValidator<TValue> defaultedCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new DataSourceStandard<DefaultedCollectionStateValidator<TValue>, TValueValidator, TValue[]>(defaultedCollection, valueValidator);

		// Optional Nullable Collection

		public static NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]> Add<TValueValidator, TValue>(this OptionalCollectionNullableStateValidator<TValue> optionalCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]>(optionalCollection, valueValidator);

		// Optional Collection

		public static NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, TValueValidator, TValue[]> Add<TValueValidator, TValue>(this OptionalCollectionStateValidator<TValue> optionalCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, TValueValidator, TValue[]>(optionalCollection, valueValidator);

		// Required Nullable Collection

		public static NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]> Add<TValueValidator, TValue>(this RequiredCollectionNullableStateValidator<TValue> requiredCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]>(requiredCollection, valueValidator);

		// Required Collection

		public static DataSourceStandard<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[]> Add<TValueValidator, TValue>(this RequiredCollectionStateValidator<TValue> requiredCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new DataSourceStandard<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[]>(requiredCollection, valueValidator);

		// Defaulted Nullable

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, TValueValidator, TValue> Add<TValueValidator, TValue>(this DefaultedNullableStateValidator<TValue> defaulted, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, TValueValidator, TValue>(defaulted, valueValidator);

		// Defaulted

		public static DataSourceStandard<DefaultedStateValidator<TValue>, TValueValidator, TValue> Add<TValueValidator, TValue>(this DefaultedStateValidator<TValue> defaulted, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new DataSourceStandard<DefaultedStateValidator<TValue>, TValueValidator, TValue>(defaulted, valueValidator);

		// Optional Nullable

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, TValueValidator, TValue> Add<TValueValidator, TValue>(this OptionalNullableStateValidator<TValue> optional, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, TValueValidator, TValue>(optional, valueValidator);

		// Optional

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, TValueValidator, TValue> Add<TValueValidator, TValue>(this OptionalStateValidator<TValue> optional, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<OptionalStateValidator<TValue>, TValueValidator, TValue>(optional, valueValidator);

		// Required Nullable

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, TValueValidator, TValue> Add<TValueValidator, TValue>(this RequiredNullableStateValidator<TValue> required, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, TValueValidator, TValue>(required, valueValidator);

		// Required

		public static DataSourceStandard<RequiredStateValidator<TValue>, TValueValidator, TValue> Add<TValueValidator, TValue>(this RequiredStateValidator<TValue> required, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new DataSourceStandard<RequiredStateValidator<TValue>, TValueValidator, TValue>(required, valueValidator);
	}
}
