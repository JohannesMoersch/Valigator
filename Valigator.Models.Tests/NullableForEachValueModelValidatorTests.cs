using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator;
using Valigator.Core;
using Xunit;

namespace Valigator.Models.Tests
{
	public class NullableForEachValueModelValidatorTests
	{
		[Fact]
		public void ValidIsSuccess()
			=> new ModelValidationData<NullableForEachValueModelValidatorTests, Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new Dictionary<string, Option<int>>() { { "A", Option.Some(0) } })
				.AssertSuccess();

		[Fact]
		public void NoneIsSuccess()
			=> new ModelValidationData<NullableForEachValueModelValidatorTests, Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Invalid()))
				.Process(this, new Dictionary<string, Option<int>>() { { String.Empty, Option.None<int>() } })
				.AssertSuccess();

		[Fact]
		public void InvalidIsFailure()
			=> new ModelValidationData<NullableForEachValueModelValidatorTests, Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new Dictionary<string, Option<int>>() { { "B", Option.Some(1) } })
				.AssertFailure();

		[Fact]
		public void ValidAndInvalidIsFailure()
			=> new ModelValidationData<NullableForEachValueModelValidatorTests, Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new Dictionary<string, Option<int>>() { { "A", Option.Some(0) }, { "B", Option.Some(1) } })
				.AssertFailure();

		[Fact]
		public void InvalidAndValidIsFailure()
			=> new ModelValidationData<NullableForEachValueModelValidatorTests, Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new Dictionary<string, Option<int>>() { { "B", Option.Some(1) }, { "A", Option.Some(0) } })
				.AssertFailure();

		[Fact]
		public void InvalidErrorsAreCorrect()
			=> new ModelValidationData<NullableForEachValueModelValidatorTests, Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { Errors.One }))))
				.Process(this, new Dictionary<string, Option<int>>() { { "B", Option.Some(1) } })
				.AssertFailure();

		[Fact]
		public void InvalidAndInvalidErrorsAreCorrect()
			=> new ModelValidationData<NullableForEachValueModelValidatorTests, Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { i == 1 ? Errors.One : Errors.Two }))))
				.Process(this, new Dictionary<string, Option<int>>() { { "B", Option.Some(1) }, { "A", Option.Some(0) }, { "D", Option.Some(3) } })
				.AssertFailure()
				.Should()
				.BeEquivalentTo(new[] { Errors.One, Errors.Two });
	}
}
