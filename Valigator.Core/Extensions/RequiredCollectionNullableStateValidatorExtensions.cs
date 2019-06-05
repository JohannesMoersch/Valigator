using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredCollectionNullableStateValidatorExtensions
	{
		public static NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this RequiredCollectionNullableStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this RequiredCollectionNullableStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this RequiredCollectionNullableStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardStandardStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandardStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardStandardStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandardStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedInverted<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedInvertedStandard<RequiredCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}