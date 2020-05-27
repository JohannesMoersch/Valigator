using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	public static class Optional
	{
		public static Optional<T> Set<T>(T value)
		{
			if (value == null)
				throw new ArgumentNullException(nameof(value));

			return new Optional<T>(true, value);
		}

		public static Optional<T> Unset<T>()
			=> new Optional<T>(false, default);

		public static Optional<T> Create<T>(bool isSet, T value)
			=> isSet
				? Set(value)
				: Unset<T>();
	}
}
