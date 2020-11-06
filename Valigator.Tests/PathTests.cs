using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Functional;
using Valigator.Core;
using Valigator.Tests.Common;
using Xunit;

namespace Valigator.Tests
{
	public class PathTests
	{
		[ValigatorModel]
		private class SimplePathTestModel
		{
			public Data<int> IntValue { get; set; } = Data.Required<int>();
		}

		[Fact]
		public void SimplePath_IsAsExpectedInError()
		{
			var model = new SimplePathTestModel();
			var result = Model.Verify(model);
			result = Model.Verify(model);

			var failure = result.AssertFailure();
			failure[0].Path.ToString().Should().Be(nameof(SimplePathTestModel.IntValue));
		}

		[ValigatorModel]
		private class ArrayPathTestModel
		{
			public Data<SimplePathTestModel[]> IntValues { get; set; } = Data.Collection<SimplePathTestModel>().Required();
		}

		[Fact]
		public void ArrayPath_IsAsExpectedInError()
		{
			var simplePath = new SimplePathTestModel();
			var model = new ArrayPathTestModel();
			model.IntValues = model.IntValues.WithValue(new[] { simplePath });

			var result = Model.Verify(model);
			result = Model.Verify(model);

			var failure = result.AssertFailure();
			failure[0].Path.ToString().Should().Be($"{nameof(ArrayPathTestModel.IntValues)}[0].{nameof(SimplePathTestModel.IntValue)}");
		}

		[ValigatorModel]
		private class NestedPathTestModel
		{
			public Data<ArrayPathTestModel> OuterIntValue { get; set; } = Data.Required<ArrayPathTestModel>();
		}

		[Fact]
		public void NestedPath_IsAsExpectedInError()
		{
			var simplePath = new SimplePathTestModel();
			var arrayPath = new ArrayPathTestModel();
			arrayPath.IntValues = arrayPath.IntValues.WithValue(new[] { simplePath });

			var model = new NestedPathTestModel();
			model.OuterIntValue = model.OuterIntValue.WithValue(arrayPath);

			var result = Model.Verify(model);
			result = Model.Verify(model);

			var failure = result.AssertFailure();
			failure[0].Path.ToString().Should().Be($"{nameof(NestedPathTestModel.OuterIntValue)}.{nameof(ArrayPathTestModel.IntValues)}[0].{nameof(SimplePathTestModel.IntValue)}");
		}
	}
}