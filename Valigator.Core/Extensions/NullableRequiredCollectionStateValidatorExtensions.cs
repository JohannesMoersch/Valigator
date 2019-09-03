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
	public static class NullableRequiredCollectionStateValidatorExtensions
	{
		public static DataSourceInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], TValueValidator> Not<TValue, TValueValidator>(this NullableRequiredCollectionStateValidator<TValue> source, Func<NullableRequiredCollectionStateValidator<TValue>, DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> source, Func<DataSource<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]>, DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], CustomValidator<TValue[]>> Assert<TValue>(this NullableRequiredCollectionStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], CustomValidator<TValue[]>> Assert<TValue>(this DataSource<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> Unique<TValue>(this NullableRequiredCollectionStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> Unique<TValue>(this DataSource<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> ItemCount<TValue>(this NullableRequiredCollectionStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> ItemCount<TValue>(this DataSource<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> ItemCount<TSource, TValue>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, Func<DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>>, DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>> source, Func<DataSourceInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>>, DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceStandardStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceInvertedStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceStandardInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>> source, Func<DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>>, DataSourceInvertedInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> Unique<TSource, TValue>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source, Func<DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>>, DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>> source, Func<DataSourceInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>>, DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>> Assert<TSource, TValue>(this DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceStandardStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceInvertedStandardStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceStandardInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceStandardInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>> source, Func<DataSourceInvertedInverted<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>>, DataSourceInvertedInvertedStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[], ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}