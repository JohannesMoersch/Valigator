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

		public static RequiredStateValidator<TValue> Required<TValue>()
			=> new RequiredStateValidator<TValue>();

		public static OptionalStateValidator<TValue> Optional<TValue>()
			=> new OptionalStateValidator<TValue>();

		public static DefaultedStateValidator<TValue> Defaulted<TValue>()
			where TValue : struct
			=> new DefaultedStateValidator<TValue>(default(TValue));

		public static DefaultedStateValidator<TValue> Defaulted<TValue>(TValue defaultValue)
			=> new DefaultedStateValidator<TValue>(defaultValue);

		public static DefaultedStateValidator<TValue> Defaulted<TValue>(Func<TValue> defaultValueFactory)
			=> new DefaultedStateValidator<TValue>(defaultValueFactory);

		public static CollectionFactory<TValue> Collection<TValue>()
		{
			if (IsNullableValueType<TValue>.Value)
				throw new NullableValueTypesNotSupportException("Use .ItemsNullable() instead of a nullable value type.");

			return new CollectionFactory<TValue>(Required<TValue>());
		}

		public static CollectionFactory<TValue> Collection<TValue>(Func<RequiredStateValidator<TValue>, Data<TValue>> dataFactory)
		{
			if (IsNullableValueType<TValue>.Value)
				throw new NullableValueTypesNotSupportException("Use .ItemsNullable() instead of a nullable value type.");

			return new CollectionFactory<TValue>(dataFactory.Invoke(new RequiredStateValidator<TValue>()));
		}
	}
}
