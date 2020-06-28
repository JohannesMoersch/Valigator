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
	public static class OptionalCollectionStateValidatorExtensions
	{
		public static DataSourceInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TValue, TValue>, Optional<TValue[]>, TValue[], TValueValidator> Not<TValue, TValueValidator>(this OptionalCollectionStateValidator<TValue> source, Func<OptionalCollectionStateValidator<TValue>, DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TValue, TValue>, Optional<TValue[]>, TValue[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[]> source, Func<DataSource<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[]>, DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TValue, TValue>, Optional<TValue[]>, TValue[], CustomValidator<TValue[]>> Assert<TValue>(this OptionalCollectionStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSource<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TValue, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>> Unique<TValue>(this OptionalCollectionStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSource<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TValue, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>> ItemCount<TValue>(this OptionalCollectionStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSource<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSourceInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>> source, Func<DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>>, DataSourceStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>> source, Func<DataSourceInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>>, DataSourceInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceStandardStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceInvertedStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceStandardInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceStandardInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceInvertedInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceInvertedInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSourceInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandardInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>> source, Func<DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>>, DataSourceStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>> source, Func<DataSourceInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>>, DataSourceInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceStandardStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceInvertedStandardStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceStandardInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceStandardInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceInvertedInverted<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceInvertedInvertedStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}