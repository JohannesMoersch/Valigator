using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core;
using Xunit;

namespace Valigator.Tests
{
	public class TestModel
	{
		public Data<Option<int>> One { get; set; } = Data.Defaulted<int>().Nullable().InRange(greaterThanOrEqualTo: 0, lessThanOrEqualTo: 2);

		public Data<int[]> Two { get; set; } = Data.Collection<int>(f => f.GreaterThan(10)).DefaultedToEmpty();

		public Data<Stuff> Three { get; set; } = Data.Defaulted<Stuff>(new Stuff());
	}

	public class Stuff
	{
		public Data<int> A { get; set; } = Data.Defaulted<int>();
	}

	public class ModelTests
	{
		[Fact]
		public void Test()
		{
			var descriptors = Model.GetPropertyDescriptors(new TestModel());

			var result = Model.Verify(new TestModel());
		}
	}
}
