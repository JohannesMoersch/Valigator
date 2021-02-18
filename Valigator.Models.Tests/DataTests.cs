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
		public void DefaultDataTryGetValueThrowsException()
			=> Assert
				.Throws<DataNotInitializedException>
				(
					() => default(Data<int>)
						.TryGetValue()
				);

		[Fact]
		public void DefaultDataValueThrowsException()
			=> Assert
				.Throws<DataNotInitializedException>
				(
					() => default(Data<int>)
						.Value
				);

		[Fact]
		public void DefaultDataWithValueThrowsException()
			=> Assert
				.Throws<DataNotInitializedException>
				(
					() => default(Data<int>)
						.WithValue(Option.Some(5))
				);

		[Fact]
		public void RequiredValueSetTryGetValueSucceeds()
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
		public void RequiredValueNoneTryGetValueFails()
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
		public void RequiredNullableValueNoneTryGetValueSucceeds()
			=> Data
				.Value<int>(o => o.Nullable())
				.Required()
				.ToData()
				.WithValue(Option.None<int>())
				.TryGetValue()
				.AssertSuccess()
				.AssertNone();

		[Fact]
		public void RequiredValueUnsetTryGetValueFails()
			=> Data
				.Value<int>()
				.Required()
				.ToData()
				.TryGetValue()
				.AssertFailure()
				.Should()
				.BeEquivalentTo(ValidationErrors.UnsetValuesNotAllowed());

		[Fact]
		public void DefaultedValueUnsetTryGetValueSucceeds()
			=> Data
				.Value<int>()
				.Defaulted(5)
				.ToData()
				.TryGetValue()
				.AssertSuccess()
				.Should()
				.Be(5);

		[Fact]
		public void RequiredValueSetValidTryGetValueSucceeds()
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
		public void RequiredValueSetInvalidTryGetValueFails()
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

		[Fact]
		public void RequiredValueSetValueSucceeds()
			=> Data
				.Value<int>()
				.Required()
				.ToData()
				.WithValue(Option.Some(5))
				.Value
				.Should()
				.Be(5);

		[Fact]
		public void RequiredValueNoneValueThrowsException()
			=> Assert
				.Throws<DataInvalidException>
				(
					() => Data
						.Value<int>()
						.Required()
						.ToData()
						.WithValue(Option.None<int>())
						.Value
				)
				.ValidationErrors
				.Should()
				.BeEquivalentTo(ValidationErrors.NullValuesNotAllowed());

		[Fact]
		public void RequiredNullableValueNoneValueSucceeds()
			=> Data
				.Value<int>(o => o.Nullable())
				.Required()
				.ToData()
				.WithValue(Option.None<int>())
				.Value
				.AssertNone();

		[Fact]
		public void RequiredValueUnsetValueThrowsException()
			=> Assert
				.Throws<DataInvalidException>
				(
					() => Data
						.Value<int>()
						.Required()
						.ToData()
						.Value
				)
				.ValidationErrors
				.Should()
				.BeEquivalentTo(ValidationErrors.UnsetValuesNotAllowed());

		[Fact]
		public void DefaultedValueUnsetValueSucceeds()
			=> Data
				.Value<int>()
				.Defaulted(5)
				.ToData()
				.Value
				.Should()
				.Be(5);

		[Fact]
		public void RequiredValueSetValidValueSucceeds()
			=> Data
				.Value<int>()
				.Required()
				.WithValidValidator()
				.ToData()
				.WithValue(Option.Some(5))
				.Value
				.Should()
				.Be(5);

		[Fact]
		public void RequiredValueSetInvalidValueThrowsException()
			=> Assert
				.Throws<DataInvalidException>
				(
					() => Data
						.Value<int>()
						.Required()
						.WithInvalidValidator()
						.ToData()
						.WithValue(Option.Some(5))
						.Value
				)
				.ValidationErrors
				.Should()
				.BeEquivalentTo(new[] { TestValidator.Error });
	}
}
