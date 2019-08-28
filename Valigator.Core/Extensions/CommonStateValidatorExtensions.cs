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

		public static NullableDataSourceStandard<DefaultedNullableCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]> Add<TValueValidator, TValue>(this DefaultedNullableCollectionStateValidator<TValue> defaultedCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<DefaultedNullableCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]>(defaultedCollection, valueValidator, Mapping.Create<TValue[], TValue[]>(_ => _));

		// Defaulted Collection

		public static DataSourceStandard<DefaultedCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]> Add<TValueValidator, TValue>(this DefaultedCollectionStateValidator<TValue> defaultedCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new DataSourceStandard<DefaultedCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]>(defaultedCollection, valueValidator, Mapping.Create<TValue[], TValue[]>(_ => _));

		// Optional Nullable Collection

		public static NullableDataSourceStandard<OptionalNullableCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]> Add<TValueValidator, TValue>(this OptionalNullableCollectionStateValidator<TValue> optionalCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<OptionalNullableCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]>(optionalCollection, valueValidator, Mapping.Create<TValue[], TValue[]>(_ => _));

		// Optional Collection

		public static NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]> Add<TValueValidator, TValue>(this OptionalCollectionStateValidator<TValue> optionalCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]>(optionalCollection, valueValidator, Mapping.Create<TValue[], TValue[]>(_ => _));

		// Required Nullable Collection

		public static NullableDataSourceStandard<RequiredNullableCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]> Add<TValueValidator, TValue>(this RequiredNullableCollectionStateValidator<TValue> requiredCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<RequiredNullableCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]>(requiredCollection, valueValidator, Mapping.Create<TValue[], TValue[]>(_ => _));

		// Required Collection

		public static DataSourceStandard<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]> Add<TValueValidator, TValue>(this RequiredCollectionStateValidator<TValue> requiredCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new DataSourceStandard<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]>(requiredCollection, valueValidator, Mapping.Create<TValue[], TValue[]>(_ => _));

		// Defaulted Nullable

		public static NullableDataSourceStandard<NullableDefaultedStateValidator<TValue>, TValueValidator, TValue, TValue> Add<TValueValidator, TValue>(this NullableDefaultedStateValidator<TValue> defaulted, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<NullableDefaultedStateValidator<TValue>, TValueValidator, TValue, TValue>(defaulted, valueValidator, Mapping.Create<TValue, TValue>(_ => _));

		// Defaulted

		public static DataSourceStandard<DefaultedStateValidator<TValue>, TValueValidator, TValue, TValue> Add<TValueValidator, TValue>(this DefaultedStateValidator<TValue> defaulted, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new DataSourceStandard<DefaultedStateValidator<TValue>, TValueValidator, TValue, TValue>(defaulted, valueValidator, Mapping.Create<TValue, TValue>(_ => _));

		// Optional Nullable

		public static NullableDataSourceStandard<NullableOptionalStateValidator<TValue>, TValueValidator, TValue, TValue> Add<TValueValidator, TValue>(this NullableOptionalStateValidator<TValue> optional, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<NullableOptionalStateValidator<TValue>, TValueValidator, TValue, TValue>(optional, valueValidator, Mapping.Create<TValue, TValue>(_ => _));

		// Optional

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, TValueValidator, TValue, TValue> Add<TValueValidator, TValue>(this OptionalStateValidator<TValue> optional, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<OptionalStateValidator<TValue>, TValueValidator, TValue, TValue>(optional, valueValidator, Mapping.Create<TValue, TValue>(_ => _));

		// Required Nullable

		public static NullableDataSourceStandard<NullableRequiredStateValidator<TValue>, TValueValidator, TValue, TValue> Add<TValueValidator, TValue>(this NullableRequiredStateValidator<TValue> required, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<NullableRequiredStateValidator<TValue>, TValueValidator, TValue, TValue>(required, valueValidator, Mapping.Create<TValue, TValue>(_ => _));

		// Required

		public static DataSourceStandard<RequiredStateValidator<TValue>, TValueValidator, TValue, TValue> Add<TValueValidator, TValue>(this RequiredStateValidator<TValue> required, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new DataSourceStandard<RequiredStateValidator<TValue>, TValueValidator, TValue, TValue>(required, valueValidator, Mapping.Create<TValue, TValue>(_ => _));
	}
}
