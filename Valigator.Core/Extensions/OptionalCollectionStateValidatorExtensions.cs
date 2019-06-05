using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalCollectionStateValidatorExtensions
	{
		public static NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this OptionalCollectionStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this OptionalCollectionStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this OptionalCollectionStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this NullableDataSourceInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardStandardStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandardStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardInvertedStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedInvertedStandard<OptionalCollectionStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this NullableDataSourceInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardStandardStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandardStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardInvertedStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedInverted<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedInvertedStandard<OptionalCollectionStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}