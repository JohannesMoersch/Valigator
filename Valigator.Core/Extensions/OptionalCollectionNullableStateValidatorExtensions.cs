using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalCollectionNullableStateValidatorExtensions
	{
		public static NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this OptionalCollectionNullableStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this OptionalCollectionNullableStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this OptionalCollectionNullableStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardStandardStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandardStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardStandardStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandardStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedInverted<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedInvertedStandard<OptionalCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}