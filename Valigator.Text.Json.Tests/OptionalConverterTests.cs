using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Text.Json;
using Valigator.Core;
using Xunit;

namespace Valigator.Text.Json.Tests
{
	public class OptionalConverterTests
	{
		[Fact]
		public void SerializingSomeOfIntegerIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(Optional.Set(10))
				.AssertSet()
				.Should()
				.Be(10);

		[Fact]
		public void SerializingNoneOfIntegerIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(Optional.Unset<int>())
				.AssertUnset();

		[Fact]
		public void SerializingSomeOfStringIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(Optional.Set("abc"))
				.AssertSet()
				.Should()
				.Be("abc");

		[Fact]
		public void SerializingNoneOfStringIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(Optional.Unset<string>())
				.AssertUnset();

		private record TestObject(int Value);

		[Fact]
		public void SerializingSomeOfObjectIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(Optional.Set(new TestObject(10)))
				.AssertSet()
				.Should()
				.Be(new TestObject(10));

		[Fact]
		public void SerializingNoneOfObjectIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(Optional.Unset<TestObject>())
				.AssertUnset();

		private record TestComplexClass(Optional<int> one, Optional<string> two);

		[Fact]
		public void SerializingComplexClassOfSomeAndSomeIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(new TestComplexClass(Optional.Set(10), Optional.Set("abc")))
				.Should()
				.Be(new TestComplexClass(Optional.Set(10), Optional.Set("abc")));

		[Fact]
		public void SerializingComplexClassOfSomeAndNoneIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(new TestComplexClass(Optional.Set(10), Optional.Unset<string>()))
				.Should()
				.Be(new TestComplexClass(Optional.Set(10), Optional.Unset<string>()));

		[Fact]
		public void SerializingComplexClassOfNoneAndNoneIsSuccess()
			=> JsonHelper
				.CloneViaSerialization(new TestComplexClass(Optional.Unset<int>(), Optional.Unset<string>()))
				.Should()
				.Be(new TestComplexClass(Optional.Unset<int>(), Optional.Unset<string>()));
	}
}
