using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Functional;
using Valigator.Core;
using Valigator.Core.DataContainers.Factories;
using Valigator.Core.DataSources;
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
			=> new DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one))
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
			=> new DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one))
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
			=> new DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two))
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
			=> new DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two))
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
			=> new DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two))
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
			=> new DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two))
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
			=> new DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three))
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
			=> new DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three))
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
			=> new DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three))
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
			=> new DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three))
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
			=> new DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three))
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
			=> new DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three))
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
			=> new DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three))
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
			=> new DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new DataContainerFactory<RequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => one), new CustomValidator<int>("", _ => two), new CustomValidator<int>("", _ => three))
				.Data
				.WithValue(10)
				.Verify(new object())
				.TryGetValue()
				.Match
				(
					s => success ? s.Should().Be(10) : throw new Exception("Expected failure but found success."),
					f => !success ? f.Should().NotBeNull() as object : throw new Exception("Expected success but found failure.")
				);

		[Fact]
		public void StandardWithNull()
			=> new DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true))
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Fact]
		public void InvertedWithNull()
			=> new DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true))
		.Data
		.WithNull()
		.Verify(new object())
		.TryGetValue()
		.AssertSuccess()
		.Should()
		.Be(Option.None<int>());

		[Fact]
		public void StandardStandardWithNull()
			=> new DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true))
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Fact]
		public void StandardInvertedWithNull()
			=> new DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true))
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Fact]
		public void InvertedStandardWithNull()
			=> new DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true))
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Fact]
		public void InvertedInvertedWithNull()
			=> new DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true))
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Fact]
		public void StandardStandardStandardWithNull()
			=> new DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true))
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Fact]
		public void StandardStandardInvertedWithNull()
			=> new DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true))
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Fact]
		public void StandardInvertedStandardWithNull()
			=> new DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true))
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Fact]
		public void StandardInvertedInvertedWithNull()
			=> new DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true))
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Fact]
		public void InvertedStandardStandardWithNull()
			=> new DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true))
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Fact]
		public void InvertedStandardInvertedWithNull()
			=> new DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true))
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Fact]
		public void InvertedInvertedStandardWithNull()
			=> new DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true))
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

		[Fact]
		public void InvertedInvertedInvertedWithNull()
			=> new DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, CustomValidator<int>, CustomValidator<int>, CustomValidator<int>>(new NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>(default, Mapping.CreatePassthrough<int>()), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true), new CustomValidator<int>("", _ => true))
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(Option.None<int>());

	}
}
