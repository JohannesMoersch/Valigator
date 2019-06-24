using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Functional;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueDescriptors;
using Valigator.Core.ValueValidators;
using Xunit;

namespace Valigator.Tests
{
	public class NullableDataSourceTests
	{
		[Theory]
		[InlineData(false, false)]
		[InlineData(true, true)]
		public void Standard(bool one, bool success)
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void StandardNull()
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => false), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Theory]
		[InlineData(false, true)]
		[InlineData(true, false)]
		public void Inverted(bool one, bool success)
			=> new NullableDataSourceInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void InvertedNull()
			=> new NullableDataSourceInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => true), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Theory]
		[InlineData(false, false, false)]
		[InlineData(false, true, false)]
		[InlineData(true, false, false)]
		[InlineData(true, true, true)]
		public void StandardStandard(bool one, bool two, bool success)
			=> new NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void StandardStandardNull()
			=> new NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => false), new CustomValidator<int>("", _ => false), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Theory]
		[InlineData(false, false, false)]
		[InlineData(false, true, false)]
		[InlineData(true, false, true)]
		[InlineData(true, true, false)]
		public void StandardInverted(bool one, bool two, bool success)
			=> new NullableDataSourceStandardInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void StandardInvertedNull()
			=> new NullableDataSourceStandardInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => false), new CustomValidator<int>("", _ => true), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Theory]
		[InlineData(false, false, false)]
		[InlineData(false, true, true)]
		[InlineData(true, false, false)]
		[InlineData(true, true, false)]
		public void InvertedStandard(bool one, bool two, bool success)
			=> new NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void InvertedStandardNull()
			=> new NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => false), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Theory]
		[InlineData(false, false, true)]
		[InlineData(false, true, false)]
		[InlineData(true, false, false)]
		[InlineData(true, true, false)]
		public void InvertedInverted(bool one, bool two, bool success)
			=> new NullableDataSourceInvertedInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void InvertedInvertedNull()
			=> new NullableDataSourceInvertedInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Theory]
		[InlineData(false, false, false, false)]
		[InlineData(false, false, true, false)]
		[InlineData(false, true, false, false)]
		[InlineData(false, true, true, false)]
		[InlineData(true, false, false, false)]
		[InlineData(true, false, true, false)]
		[InlineData(true, true, false, false)]
		[InlineData(true, true, true, true)]
		public void StandardStandardStandard(bool one, bool two, bool three, bool success)
			=> new NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void StandardStandardStandardNull()
			=> new NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => false), new CustomValidator<int>("", _ => false), new CustomValidator<int>("", _ => false), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Theory]
		[InlineData(false, false, false, false)]
		[InlineData(false, false, true, false)]
		[InlineData(false, true, false, false)]
		[InlineData(false, true, true, false)]
		[InlineData(true, false, false, false)]
		[InlineData(true, false, true, false)]
		[InlineData(true, true, false, true)]
		[InlineData(true, true, true, false)]
		public void StandardStandardInverted(bool one, bool two, bool three, bool success)
			=> new NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void StandardStandardInvertedNull()
			=> new NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => false), new CustomValidator<int>("", _ => false), new CustomValidator<int>("", _ => true), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Theory]
		[InlineData(false, false, false, false)]
		[InlineData(false, false, true, false)]
		[InlineData(false, true, false, false)]
		[InlineData(false, true, true, false)]
		[InlineData(true, false, false, false)]
		[InlineData(true, false, true, true)]
		[InlineData(true, true, false, false)]
		[InlineData(true, true, true, false)]
		public void StandardInvertedStandard(bool one, bool two, bool three, bool success)
			=> new NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void StandardInvertedStandardNull()
			=> new NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => false), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => false), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Theory]
		[InlineData(false, false, false, false)]
		[InlineData(false, false, true, false)]
		[InlineData(false, true, false, false)]
		[InlineData(false, true, true, false)]
		[InlineData(true, false, false, true)]
		[InlineData(true, false, true, false)]
		[InlineData(true, true, false, false)]
		[InlineData(true, true, true, false)]
		public void StandardInvertedInverted(bool one, bool two, bool three, bool success)
			=> new NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void StandardInvertedInvertedNull()
			=> new NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => false), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Theory]
		[InlineData(false, false, false, false)]
		[InlineData(false, false, true, false)]
		[InlineData(false, true, false, false)]
		[InlineData(false, true, true, true)]
		[InlineData(true, false, false, false)]
		[InlineData(true, false, true, false)]
		[InlineData(true, true, false, false)]
		[InlineData(true, true, true, false)]
		public void InvertedStandardStandard(bool one, bool two, bool three, bool success)
			=> new NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void InvertedStandardStandardNull()
			=> new NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => false), new CustomValidator<int>("", _ => false), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Theory]
		[InlineData(false, false, false, false)]
		[InlineData(false, false, true, false)]
		[InlineData(false, true, false, true)]
		[InlineData(false, true, true, false)]
		[InlineData(true, false, false, false)]
		[InlineData(true, false, true, false)]
		[InlineData(true, true, false, false)]
		[InlineData(true, true, true, false)]
		public void InvertedStandardInverted(bool one, bool two, bool three, bool success)
			=> new NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void InvertedStandardInvertedNull()
			=> new NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => false), new CustomValidator<int>("", _ => true), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Theory]
		[InlineData(false, false, false, false)]
		[InlineData(false, false, true, true)]
		[InlineData(false, true, false, false)]
		[InlineData(false, true, true, false)]
		[InlineData(true, false, false, false)]
		[InlineData(true, false, true, false)]
		[InlineData(true, true, false, false)]
		[InlineData(true, true, true, false)]
		public void InvertedInvertedStandard(bool one, bool two, bool three, bool success)
			=> new NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void InvertedInvertedStandardNull()
			=> new NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => false), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Theory]
		[InlineData(false, false, false, true)]
		[InlineData(false, false, true, false)]
		[InlineData(false, true, false, false)]
		[InlineData(false, true, true, false)]
		[InlineData(true, false, false, false)]
		[InlineData(true, false, true, false)]
		[InlineData(true, true, false, false)]
		[InlineData(true, true, true, false)]
		public void InvertedInvertedInverted(bool one, bool two, bool three, bool success)
			=> new NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(Option.Some(10)) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void InvertedInvertedInvertedNull()
			=> new NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true), _ => _)
				.Data
				.WithValue(null)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());
	}
}
