using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Text;
using Functional;
using Valigator.Core;
using Valigator.Tests.Common;
using Xunit;
using System.Reflection;
using FluentAssertions;

namespace Valigator.Tests
{
	public class TestModel
	{
		public Data<Option<int>> One { get; set; } = Data.Defaulted<int>(-1).Nullable().Not(o => o.InRange(greaterThanOrEqualTo: 0, lessThanOrEqualTo: 2));

		public Data<Option<int[]>> Two { get; set; } = Data.Collection<int>(f => f.Not(o => o.GreaterThan(10))).DefaultedToEmpty().Nullable().Not(o => o.ItemCount(maximumItems: 10)).Not(o => o.Unique()).Assert("", _ => true);

		public Data<Stuff> Three { get; set; } = Data.Defaulted<Stuff>(() => new Stuff());

		public Data<Wrapper> Four { get; set; } = Data.Required<Wrapper>().MappedFrom<int>(i => new Wrapper() { A = i }, o => o.GreaterThan(1));

		public Data<DateTime> Test { get; set; } = Data.Required<DateTime>().InRange(greaterThan: DateTime.Now).Assert("", _ => false);
	}

	public class Wrapper
	{
		public int A { get; set; }
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
			model.Test = model.Test.WithValue(DateTime.Now.AddDays(-1));
			model.Four = model.Four.WithMappedValue(-5);

			var result = Model.Verify(model);
		}

		[Theory]
		[InlineData(100, false)]
		[InlineData(-100, true)]
		public void VerifyAnonymousObject(int value, bool success)
		{
			var stuff = new Stuff();
			stuff.A = stuff.A.WithValue(value);

			var anonymousObject = ValigatorModel.Create(new { AnonymousInner = stuff.A, Other = 1 });

			var result = Model.Verify(anonymousObject);

			if (success)
				result.AssertSuccess();
			else
			{
				var failure = result.AssertFailure();
				failure.Should().HaveCount(1);
				failure.First().ValueDescriptor.Should().BeOfType<Valigator.Core.ValueDescriptors.RangeDescriptor>();
				(failure.First().ValueDescriptor as Valigator.Core.ValueDescriptors.RangeDescriptor).LessThanValue.AssertSome().Should().Be(0);
			}
		}

		public class TypeWithoutSetters
		{
			public Data<int> A { get; } = Data.Defaulted(5).LessThan(0);
		}

		[Fact]
		public void VerifyTypeWithoutSetterWrappedInValigatorModel()
		{
			var typeWithoutSetter = new TypeWithoutSetters();

			var anonymousObject = ValigatorModel.Create(typeWithoutSetter);

			var result = Model.Verify(anonymousObject);

				var failure = result.AssertFailure();
				failure.Should().HaveCount(1);
				failure.First().ValueDescriptor.Should().BeOfType<Valigator.Core.ValueDescriptors.RangeDescriptor>();
				(failure.First().ValueDescriptor as Valigator.Core.ValueDescriptors.RangeDescriptor).LessThanValue.AssertSome().Should().Be(0);
		}
	}
}
