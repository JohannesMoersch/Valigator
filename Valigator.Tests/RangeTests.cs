using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core;
using Xunit;

namespace Valigator.Tests
{
	public class RangeTests
	{
		public void Stuff()
		{
			Data<Option<int>> a = Data.Required<int>().Nullable().GreaterThan(10);
		}

		[Fact]
		public void Thing()
		{
			var resource = new TestClass();
			resource.Skip = resource.Skip.WithValue(3);
			resource.Take = resource.Take.WithValue(3);

			Model.Verify(resource).Match(_ => (object)_, e => throw new Exception());
		}

		public class TestClass
		{
			/// <summary>
			/// Gets or sets number of results to skip
			/// </summary>
			public Data<Option<int>> Skip { get; set; } = Data.Optional<int>().GreaterThanOrEqualTo(0);

			/// <summary>
			/// Gets or sets number of results to include
			/// </summary>
			public Data<Option<int>> Take { get; set; } = Data.Optional<int>().GreaterThanOrEqualTo(0);
		}
	}
}
