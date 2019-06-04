using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedCollectionNullableStateValidatorExtensions
	{
		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DefaultedCollectionNullableStateValidator<TValue> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> new NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, CustomValidator<TValue[]>, TValue[]>(defaultedCollection, new CustomValidator<TValue[]>(description, validator));

		// Item Count + Nested

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this DefaultedCollectionNullableStateValidator<TValue> defaultedCollection, int? minimumItems = null, int? maximumItems = null)
			=> defaultedCollection.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedCollection)
			=> defaultedCollection.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedCollection)
			=> defaultedCollection.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedValidator, Func<NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedValidator, Func<NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		// Unique + Nested

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this DefaultedCollectionNullableStateValidator<TValue> defaultedCollection)
			=> new NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>(defaultedCollection, new UniqueValidator<TValue>());

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedCollection, int? minimumItems = null, int? maximumItems = null)
			=> defaultedCollection.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedCollection, int? minimumItems = null, int? maximumItems = null)
			=> defaultedCollection.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedValidator, Func<NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedValidator, Func<NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		// Nested Unique + ItemCountValidator

		public static NullableDataSourceStandardStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedValidator, Func<NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedValidator, Func<NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedValidator, Func<NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedValidator, Func<NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).InvertThree();

		// Nested ItemCountValidator + Unique

		public static NullableDataSourceStandardStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedValidator, Func<NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedValidator, Func<NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedValidator, Func<NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedValidator, Func<NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedValidator).InvertThree();
	}
}
