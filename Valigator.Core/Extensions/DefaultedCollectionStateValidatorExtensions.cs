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
	public static class DefaultedCollectionStateValidatorExtensions
	{
		public static DataSourceInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], TValueValidator> Not<TValue, TValueValidator>(this DefaultedCollectionStateValidator<TValue> source, Func<DefaultedCollectionStateValidator<TValue>, DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]> source, Func<DataSource<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]>, DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], CustomValidator<TValue[]>> Assert<TValue>(this DefaultedCollectionStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSource<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], UniqueValidator<TValue>> Unique<TValue>(this DefaultedCollectionStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSource<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> ItemCount<TValue>(this DefaultedCollectionStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSource<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSourceInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> source, Func<DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>>, DataSourceStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> source, Func<DataSourceInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>>, DataSourceInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceStandardStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceInvertedStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceStandardInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceStandardInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceInvertedInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceInvertedInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSourceInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandardInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> source, Func<DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>>, DataSourceStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> source, Func<DataSourceInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>>, DataSourceInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceStandardStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceInvertedStandardStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceStandardInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceStandardInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceInvertedInverted<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceInvertedInvertedStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}