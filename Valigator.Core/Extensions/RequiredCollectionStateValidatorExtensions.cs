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
	public static class RequiredCollectionStateValidatorExtensions
	{
		public static DataSourceInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], TValueValidator> Not<TValue, TValueValidator>(this RequiredCollectionStateValidator<TValue> source, Func<RequiredCollectionStateValidator<TValue>, DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]> source, Func<DataSource<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]>, DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], CustomValidator<TValue[]>> Assert<TValue>(this RequiredCollectionStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSource<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], UniqueValidator<TValue>> Unique<TValue>(this RequiredCollectionStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSource<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> ItemCount<TValue>(this RequiredCollectionStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSource<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSourceInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> source, Func<DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>>, DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>> source, Func<DataSourceInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>>, DataSourceInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceStandardStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceInvertedStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceStandardInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceStandardInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceInvertedInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceInvertedInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSourceInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandardInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> source, Func<DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>>, DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> source, Func<DataSourceInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>>, DataSourceInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceStandardStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceInvertedStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceStandardInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceStandardInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceInvertedInverted<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceInvertedInvertedStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}