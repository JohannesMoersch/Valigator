using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator;
using Xunit;

namespace Valigator.Models.Tests
{
	public class NullableForEachModelValidatorTests
	{
		[Fact]
		public void ValidIsSuccess()
			=> new ModelValidationData<NullableForEachModelValidatorTests, Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new[] { Option.Some(0) })
				.AssertSuccess();

		[Fact]
		public void NoneIsSuccess()
			=> new ModelValidationData<NullableForEachModelValidatorTests, Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Invalid()))
				.Process(this, new[] { Option.None<int>() })
				.AssertSuccess();

		[Fact]
		public void InvalidIsFailure()
			=> new ModelValidationData<NullableForEachModelValidatorTests, Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new[] { Option.Some(1) })
				.AssertFailure();

		[Fact]
		public void ValidAndInvalidIsFailure()
			=> new ModelValidationData<NullableForEachModelValidatorTests, Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new[] { Option.Some(0), Option.Some(1) })
				.AssertFailure();

		[Fact]
		public void InvalidAndValidIsFailure()
			=> new ModelValidationData<NullableForEachModelValidatorTests, Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new[] { Option.Some(1), Option.Some(0) })
				.AssertFailure();

		[Fact]
		public void InvalidErrorsAreCorrect()
			=> new ModelValidationData<NullableForEachModelValidatorTests, Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { Errors.One }))))
				.Process(this, new[] { Option.Some(1) })
				.AssertFailure();

		[Fact]
		public void InvalidAndInvalidErrorsAreCorrect()
			=> new ModelValidationData<NullableForEachModelValidatorTests, Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { i == 1 ? Errors.One : Errors.Two }))))
				.Process(this, new[] { Option.Some(1), Option.Some(0), Option.Some(3) })
				.AssertFailure()
				.Should()
				.BeEquivalentTo(new[] { Errors.One, Errors.Two });
	}
}
