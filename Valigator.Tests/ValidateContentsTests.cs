using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace Valigator.Tests
{
	public class ValidateContentsTests
	{
		[Fact]
		public void ValidatesPrivateField()
		{
			var model = new OuterTestClass(10);

			Model.Verify(model);

			model
				.GetPrivateField()
				.Value
				.Value
				.Should()
				.Be(10);
		}

		[Fact]
		public void ValidatesPublicField()
		{
			var model = new OuterTestClass(10);

			Model.Verify(model);

			model
				._publicField
				.Value
				.Value
				.Should()
				.Be(10);
		}

		[Fact]
		public void ValidatesPrivateProperty()
		{
			var model = new OuterTestClass(10);

			Model.Verify(model);

			model
				.GetPrivateProperty()
				.Value
				.Value
				.Should()
				.Be(10);
		}

		[Fact]
		public void ValidatesPublicProperty()
		{
			var model = new OuterTestClass(10);

			Model.Verify(model);

			model
				.PublicProperty
				.Value
				.Value
				.Should()
				.Be(10);
		}

		[Fact]
		public void ValidatesRecursively()
		{
			var model = new WrapperTestClass() { Value = new OuterTestClass(10) };

			Model.Verify(model);

			model
				.Value
				.PublicProperty
				.Value
				.Value
				.Should()
				.Be(10);
		}

		private class OuterTestClass
		{
			[ValidateContents]
			private readonly InnerTestClass _privateField;

			[ValidateContents]
			public readonly InnerTestClass _publicField;

			[ValidateContents]
			private InnerTestClass PrivateProperty { get; }

			[ValidateContents]
			public InnerTestClass PublicProperty { get; }

			public OuterTestClass(int value)
			{
				_privateField = new InnerTestClass(value);
				_publicField = new InnerTestClass(value);
				PrivateProperty = new InnerTestClass(value);
				PublicProperty = new InnerTestClass(value);
			}

			public InnerTestClass GetPrivateField()
				=> _privateField;

			public InnerTestClass GetPrivateProperty()
				=> PrivateProperty;
		}

		private class InnerTestClass
		{
			public Data<int> Value { get; private set; } = Data.Required<int>();

			public InnerTestClass(int value)
				=> Value = Value.WithValue(value);
		}

		private class WrapperTestClass
		{
			[ValidateContents]
			public OuterTestClass Value { get; set; }
		}
	}
}
