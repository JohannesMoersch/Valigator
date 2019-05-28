using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Valigator.Core.Helpers;
using Xunit;

namespace Valigator.Tests
{
	public class PropertyHelperTests
	{
		public class TestModel
		{
			public int Value { get; set; }
		}

		[Fact]
		public void GetPropertyValueWhenPropertyExists()
			=> PropertyHelper
				.GetPropertyValue(new TestModel() { Value = 10 }, nameof(TestModel.Value))
				.Should()
				.Be(10);

		[Fact]
		public void GetPropertyValueWhenPropertyDoesntExist()
			=> Assert
				.Throws<ArgumentException>(() => PropertyHelper
					.GetPropertyValue(new TestModel() { Value = 10 }, "_")
					.Should()
					.Be(10)
				);

		[Fact]
		public void SetPropertyValueWhenPropertyExists()
		{
			var model = new TestModel();

			PropertyHelper.SetPropertyValue(model, nameof(TestModel.Value), 10);

			model.Value.Should().Be(10);
		}

		[Fact]
		public void SetPropertyValueWhenPropertyDoesntExist()
			=> Assert
				.Throws<ArgumentException>(() => PropertyHelper
					.SetPropertyValue(new TestModel(), "_", 10)
				);
	}
}
