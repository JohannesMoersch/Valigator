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
	public class DataSourceTests
	{
		[Theory]
		[InlineData(false, false)]
		[InlineData(true, true)]
		public void Standard(bool one, bool success)
			=> new DataSourceStandard<RequiredStateValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Theory]
		[InlineData(false, true)]
		[InlineData(true, false)]
		public void Inverted(bool one, bool success)
			=> new DataSourceInverted<RequiredStateValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Theory]
		[InlineData(false, false, false)]
		[InlineData(false, true, false)]
		[InlineData(true, false, false)]
		[InlineData(true, true, true)]
		public void StandardStandard(bool one, bool two, bool success)
			=> new DataSourceStandardStandard<RequiredStateValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Theory]
		[InlineData(false, false, false)]
		[InlineData(false, true, false)]
		[InlineData(true, false, true)]
		[InlineData(true, true, false)]
		public void StandardInverted(bool one, bool two, bool success)
			=> new DataSourceStandardInverted<RequiredStateValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Theory]
		[InlineData(false, false, false)]
		[InlineData(false, true, true)]
		[InlineData(true, false, false)]
		[InlineData(true, true, false)]
		public void InvertedStandard(bool one, bool two, bool success)
			=> new DataSourceInvertedStandard<RequiredStateValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Theory]
		[InlineData(false, false, true)]
		[InlineData(false, true, false)]
		[InlineData(true, false, false)]
		[InlineData(true, true, false)]
		public void InvertedInverted(bool one, bool two, bool success)
			=> new DataSourceInvertedInverted<RequiredStateValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

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
			=> new DataSourceStandardStandardStandard<RequiredStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

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
			=> new DataSourceStandardStandardInverted<RequiredStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

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
			=> new DataSourceStandardInvertedStandard<RequiredStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

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
			=> new DataSourceStandardInvertedInverted<RequiredStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

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
			=> new DataSourceInvertedStandardStandard<RequiredStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

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
			=> new DataSourceInvertedStandardInverted<RequiredStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

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
			=> new DataSourceInvertedInvertedStandard<RequiredStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

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
			=> new DataSourceInvertedInvertedInverted<RequiredStateValidator<int>, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>, int, int>(default, new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three), _ => _)
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);
	}
}
