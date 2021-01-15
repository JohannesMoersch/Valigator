using System;
using System.Collections.Generic;
using Valigator.Validators;
using Valigator.Core;
using Xunit;
using Valigator.ModelValidationData;
using FluentAssertions;
using Functional;

namespace Valigator.Models.Tests
{
	public class PropertyFactoryTests
	{
		public class RequiredValue
		{
			[Fact]
			public void CoerceUnsetFails()
				=> Data
					.Value<int>()
					.Required()
					.CoerceUnset()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.UnsetValuesNotAllowed() });

			[Fact]
			public void CoerceNoneFails()
				=> Data
					.Value<int>()
					.Required()
					.CoerceNone()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NullValuesNotAllowed() });

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Value<int>()
					.Required()
					.CoerceValue(5)
					.AssertSuccess()
					.Should()
					.Be(5);

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Value<int>()
					.Required()
					.WithValidValidator()
					.Validate(5)
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Value<int>()
					.Required()
					.WithInvalidValidator()
					.Validate(5)
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class RequiredNullableValue
		{
			[Fact]
			public void CoerceUnsetFails()
				=> Data
					.Value<int>(o => o.Nullable())
					.Required()
					.CoerceUnset()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.UnsetValuesNotAllowed() });

			[Fact]
			public void CoerceNoneSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Required()
					.CoerceNone()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Required()
					.CoerceValue(5)
					.AssertSuccess()
					.AssertSome()
					.Should()
					.Be(5);

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Required()
					.WithValidValidator()
					.Validate(Option.Some(5))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Required()
					.WithInvalidValidator()
					.Validate(Option.None<int>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Value<int>(o => o.Nullable())
					.Required()
					.WithInvalidValidator()
					.Validate(Option.Some(5))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class RequiredCollection
		{
			[Fact]
			public void CoerceUnsetFails()
				=> Data
					.Collection<int>()
					.Required()
					.CoerceUnset()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.UnsetValuesNotAllowed() });

			[Fact]
			public void CoerceNoneFails()
				=> Data
					.Collection<int>()
					.Required()
					.CoerceNone()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NullValuesNotAllowed() });

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Collection<int>()
					.Required()
					.CoerceValue(new[] { Option.Some(5) })
					.AssertSuccess()
					.Should()
					.BeEquivalentTo(new[] { 5 });

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Collection<int>()
					.Required()
					.WithValidValidator()
					.Validate(new[] { 5 })
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>()
					.Required()
					.WithInvalidValidator()
					.Validate(new[] { 5 })
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class RequiredNullableCollection
		{
			[Fact]
			public void CoerceUnsetFails()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Required()
					.CoerceUnset()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.UnsetValuesNotAllowed() });

			[Fact]
			public void CoerceNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Required()
					.CoerceNone()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Required()
					.CoerceValue(new[] { Option.Some(5) })
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentTo(new[] { 5 });

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Required()
					.WithValidValidator()
					.Validate(Option.Some<IReadOnlyList<int>>(new[] { 5 }))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Required()
					.WithInvalidValidator()
					.Validate(Option.None<IReadOnlyList<int>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Required()
					.WithInvalidValidator()
					.Validate(Option.Some<IReadOnlyList<int>>(new[] { 5 }))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class RequiredOptionCollection
		{
			[Fact]
			public void CoerceUnsetFails()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Required()
					.CoerceUnset()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.UnsetValuesNotAllowed() });

			[Fact]
			public void CoerceNoneFails()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Required()
					.CoerceNone()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NullValuesNotAllowed() });

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Required()
					.CoerceValue(new[] { Option.Some(5) })
					.AssertSuccess()
					.Should()
					.BeEquivalentTo(new[] { Option.Some(5) });

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Required()
					.WithValidValidator()
					.Validate(new[] { Option.Some(5) })
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Required()
					.WithInvalidValidator()
					.Validate(new[] { Option.Some(5) })
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class RequiredNullableOptionCollection
		{
			[Fact]
			public void CoerceUnsetFails()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Required()
					.CoerceUnset()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.UnsetValuesNotAllowed() });

			[Fact]
			public void CoerceNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Required()
					.CoerceNone()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Required()
					.CoerceValue(new[] { Option.Some(5) })
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentTo(new[] { Option.Some(5) });

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Required()
					.WithValidValidator()
					.Validate(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) }))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Required()
					.WithInvalidValidator()
					.Validate(Option.None<IReadOnlyList<Option<int>>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Required()
					.WithInvalidValidator()
					.Validate(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) }))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class OptionalValue
		{
			[Fact]
			public void CoerceUnsetSucceeds()
				=> Data
					.Value<int>()
					.Optional()
					.CoerceUnset()
					.AssertSuccess()
					.AssertUnset();

			[Fact]
			public void CoerceNoneFails()
				=> Data
					.Value<int>()
					.Optional()
					.CoerceNone()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NullValuesNotAllowed() });

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Value<int>()
					.Optional()
					.CoerceValue(5)
					.AssertSuccess()
					.AssertSet()
					.Should()
					.Be(5);

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Value<int>()
					.Optional()
					.WithValidValidator()
					.Validate(Optional.Set(5))
					.AssertSuccess();

			[Fact]
			public void ValidateUnsetSucceeds()
				=> Data
					.Value<int>()
					.Optional()
					.WithValidValidator()
					.Validate(Optional.Unset<int>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Value<int>()
					.Optional()
					.WithInvalidValidator()
					.Validate(Optional.Set(5))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class OptionalNullableValue
		{
			[Fact]
			public void CoerceUnsetSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Optional()
					.CoerceUnset()
					.AssertSuccess()
					.AssertUnset();

			[Fact]
			public void CoerceNoneSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Optional()
					.CoerceNone()
					.AssertSuccess()
					.AssertSet()
					.AssertNone();

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Optional()
					.CoerceValue(5)
					.AssertSuccess()
					.AssertSet()
					.AssertSome()
					.Should()
					.Be(5);

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Optional()
					.WithValidValidator()
					.Validate(Optional.Set(Option.Some(5)))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(Optional.Set(Option.None<int>()))
					.AssertSuccess();

			[Fact]
			public void ValidateUnsetSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(Optional.Unset<Option<int>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Value<int>(o => o.Nullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(Optional.Set(Option.Some(5)))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class OptionalCollection
		{
			[Fact]
			public void CoerceUnsetSucceeds()
				=> Data
					.Collection<int>()
					.Optional()
					.CoerceUnset()
					.AssertSuccess()
					.AssertUnset();

			[Fact]
			public void CoerceNoneFails()
				=> Data
					.Collection<int>()
					.Optional()
					.CoerceNone()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NullValuesNotAllowed() });

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Collection<int>()
					.Optional()
					.CoerceValue(new[] { Option.Some(5) })
					.AssertSuccess()
					.AssertSet()
					.Should()
					.BeEquivalentTo(new[] { 5 });

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Collection<int>()
					.Optional()
					.WithValidValidator()
					.Validate(Optional.Set<IReadOnlyList<int>>(new[] { 5 }))
					.AssertSuccess();

			[Fact]
			public void ValidateUnsetSucceeds()
				=> Data
					.Collection<int>()
					.Optional()
					.WithValidValidator()
					.Validate(Optional.Unset<IReadOnlyList<int>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>()
					.Optional()
					.WithInvalidValidator()
					.Validate(Optional.Set<IReadOnlyList<int>>(new[] { 5 }))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class OptionalNullableCollection
		{
			[Fact]
			public void CoerceUnsetSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Optional()
					.CoerceUnset()
					.AssertSuccess()
					.AssertUnset();

			[Fact]
			public void CoerceNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Optional()
					.CoerceNone()
					.AssertSuccess()
					.AssertSet()
					.AssertNone();

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Optional()
					.CoerceValue(new[] { Option.Some(5) })
					.AssertSuccess()
					.AssertSet()
					.AssertSome()
					.Should()
					.BeEquivalentTo(new[] { 5 });

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Optional()
					.WithValidValidator()
					.Validate(Optional.Set(Option.Some<IReadOnlyList<int>>(new[] { 5 })))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(Optional.Set(Option.None<IReadOnlyList<int>>()))
					.AssertSuccess();

			[Fact]
			public void ValidateUnsetSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(Optional.Unset<Option<IReadOnlyList<int>>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(Optional.Set(Option.Some<IReadOnlyList<int>>(new[] { 5 })))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class OptionalOptionCollection
		{
			[Fact]
			public void CoerceUnsetSucceeds()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Optional()
					.CoerceUnset()
					.AssertSuccess()
					.AssertUnset();

			[Fact]
			public void CoerceNoneFails()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Optional()
					.CoerceNone()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NullValuesNotAllowed() });

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Optional()
					.CoerceValue(new[] { Option.Some(5) })
					.AssertSuccess()
					.AssertSet()
					.Should()
					.BeEquivalentTo(new[] { Option.Some(5) });

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Optional()
					.WithValidValidator()
					.Validate(Optional.Set<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) }))
					.AssertSuccess();

			[Fact]
			public void ValidateUnsetSucceeds()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Optional()
					.WithValidValidator()
					.Validate(Optional.Unset<IReadOnlyList<Option<int>>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(Optional.Set<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) }))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class OptionalNullableOptionCollection
		{
			[Fact]
			public void CoerceUnsetSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Optional()
					.CoerceUnset()
					.AssertSuccess()
					.AssertUnset();

			[Fact]
			public void CoerceNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Optional()
					.CoerceNone()
					.AssertSuccess()
					.AssertSet()
					.AssertNone();

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Optional()
					.CoerceValue(new[] { Option.Some(5) })
					.AssertSuccess()
					.AssertSet()
					.AssertSome()
					.Should()
					.BeEquivalentTo(new[] { Option.Some(5) });

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Optional()
					.WithValidValidator()
					.Validate(Optional.Set(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) })))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(Optional.Set(Option.None<IReadOnlyList<Option<int>>>()))
					.AssertSuccess();

			[Fact]
			public void ValidateUnsetSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(Optional.Unset<Option<IReadOnlyList<Option<int>>>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(Optional.Set(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) })))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class DefaultedValue
		{
			[Fact]
			public void CoerceUnsetSucceeds()
				=> Data
					.Value<int>()
					.Defaulted(2)
					.CoerceUnset()
					.AssertSuccess()
					.Should()
					.Be(2);

			[Fact]
			public void CoerceNoneFails()
				=> Data
					.Value<int>()
					.Defaulted(2)
					.CoerceNone()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NullValuesNotAllowed() });

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Value<int>()
					.Defaulted(2)
					.CoerceValue(5)
					.AssertSuccess()
					.Should()
					.Be(5);

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Value<int>()
					.Defaulted(2)
					.WithValidValidator()
					.Validate(5)
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Value<int>()
					.Defaulted(2)
					.WithInvalidValidator()
					.Validate(5)
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class DefaultedNullableValue
		{
			[Fact]
			public void CoerceUnsetSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Defaulted(Option.Some(2))
					.CoerceUnset()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.Be(2);

			[Fact]
			public void CoerceNoneSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Defaulted(Option.Some(2))
					.CoerceNone()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Defaulted(Option.Some(2))
					.CoerceValue(5)
					.AssertSuccess()
					.AssertSome()
					.Should()
					.Be(5);

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Defaulted(Option.Some(2))
					.WithValidValidator()
					.Validate(Option.Some(5))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Defaulted(Option.Some(2))
					.WithInvalidValidator()
					.Validate(Option.None<int>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Value<int>(o => o.Nullable())
					.Defaulted(Option.Some(2))
					.WithInvalidValidator()
					.Validate(Option.Some(5))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class DefaultedCollection
		{
			[Fact]
			public void CoerceUnsetSucceeds()
				=> Data
					.Collection<int>()
					.Defaulted(new[] { 2 })
					.CoerceUnset()
					.AssertSuccess()
					.Should()
					.BeEquivalentTo(new[] { 2 });

			[Fact]
			public void CoerceNoneFails()
				=> Data
					.Collection<int>()
					.Defaulted(new[] { 2 })
					.CoerceNone()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NullValuesNotAllowed() });

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Collection<int>()
					.Defaulted(new[] { 2 })
					.CoerceValue(new[] { Option.Some(5) })
					.AssertSuccess()
					.Should()
					.BeEquivalentTo(new[] { 5 });

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Collection<int>()
					.Defaulted(new[] { 2 })
					.WithValidValidator()
					.Validate(new[] { 5 })
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>()
					.Defaulted(new[] { 2 })
					.WithInvalidValidator()
					.Validate(new[] { 5 })
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class DefaultedNullableCollection
		{
			[Fact]
			public void CoerceUnsetSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Defaulted(Option.Some<IReadOnlyList<int>>(new[] { 2 }))
					.CoerceUnset()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentTo(new[] { 2 });

			[Fact]
			public void CoerceNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Defaulted(Option.Some<IReadOnlyList<int>>(new[] { 2 }))
					.CoerceNone()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Defaulted(Option.Some<IReadOnlyList<int>>(new[] { 2 }))
					.CoerceValue(new[] { Option.Some(5) })
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentTo(new[] { 5 });

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Defaulted(Option.Some<IReadOnlyList<int>>(new[] { 2 }))
					.WithValidValidator()
					.Validate(Option.Some<IReadOnlyList<int>>(new[] { 5 }))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Defaulted(Option.Some<IReadOnlyList<int>>(new[] { 2 }))
					.WithInvalidValidator()
					.Validate(Option.None<IReadOnlyList<int>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Defaulted(Option.Some<IReadOnlyList<int>>(new[] { 2 }))
					.WithInvalidValidator()
					.Validate(Option.Some<IReadOnlyList<int>>(new[] { 5 }))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class DefaultedOptionCollection
		{
			[Fact]
			public void CoerceUnsetSucceeds()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Defaulted(new[] { Option.Some(2) })
					.CoerceUnset()
					.AssertSuccess()
					.Should()
					.BeEquivalentTo(new[] { Option.Some(2) });

			[Fact]
			public void CoerceNoneFails()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Defaulted(new[] { Option.Some(2) })
					.CoerceNone()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NullValuesNotAllowed() });

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Defaulted(new[] { Option.Some(2) })
					.CoerceValue(new[] { Option.Some(5) })
					.AssertSuccess()
					.Should()
					.BeEquivalentTo(new[] { Option.Some(5) });

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Defaulted(new[] { Option.Some(2) })
					.WithValidValidator()
					.Validate(new[] { Option.Some(5) })
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Defaulted(new[] { Option.Some(2) })
					.WithInvalidValidator()
					.Validate(new[] { Option.Some(5) })
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class DefaultedNullableOptionCollection
		{
			[Fact]
			public void CoerceUnsetFails()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Defaulted(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(2) }))
					.CoerceUnset()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentTo(new[] { Option.Some(2) });

			[Fact]
			public void CoerceNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Defaulted(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(2) }))
					.CoerceNone()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void CoerceValueSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Defaulted(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(2) }))
					.CoerceValue(new[] { Option.Some(5) })
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentTo(new[] { Option.Some(5) });

			[Fact]
			public void ValidateValueSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Defaulted(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(2) }))
					.WithValidValidator()
					.Validate(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) }))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Defaulted(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(2) }))
					.WithInvalidValidator()
					.Validate(Option.None<IReadOnlyList<Option<int>>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Defaulted(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(2) }))
					.WithInvalidValidator()
					.Validate(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) }))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}
	}
}
