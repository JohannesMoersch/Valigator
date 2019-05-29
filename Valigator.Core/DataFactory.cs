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
		public static RequiredStateValidator<TValue> Required<TValue>()
			=> new RequiredStateValidator<TValue>();

		public static OptionalStateValidator<TValue> Optional<TValue>()
			=> new OptionalStateValidator<TValue>();

		public static DefaultedStateValidator<TValue> Defaulted<TValue>()
			where TValue : struct
			=> new DefaultedStateValidator<TValue>();

		public static DefaultedStateValidator<TValue> Defaulted<TValue>(TValue defaultValue)
			=> new DefaultedStateValidator<TValue>(defaultValue);

		public static CollectionStateValidator<TValue> Collection<TValue>()
			=> new CollectionStateValidator<TValue>(Required<TValue>());

		public static CollectionStateValidator<TValue> Collection<TValue>(Func<RequiredStateValidator<TValue>, Data<TValue>> dataFactory)
			=> new CollectionStateValidator<TValue>(dataFactory.Invoke(new RequiredStateValidator<TValue>()));

		public static CollectionStateValidator<Option<TValue>> Collection<TValue>(Func<RequiredStateValidator<TValue>, Data<Option<TValue>>> dataFactory)
			=> new CollectionStateValidator<Option<TValue>>(dataFactory.Invoke(new RequiredStateValidator<TValue>()));
	}
}
