using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace Valigator.Tests
{
	public class CollectionStateValidatorTests
	{
		[Fact]
		public void RequiredWithValue()
			=> Data
				.Collection<int?>()
				.Required()
				.Data
				.WithValue(new int?[] { 5 })
				.Verify(new object())
				.AssureSuccess()
				.Value
				.Should()
				.BeEquivalentTo(new int?[] { 5 });

		[Fact]
		public void RequiredWithNull()
			=> Data
				.Collection<int?>()
				.Required()
				.Data
				.WithValue(null)
				.Verify(new object())
				.AssureFailure();

		[Fact]
		public void RequiredAndUnset()
			=> Data
				.Collection<int?>()
				.Required()
				.Data
				.Verify(new object())
				.AssureFailure();

		[Fact]
		public void RequiredNullableWithValue()
			=> Data
				.Collection<int?>()
				.Required()
				.Nullable()
				.Data
				.WithValue(new int?[] { 5 })
				.Verify(new object())
				.AssureSuccess()
				.Value
				.AssureSome()
				.Should()
				.BeEquivalentTo(new int?[] { 5 });

		[Fact]
		public void RequiredNullableWithNull()
			=> Data
				.Collection<int?>()
				.Required()
				.Nullable()
				.Data
				.WithValue(null)
				.Verify(new object())
				.AssureSuccess()
				.Value
				.AssureNone();

		[Fact]
		public void RequiredNullableAndUnset()
			=> Data
				.Collection<int?>()
				.Required()
				.Nullable()
				.Data
				.Verify(new object())
				.AssureFailure();

		[Fact]
		public void OptionalWithValue()
			=> Data
				.Collection<int>()
				.Optional()
				.Data
				.WithValue(new int[] { 5 })
				.Verify(new object())
				.AssureSuccess()
				.Value
				.AssureSome()
				.Should()
				.BeEquivalentTo(new int[] { 5 });

		[Fact]
		public void OptionalWithNull()
			=> Data
				.Collection<int>()
				.Optional()
				.Data
				.WithValue(null)
				.Verify(new object())
				.AssureFailure();

		[Fact]
		public void OptionalAndUnset()
			=> Data
				.Collection<int>()
				.Optional()
				.Data
				.Verify(new object())
				.AssureSuccess()
				.Value
				.AssureNone();


		[Fact]
		public void OptionalNullableWithValue()
			=> Data
				.Collection<int>()
				.Optional()
				.Nullable()
				.Data
				.WithValue(new int[] { 5 })
				.Verify(new object())
				.AssureSuccess()
				.Value
				.AssureSome()
				.Should()
				.BeEquivalentTo(new int[] { 5 });

		[Fact]
		public void OptionalNullableWithNull()
			=> Data
				.Collection<int>()
				.Optional()
				.Nullable()
				.Data
				.WithValue(null)
				.Verify(new object())
				.AssureSuccess()
				.Value
				.AssureNone();

		[Fact]
		public void OptionalNullableAndUnset()
			=> Data
				.Collection<int>()
				.Optional()
				.Nullable()
				.Data
				.Verify(new object())
				.AssureSuccess()
				.Value
				.AssureNone();

		[Fact]
		public void DefaultedWithValue()
			=> Data
				.Collection<int?>()
				.Defaulted(new int?[] { 10 })
				.Data
				.WithValue(new int?[] { 5 })
				.Verify(new object())
				.AssureSuccess()
				.Value
				.Should()
				.BeEquivalentTo(new int?[] { 5 });

		[Fact]
		public void DefaultedWithNull()
			=> Data
				.Collection<int?>()
				.Defaulted(new int?[] { 10 })
				.Data
				.WithValue(null)
				.Verify(new object())
				.AssureFailure();

		[Fact]
		public void DefaultedAndUnset()
			=> Data
				.Collection<int?>()
				.Defaulted(new int?[] { 10 })
				.Data
				.Verify(new object())
				.AssureSuccess()
				.Value
				.Should()
				.BeEquivalentTo(new int?[] { 10 });

		[Fact]
		public void DefaultedNullableWithValue()
			=> Data
				.Collection<int?>()
				.Defaulted(new int?[] { 10 })
				.Nullable()
				.Data
				.WithValue(new int?[] { 5 })
				.Verify(new object())
				.AssureSuccess()
				.Value
				.AssureSome()
				.Should()
				.BeEquivalentTo(new int?[] { 5 });

		[Fact]
		public void DefaultedNullableWithNull()
			=> Data
				.Collection<int?>()
				.Defaulted(new int?[] { 10 })
				.Nullable()
				.Data
				.WithValue(null)
				.Verify(new object())
				.AssureSuccess()
				.Value
				.AssureNone();

		[Fact]
		public void DefaultedNullableAndUnset()
			=> Data
				.Collection<int?>()
				.Defaulted(new int?[] { 10 })
				.Nullable()
				.Data
				.Verify(new object())
				.AssureSuccess()
				.Value
				.AssureSome()
				.Should()
				.BeEquivalentTo(new int?[] { 10 });
	}
}
