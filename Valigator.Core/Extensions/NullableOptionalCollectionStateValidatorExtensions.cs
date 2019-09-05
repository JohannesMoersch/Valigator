// NOTE: GENERATED FILE //
using Functional;
using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.DataContainers.Factories;
using Valigator.Core.DataSources;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class NullableOptionalCollectionStateValidatorExtensions
	{
		public static DataSourceInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], TValueValidator> Not<TValue, TValueValidator>(this NullableOptionalCollectionStateValidator<TValue> source, Func<NullableOptionalCollectionStateValidator<TValue>, DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> source, Func<DataSource<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]>, DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], CustomValidator<TValue[]>> Assert<TValue>(this NullableOptionalCollectionStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSource<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> Unique<TValue>(this NullableOptionalCollectionStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSource<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> ItemCount<TValue>(this NullableOptionalCollectionStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSource<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, Func<DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>>, DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, Func<DataSourceInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>>, DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceStandardStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceInvertedStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceStandardInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceInvertedInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source, Func<DataSourceStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>>, DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source, Func<DataSourceInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>>, DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceStandardStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceInvertedStandardStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceStandardInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceInvertedInvertedStandard<NullableCollectionDataContainerFactory<NullableOptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}