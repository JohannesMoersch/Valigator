using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.ValidationData;

namespace Valigator.PropertyFactories
{
	public class ValuePropertyFactory<TValue>
	{
		public static ValuePropertyFactory<TValue> Instance { get; } = new ValuePropertyFactory<TValue>();

		private ValuePropertyFactory() { }

		public RequiredValueValidationData<TValue> Required()
			=> new RequiredValueValidationData<TValue>(new ValidationData<TValue>());

		public OptionalValueValidationData<TValue> Optional()
			=> new OptionalValueValidationData<TValue>(new ValidationData<TValue>());

		public DefaultedValueValidationData<TValue> Defaulted(TValue defaultValue)
			=> new DefaultedValueValidationData<TValue>(defaultValue, new ValidationData<TValue>());
	}

	public class NullableValuePropertyFactory<TValue>
	{
		public static NullableValuePropertyFactory<TValue> Instance { get; } = new NullableValuePropertyFactory<TValue>();

		private NullableValuePropertyFactory() { }

		public RequiredNullableValueValidationData<TValue> Required()
			=> new RequiredNullableValueValidationData<TValue>(new ValidationData<TValue>());

		public OptionalNullableValueValidationData<TValue> Optional()
			=> new OptionalNullableValueValidationData<TValue>(new ValidationData<TValue>());

		public DefaultedNullableValueValidationData<TValue> Defaulted(Option<TValue> defaultValue)
			=> new DefaultedNullableValueValidationData<TValue>(defaultValue, new ValidationData<TValue>());
	}
}
