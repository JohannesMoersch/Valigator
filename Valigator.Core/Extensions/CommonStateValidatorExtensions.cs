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

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, TValueValidator, TValue[], TValue[]> Add<TValueValidator, TValue>(this DefaultedCollectionNullableStateValidator<TValue> defaultedCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, TValueValidator, TValue[], TValue[]>(defaultedCollection, valueValidator, _ => _);

		// Defaulted Collection

		public static DataSourceStandard<DefaultedCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]> Add<TValueValidator, TValue>(this DefaultedCollectionStateValidator<TValue> defaultedCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new DataSourceStandard<DefaultedCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]>(defaultedCollection, valueValidator, _ => _);

		// Optional Nullable Collection

		public static NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, TValueValidator, TValue[], TValue[]> Add<TValueValidator, TValue>(this OptionalCollectionNullableStateValidator<TValue> optionalCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, TValueValidator, TValue[], TValue[]>(optionalCollection, valueValidator, _ => _);

		// Optional Collection

		public static NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]> Add<TValueValidator, TValue>(this OptionalCollectionStateValidator<TValue> optionalCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]>(optionalCollection, valueValidator, _ => _);

		// Required Nullable Collection

		public static NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, TValueValidator, TValue[], TValue[]> Add<TValueValidator, TValue>(this RequiredCollectionNullableStateValidator<TValue> requiredCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, TValueValidator, TValue[], TValue[]>(requiredCollection, valueValidator, _ => _);

		// Required Collection

		public static DataSourceStandard<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]> Add<TValueValidator, TValue>(this RequiredCollectionStateValidator<TValue> requiredCollection, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue[]>
			=> new DataSourceStandard<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[], TValue[]>(requiredCollection, valueValidator, _ => _);

		// Defaulted Nullable

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, TValueValidator, TValue, TValue> Add<TValueValidator, TValue>(this DefaultedNullableStateValidator<TValue> defaulted, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, TValueValidator, TValue, TValue>(defaulted, valueValidator, _ => _);

		public static MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, TValue> Map<TSource, TValue>(this DefaultedNullableStateValidator<TSource> source, Func<TSource, TValue> mapper)
			=> new MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, TValue>(source, mapper);

		// Defaulted

		public static DataSourceStandard<DefaultedStateValidator<TValue>, TValueValidator, TValue, TValue> Add<TValueValidator, TValue>(this DefaultedStateValidator<TValue> defaulted, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new DataSourceStandard<DefaultedStateValidator<TValue>, TValueValidator, TValue, TValue>(defaulted, valueValidator, _ => _);

		public static MappedDataSource<DefaultedStateValidator<TSource>, TSource, TValue> Map<TSource, TValue>(this DefaultedStateValidator<TSource> source, Func<TSource, TValue> mapper)
			=> new MappedDataSource<DefaultedStateValidator<TSource>, TSource, TValue>(source, mapper);

		// Optional Nullable

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, TValueValidator, TValue, TValue> Add<TValueValidator, TValue>(this OptionalNullableStateValidator<TValue> optional, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, TValueValidator, TValue, TValue>(optional, valueValidator, _ => _);

		public static MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, TValue> Map<TSource, TValue>(this OptionalNullableStateValidator<TSource> source, Func<TSource, TValue> mapper)
			=> new MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, TValue>(source, mapper);

		// Optional

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, TValueValidator, TValue, TValue> Add<TValueValidator, TValue>(this OptionalStateValidator<TValue> optional, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<OptionalStateValidator<TValue>, TValueValidator, TValue, TValue>(optional, valueValidator, _ => _);

		public static MappedNullableDataSource<OptionalStateValidator<TSource>, TSource, TValue> Map<TSource, TValue>(this OptionalStateValidator<TSource> source, Func<TSource, TValue> mapper)
			=> new MappedNullableDataSource<OptionalStateValidator<TSource>, TSource, TValue>(source, mapper);

		// Required Nullable

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, TValueValidator, TValue, TValue> Add<TValueValidator, TValue>(this RequiredNullableStateValidator<TValue> required, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, TValueValidator, TValue, TValue>(required, valueValidator, _ => _);

		public static MappedNullableDataSource<RequiredNullableStateValidator<TSource>, TSource, TValue> Map<TSource, TValue>(this RequiredNullableStateValidator<TSource> source, Func<TSource, TValue> mapper)
			=> new MappedNullableDataSource<RequiredNullableStateValidator<TSource>, TSource, TValue>(source, mapper);

		// Required

		public static DataSourceStandard<RequiredStateValidator<TValue>, TValueValidator, TValue, TValue> Add<TValueValidator, TValue>(this RequiredStateValidator<TValue> required, TValueValidator valueValidator)
			where TValueValidator : IValueValidator<TValue>
			=> new DataSourceStandard<RequiredStateValidator<TValue>, TValueValidator, TValue, TValue>(required, valueValidator, _ => _);

		public static MappedDataSource<RequiredStateValidator<TSource>, TSource, TValue> Map<TSource, TValue>(this RequiredStateValidator<TSource> source, Func<TSource, TValue> mapper)
			=> new MappedDataSource<RequiredStateValidator<TSource>, TSource, TValue>(source, mapper);
	}
}
