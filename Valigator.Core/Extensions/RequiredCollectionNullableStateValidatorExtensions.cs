using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredCollectionNullableStateValidatorExtensions
	{
		public static NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TSource>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this RequiredCollectionNullableStateValidator<TSource> source, Func<RequiredCollectionNullableStateValidator<TSource>, NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TSource>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, CustomValidator<TValue[]>, TValue[], TValue[]> Assert<TValue>(this RequiredCollectionNullableStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[], TValue[]> Unique<TValue>(this RequiredCollectionNullableStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[], TValue[]> ItemCount<TValue>(this RequiredCollectionNullableStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue>(this NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue>(this NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandardStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandardStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> Unique<TSource, TValue>(this NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> Unique<TSource, TValue>(this NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandardStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandardStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedInvertedStandard<RequiredCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}