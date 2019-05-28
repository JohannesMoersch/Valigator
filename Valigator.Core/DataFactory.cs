using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.StateValidators;

namespace Valigator
{
	public static class Data
	{
		public static RequiredStateValidator<TValue> Required<TValue>()
			=> new RequiredStateValidator<TValue>();

		public static OptionalStateValidator<TValue> Optional<TValue>()
			=> new OptionalStateValidator<TValue>();

		public static DefaultedStateValidator<TValue> Defaulted<TValue>()
			where TValue : struct
			=> new DefaultedStateValidator<TValue>();

		public static DefaultedStateValidator<TValue> Defaulted<TValue>(TValue defaultValue)
			=> new DefaultedStateValidator<TValue>(defaultValue);
	}
}
