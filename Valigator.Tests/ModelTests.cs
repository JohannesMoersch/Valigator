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
		public Data<Option<int>> One { get; set; } = Data.Defaulted<int>(-1).Nullable().Not(o => o.InRange(greaterThanOrEqualTo: 0, lessThanOrEqualTo: 2));

		public Data<Option<int[]>> Two { get; set; } = Data.Collection<int>(f => f.Not(o => o.GreaterThan(10))).DefaultedToEmpty().Nullable().Not(o => o.ItemCount(maximumItems: 10)).Not(o => o.Unique()).Assert("", _ => true);

		public Data<Stuff> Three { get; set; } = Data.Defaulted<Stuff>(() => new Stuff());

		public Data<DateTime> Test { get; set; } = Data.Required<DateTime>().InRange(DateTime.Now);
	}

	public class Stuff
	{
		public Data<int> A { get; set; } = Data.Defaulted<int>(5).LessThan(0);
	}

	public class ModelTests
	{
		[Fact]
		public void Test()
		{
			var descriptors = Model.GetPropertyDescriptors(new TestModel());

			var model = new TestModel();

			var result = Model.Verify(model);
		}
	}
}
