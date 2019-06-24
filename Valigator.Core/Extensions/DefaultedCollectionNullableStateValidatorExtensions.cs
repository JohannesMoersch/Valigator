using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedCollectionNullableStateValidatorExtensions
	{
		public static NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TSource>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this DefaultedCollectionNullableStateValidator<TSource> source, Func<DefaultedCollectionNullableStateValidator<TSource>, NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TSource>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, CustomValidator<TValue[]>, TValue[], TValue[]> Assert<TValue>(this DefaultedCollectionNullableStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[], TValue[]> Unique<TValue>(this DefaultedCollectionNullableStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[], TValue[]> ItemCount<TValue>(this DefaultedCollectionNullableStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> Unique<TSource, TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> Unique<TSource, TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandardStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedInvertedStandard<DefaultedCollectionNullableStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}