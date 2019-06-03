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
		public static NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DefaultedCollectionNullableStateValidator<TValue> defaultedCollection, Func<DefaultedCollectionNullableStateValidator<TValue>, NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(defaultedCollection).InvertOne();

		// Item Count + Nested

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this DefaultedCollectionNullableStateValidator<TValue> defaultedCollection, int? minimumItems = null, int? maximumItems = null)
			=> new NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>(defaultedCollection, new ItemCountValidator<TValue>(minimumItems, maximumItems));

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

		// Assert

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DefaultedCollectionNullableStateValidator<TValue> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> new NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, CustomValidator<TValue[]>, TValue[]>(defaultedCollection, new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> defaultedCollection, string description, Func<TValue[], bool> validator)
			=> defaultedCollection.Add(new CustomValidator<TValue[]>(description, validator));
	}
}
