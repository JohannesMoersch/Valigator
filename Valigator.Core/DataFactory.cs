using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core;
using Valigator.Core.StateValidators;

namespace Valigator
{
	public static class Data
	{
		private class IsNullableValueType<TValue>
		{
			public static bool Value { get; } = Nullable.GetUnderlyingType(typeof(TValue)) != null;
		}

		private class IsOptionType<TValue>
		{
			public static bool Value { get; } = typeof(TValue).IsConstructedGenericType && typeof(TValue).GetGenericTypeDefinition() == typeof(Option<>);
		}

		public static RequiredStateValidator<TValue> Required<TValue>()
		{
			ValidateType<TValue>();

			return new RequiredStateValidator<TValue>();
		}

		public static OptionalStateValidator<TValue> Optional<TValue>()
		{
			ValidateType<TValue>();

			return new OptionalStateValidator<TValue>();
		}

		public static DefaultedStateValidator<TValue> Defaulted<TValue>()
			where TValue : struct
		{
			ValidateType<TValue>();

			return new DefaultedStateValidator<TValue>(default(TValue));
		}

		public static DefaultedStateValidator<TValue> Defaulted<TValue>(TValue defaultValue)
		{
			ValidateType<TValue>();

			return new DefaultedStateValidator<TValue>(defaultValue);
		}

		public static DefaultedStateValidator<TValue> Defaulted<TValue>(Func<TValue> defaultValueFactory)
		{
			ValidateType<TValue>();

			return new DefaultedStateValidator<TValue>(defaultValueFactory);
		}

		public static CollectionFactory<TValue> Collection<TValue>() 
			=> new CollectionFactory<TValue>(Required<TValue>());

		public static CollectionFactory<TValue> Collection<TValue>(Func<RequiredStateValidator<TValue>, Data<TValue>> dataFactory) 
			=> new CollectionFactory<TValue>(dataFactory.Invoke(new RequiredStateValidator<TValue>()));

		public static NullableCollectionFactory<TValue> Collection<TValue>(Func<RequiredStateValidator<TValue>, Data<Option<TValue>>> dataFactory) 
			=> new NullableCollectionFactory<TValue>(dataFactory.Invoke(new RequiredStateValidator<TValue>()));

		private static void ValidateType<TValue>()
		{

			if (IsNullableValueType<TValue>.Value)
				throw new ValueTypesNotSupportException("Use .Nullable() instead of a nullable value type.");

			if (IsOptionType<TValue>.Value)
				throw new ValueTypesNotSupportException("Use .Nullable() instead of an Option type.");
		}
	}
}
