using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	public static class Optional
	{
		public static Optional<T> Some<T>(T value)
		{
			if (value == null)
				throw new ArgumentNullException(nameof(value));

			return new Optional<T>(true, value);
		}

		public static Optional<T> None<T>()
			=> new Optional<T>(false, default);

		public static Optional<T> Create<T>(bool isSome, T value)
			=> isSome
				? Some(value)
				: None<T>();
	}
}
