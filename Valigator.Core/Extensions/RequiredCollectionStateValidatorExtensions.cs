// NOTE: GENERATED FILE //
using Functional;
using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredCollectionStateValidatorExtensions
	{
		public static DataSourceInverted<RequiredCollectionStateValidator<TSource>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this RequiredCollectionStateValidator<TSource> source, Func<RequiredCollectionStateValidator<TSource>, DataSourceStandard<RequiredCollectionStateValidator<TSource>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<RequiredCollectionStateValidator<TValue>, CustomValidator<TValue[]>, TValue[], TValue[]> Assert<TValue>(this RequiredCollectionStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue, TValue>, TValue[], TValue[]> Unique<TValue>(this RequiredCollectionStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue, TValue>(selector));

		public static DataSourceStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValue[], TValue[]> Unique<TValue, TUniqueKey>(this RequiredCollectionStateValidator<TValue> source, Func<TValue, TUniqueKey> selector)
			=> source.Add(new UniqueValidator<TValue, TUniqueKey>(selector));

		public static DataSourceStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[], TValue[]> ItemCount<TValue>(this RequiredCollectionStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue>(this DataSourceStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue>(this DataSourceInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, Func<DataSourceStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]>, DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, Func<DataSourceInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, TSource[], TValue[]>, DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceStandardStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceInvertedStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceStandardInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceInvertedInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this DataSourceStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this DataSourceInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue, TUniqueKey>(this DataSourceStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue, TUniqueKey>(this DataSourceInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this DataSourceStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, Func<DataSourceStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]>, DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this DataSourceInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, Func<DataSourceInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]>, DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceStandardStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceInvertedStandardStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceStandardInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceInvertedInvertedStandard<RequiredCollectionStateValidator<TSource>, UniqueValidator<TValue, TUniqueKey>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> Unique<TSource, TValue>(this DataSourceStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue, TValue>(selector));

		public static DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> Unique<TSource, TValue>(this DataSourceInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue, TValue>(selector));

		public static DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> Unique<TSource, TValue, TUniqueKey>(this DataSourceStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<TValue, TUniqueKey> selector)
			=> source.Add(new UniqueValidator<TValue, TUniqueKey>(selector));

		public static DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> Unique<TSource, TValue, TUniqueKey>(this DataSourceInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<TValue, TUniqueKey> selector)
			=> source.Add(new UniqueValidator<TValue, TUniqueKey>(selector));

		public static DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<DataSourceInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]>, DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, Func<DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]>, DataSourceStandardStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, Func<DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]>, DataSourceInvertedStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, Func<DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]>, DataSourceStandardInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]> source, Func<DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TSource[], TValue[]>, DataSourceInvertedInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue, TUniqueKey>(this DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, Func<DataSourceStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]>, DataSourceStandardStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, Func<DataSourceInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]>, DataSourceInvertedStandardStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, Func<DataSourceStandardInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]>, DataSourceStandardInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue, TUniqueKey>(this DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]> source, Func<DataSourceInvertedInverted<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TSource[], TValue[]>, DataSourceInvertedInvertedStandard<RequiredCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue, TUniqueKey>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}