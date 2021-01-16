using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Xunit;

namespace Valigator.Models.Tests
{
	public class DataTests
	{
		[Fact]
		public void RequiredValueSetSucceeds()
			=> Data
				.Value<int>()
				.Required()
				.ToData()
				.WithValue(Option.Some(5))
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(5);

		[Fact]
		public void RequiredValueNoneFails()
			=> Data
				.Value<int>()
				.Required()
				.ToData()
				.WithValue(Option.None<int>())
				.TryGetValue()
				.AssertFailure()
				.Should()
				.BeEquivalentTo(ValidationErrors.NullValuesNotAllowed());

		[Fact]
		public void RequiredNullableValueNoneSucceeds()
			=> Data
				.Value<int>(o => o.Nullable())
				.Required()
				.ToData()
				.WithValue(Option.None<int>())
				.TryGetValue()
				.AssertSuccess()
				.AssertNone();

		[Fact]
		public void RequiredValueUnsetFails()
			=> Data
				.Value<int>()
				.Required()
				.ToData()
				.TryGetValue()
				.AssertFailure()
				.Should()
				.BeEquivalentTo(ValidationErrors.UnsetValuesNotAllowed());

		[Fact]
		public void DefaultedValueUnsetSucceeds()
			=> Data
				.Value<int>()
				.Defaulted(5)
				.ToData()
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(5);

		[Fact]
		public void RequiredValueSetValidSucceeds()
			=> Data
				.Value<int>()
				.Required()
				.WithValidValidator()
				.ToData()
				.WithValue(Option.Some(5))
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(5);

		[Fact]
		public void RequiredValueSetInvalidFails()
			=> Data
				.Value<int>()
				.Required()
				.WithInvalidValidator()
				.ToData()
				.WithValue(Option.Some(5))
				.TryGetValue()
				.AssertFailure()
				.Should()
				.BeEquivalentTo(new[] { TestValidator.Error });
	}
}
