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
		public Data<Option<int>> One { get; set; } = Data.Required<int>().Nullable().GreaterThan(0);

		public Data<int[]> Two { get; set; } = Data.Collection<int>(f => f.GreaterThan(10)).DefaultedToEmpty();
	}

	public class ModelTests
	{
		[Fact]
		public void Test()
		{
			var descriptors = Model.GetPropertyDescriptors(new TestModel());
		}
	}
}
