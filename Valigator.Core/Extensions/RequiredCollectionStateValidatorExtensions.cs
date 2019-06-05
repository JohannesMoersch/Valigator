using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredCollectionStateValidatorExtensions
	{
		public static DataSourceInverted<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this RequiredCollectionStateValidator<TValue> source, Func<RequiredCollectionStateValidator<TValue>, DataSourceStandard<RequiredCollectionStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<RequiredCollectionStateValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this RequiredCollectionStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this RequiredCollectionStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this RequiredCollectionStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DataSourceStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DataSourceInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this DataSourceStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceInvertedStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this DataSourceInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static DataSourceStandardInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DataSourceStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<DataSourceStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>, DataSourceStandardStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DataSourceInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<DataSourceInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>, DataSourceInvertedStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DataSourceStandardStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DataSourceInvertedStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DataSourceStandardInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DataSourceInvertedInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DataSourceStandardStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<DataSourceStandardStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, DataSourceStandardStandardStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DataSourceInvertedStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<DataSourceInvertedStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, DataSourceInvertedStandardStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DataSourceStandardInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<DataSourceStandardInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, DataSourceStandardInvertedStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DataSourceInvertedInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<DataSourceInvertedInverted<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, DataSourceInvertedInvertedStandard<RequiredCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DataSourceStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DataSourceInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this DataSourceStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceInvertedStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this DataSourceInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static DataSourceStandardInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DataSourceStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<DataSourceStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, DataSourceStandardStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DataSourceInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<DataSourceInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, DataSourceInvertedStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DataSourceStandardStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DataSourceInvertedStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DataSourceStandardInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DataSourceInvertedInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DataSourceStandardStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<DataSourceStandardStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, DataSourceStandardStandardStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DataSourceInvertedStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<DataSourceInvertedStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, DataSourceInvertedStandardStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DataSourceStandardInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<DataSourceStandardInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, DataSourceStandardInvertedStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DataSourceInvertedInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<DataSourceInvertedInverted<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, DataSourceInvertedInvertedStandard<RequiredCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}