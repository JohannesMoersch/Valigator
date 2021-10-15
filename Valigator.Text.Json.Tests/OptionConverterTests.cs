using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Text.Json;
using Valigator.Core;
using Xunit;

namespace Valigator.Text.Json.Tests
{
	public class OptionConverterTests
	{
		[Fact]
		public void SerializingSomeOfIntegerIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(Option.Some(10))
				.AssertSome()
				.Should()
				.Be(10);

		[Fact]
		public void SerializingNoneOfIntegerIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(Option.None<int>())
				.AssertNone();

		[Fact]
		public void SerializingSomeOfStringIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(Option.Some("abc"))
				.AssertSome()
				.Should()
				.Be("abc");

		[Fact]
		public void SerializingNoneOfStringIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(Option.None<string>())
				.AssertNone();

		private record TestObject(int Value);

		[Fact]
		public void SerializingSomeOfObjectIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(Option.Some(new TestObject(10)))
				.AssertSome()
				.Should()
				.Be(new TestObject(10));

		[Fact]
		public void SerializingNoneOfObjectIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(Option.None<TestObject>())
				.AssertNone();

		private record TestComplexClass(Option<int> one, Option<string> two);

		[Fact]
		public void SerializingComplexClassOfSomeAndSomeIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(new TestComplexClass(Option.Some(10), Option.Some("abc")))
				.Should()
				.Be(new TestComplexClass(Option.Some(10), Option.Some("abc")));

		[Fact]
		public void SerializingComplexClassOfSomeAndNoneIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(new TestComplexClass(Option.Some(10), Option.None<string>()))
				.Should()
				.Be(new TestComplexClass(Option.Some(10), Option.None<string>()));

		[Fact]
		public void SerializingComplexClassOfNoneAndNoneIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(new TestComplexClass(Option.None<int>(), Option.None<string>()))
				.Should()
				.Be(new TestComplexClass(Option.None<int>(), Option.None<string>()));
	}
}
