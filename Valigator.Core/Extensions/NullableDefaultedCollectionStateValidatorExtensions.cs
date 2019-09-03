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
	public static class NullableDefaultedCollectionStateValidatorExtensions
	{
		public static DataSourceInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], TValueValidator> Not<TValue, TValueValidator>(this NullableDefaultedCollectionStateValidator<TValue> source, Func<NullableDefaultedCollectionStateValidator<TValue>, DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> source, Func<DataSource<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]>, DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], CustomValidator<TValue[]>> Assert<TValue>(this NullableDefaultedCollectionStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], CustomValidator<TValue[]>> Assert<TValue>(this DataSource<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> Unique<TValue>(this NullableDefaultedCollectionStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> Unique<TValue>(this DataSource<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> ItemCount<TValue>(this NullableDefaultedCollectionStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> ItemCount<TValue>(this DataSource<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, Func<DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>>, DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, Func<DataSourceInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>>, DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceStandardStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceInvertedStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceStandardInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceInvertedInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source, Func<DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>>, DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source, Func<DataSourceInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>>, DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceStandardStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceInvertedStandardStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceStandardInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceInvertedInvertedStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}