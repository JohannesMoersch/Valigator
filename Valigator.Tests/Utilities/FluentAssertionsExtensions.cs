using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions.Collections;
using Functional;

namespace Valigator.Tests
{
	public static class FluentAssertionsExtensions
	{
		public static void BeEquivalentToNullables<T>(this GenericCollectionAssertions<Option<T>> collection, IEnumerable<T?> expectation)
			where T : struct
			=> collection
				.BeEquivalentTo(expectation.Select(Option.FromNullable));
	}
}
