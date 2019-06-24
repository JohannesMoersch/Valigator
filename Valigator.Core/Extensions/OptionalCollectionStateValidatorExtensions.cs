using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalCollectionStateValidatorExtensions
	{
		public static NullableDataSourceInverted<OptionalCollectionStateValidator<TSource>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this OptionalCollectionStateValidator<TSource> source, Func<OptionalCollectionStateValidator<TSource>, NullableDataSourceStandard<OptionalCollectionStateValidator<TSource>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, CustomValidator<TValue[]>, TValue[], TValue[]> Assert<TValue>(this OptionalCollectionStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[], TValue[]> Unique<TValue>(this OptionalCollectionStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[], TValue[]> ItemCount<TValue>(this OptionalCollectionStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue>(this NullableDataSourceStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> ItemCount<TSource, TValue>(this NullableDataSourceInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandardStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandardStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardInvertedStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedInvertedStandard<OptionalCollectionStateValidator<TSource>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> Unique<TSource, TValue>(this NullableDataSourceStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> Unique<TSource, TValue>(this NullableDataSourceInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TSource[], TValue[]> Assert<TSource, TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardStandardStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedStandardStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceStandardInvertedStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]> source, Func<NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TSource[], TValue[]>, NullableDataSourceInvertedInvertedStandard<OptionalCollectionStateValidator<TSource>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TSource[], TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}