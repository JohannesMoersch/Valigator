using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.DataSources;

namespace Valigator
{
	public static class Data
	{
		public static RequiredSource<TValue> Required<TValue>()
			=> new RequiredSource<TValue>();

		public static OptionalSource<TValue> Optional<TValue>()
			=> new OptionalSource<TValue>();

		public static DefaultedSource<TValue> Defaulted<TValue>()
			where TValue : struct
			=> new DefaultedSource<TValue>();

		public static DefaultedSource<TValue> Defaulted<TValue>(TValue defaultValue)
			=> new DefaultedSource<TValue>(defaultValue);
	}
}
