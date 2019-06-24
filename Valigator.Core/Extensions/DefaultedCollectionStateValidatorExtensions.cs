using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedCollectionStateValidatorExtensions
	{
		public static DataSourceInverted<DefaultedCollectionStateValidator<TSource>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DefaultedCollectionStateValidator<TSource> source, Func<DefaultedCollectionStateValidator<TSource>, DataSourceStandard<DefaultedCollectionStateValidator<TSource>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<DefaultedCollectionStateValidator<TValue>, CustomValidator<TValue[]>, TValue[], TValue[]> Assert<TValue>(this DefaultedCollectionStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<DefaultedCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[], TValue[]> Unique<TValue>(this DefaultedCollectionStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<DefaultedCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[], TValue[]> ItemCount<TValue>(this DefaultedCollectionStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue>(this DataSourceStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceInvertedStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue>(this DataSourceInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]>, DataSourceStandardStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]>, DataSourceInvertedStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceStandardStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceInvertedStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceStandardInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceInvertedInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceStandardStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceStandardStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceStandardStandardStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceInvertedStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceInvertedStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceInvertedStandardStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceStandardInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceStandardInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceStandardInvertedStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceInvertedInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceInvertedInverted<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceInvertedInvertedStandard<DefaultedCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> Unique<TSource, TValue>(this DataSourceStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceInvertedStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> Unique<TSource, TValue>(this DataSourceInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandardInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceStandardStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceInvertedStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceStandardStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceInvertedStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceStandardInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceInvertedInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceStandardStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceStandardStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, DataSourceStandardStandardStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceInvertedStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceInvertedStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, DataSourceInvertedStandardStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceStandardInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceStandardInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, DataSourceStandardInvertedStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceInvertedInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceInvertedInverted<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, DataSourceInvertedInvertedStandard<DefaultedCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}