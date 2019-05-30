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
			=> new DefaultedStateValidator<TValue>(default);

		public static DefaultedStateValidator<TValue> Defaulted<TValue>(TValue defaultValue)
			=> new DefaultedStateValidator<TValue>(defaultValue);

		public static CollectionFactory<TValue> Collection<TValue>()
			=> new CollectionFactory<TValue>(Required<TValue>());

		public static CollectionFactory<TValue> Collection<TValue>(Func<RequiredStateValidator<TValue>, Data<TValue>> dataFactory)
			=> new CollectionFactory<TValue>(dataFactory.Invoke(new RequiredStateValidator<TValue>()));

		public static CollectionFactory<Option<TValue>> Collection<TValue>(Func<RequiredStateValidator<TValue>, Data<Option<TValue>>> dataFactory)
			=> new CollectionFactory<Option<TValue>>(dataFactory.Invoke(new RequiredStateValidator<TValue>()));
	}
}
