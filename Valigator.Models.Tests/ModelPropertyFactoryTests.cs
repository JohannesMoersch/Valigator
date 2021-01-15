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
	public class ModelPropertyFactoryTests
	{
		public class RequiredModelValue
		{
			public ModelPropertyFactory<RequiredModelValue> Data => ModelPropertyFactory<RequiredModelValue>.Instance;
			
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
					.Validate(this, 5)
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Value<int>()
					.Required()
					.WithInvalidValidator()
					.Validate(this, 5)
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class RequiredModelNullableValue
		{
			public ModelPropertyFactory<RequiredModelNullableValue> Data => ModelPropertyFactory<RequiredModelNullableValue>.Instance;
			
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
					.Validate(this, Option.Some(5))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Required()
					.WithInvalidValidator()
					.Validate(this, Option.None<int>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Value<int>(o => o.Nullable())
					.Required()
					.WithInvalidValidator()
					.Validate(this, Option.Some(5))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class RequiredModelCollection
		{
			public ModelPropertyFactory<RequiredModelCollection> Data => ModelPropertyFactory<RequiredModelCollection>.Instance;
			
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
					.Validate(this, new[] { 5 })
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>()
					.Required()
					.WithInvalidValidator()
					.Validate(this, new[] { 5 })
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class RequiredModelNullableCollection
		{
			public ModelPropertyFactory<RequiredModelNullableCollection> Data => ModelPropertyFactory<RequiredModelNullableCollection>.Instance;
			
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
					.Validate(this, Option.Some<IReadOnlyList<int>>(new[] { 5 }))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Required()
					.WithInvalidValidator()
					.Validate(this, Option.None<IReadOnlyList<int>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Required()
					.WithInvalidValidator()
					.Validate(this, Option.Some<IReadOnlyList<int>>(new[] { 5 }))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class RequiredModelOptionCollection
		{
			public ModelPropertyFactory<RequiredModelOptionCollection> Data => ModelPropertyFactory<RequiredModelOptionCollection>.Instance;
			
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
					.Validate(this, new[] { Option.Some(5) })
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Required()
					.WithInvalidValidator()
					.Validate(this, new[] { Option.Some(5) })
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class RequiredModelNullableOptionCollection
		{
			public ModelPropertyFactory<RequiredModelNullableOptionCollection> Data => ModelPropertyFactory<RequiredModelNullableOptionCollection>.Instance;
			
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
					.Validate(this, Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) }))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Required()
					.WithInvalidValidator()
					.Validate(this, Option.None<IReadOnlyList<Option<int>>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Required()
					.WithInvalidValidator()
					.Validate(this, Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) }))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class OptionalModelValue
		{
			public ModelPropertyFactory<OptionalModelValue> Data => ModelPropertyFactory<OptionalModelValue>.Instance;
			
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
					.Validate(this, Optional.Set(5))
					.AssertSuccess();

			[Fact]
			public void ValidateUnsetSucceeds()
				=> Data
					.Value<int>()
					.Optional()
					.WithValidValidator()
					.Validate(this, Optional.Unset<int>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Value<int>()
					.Optional()
					.WithInvalidValidator()
					.Validate(this, Optional.Set(5))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class OptionalModelNullableValue
		{
			public ModelPropertyFactory<OptionalModelNullableValue> Data => ModelPropertyFactory<OptionalModelNullableValue>.Instance;
			
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
					.Validate(this, Optional.Set(Option.Some(5)))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(this, Optional.Set(Option.None<int>()))
					.AssertSuccess();

			[Fact]
			public void ValidateUnsetSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(this, Optional.Unset<Option<int>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Value<int>(o => o.Nullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(this, Optional.Set(Option.Some(5)))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class OptionalModelCollection
		{
			public ModelPropertyFactory<OptionalModelCollection> Data => ModelPropertyFactory<OptionalModelCollection>.Instance;
			
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
					.Validate(this, Optional.Set<IReadOnlyList<int>>(new[] { 5 }))
					.AssertSuccess();

			[Fact]
			public void ValidateUnsetSucceeds()
				=> Data
					.Collection<int>()
					.Optional()
					.WithValidValidator()
					.Validate(this, Optional.Unset<IReadOnlyList<int>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>()
					.Optional()
					.WithInvalidValidator()
					.Validate(this, Optional.Set<IReadOnlyList<int>>(new[] { 5 }))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class OptionalModelNullableCollection
		{
			public ModelPropertyFactory<OptionalModelNullableCollection> Data => ModelPropertyFactory<OptionalModelNullableCollection>.Instance;
			
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
					.Validate(this, Optional.Set(Option.Some<IReadOnlyList<int>>(new[] { 5 })))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(this, Optional.Set(Option.None<IReadOnlyList<int>>()))
					.AssertSuccess();

			[Fact]
			public void ValidateUnsetSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(this, Optional.Unset<Option<IReadOnlyList<int>>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(this, Optional.Set(Option.Some<IReadOnlyList<int>>(new[] { 5 })))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class OptionalModelOptionCollection
		{
			public ModelPropertyFactory<OptionalModelOptionCollection> Data => ModelPropertyFactory<OptionalModelOptionCollection>.Instance;
			
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
					.Validate(this, Optional.Set<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) }))
					.AssertSuccess();

			[Fact]
			public void ValidateUnsetSucceeds()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Optional()
					.WithValidValidator()
					.Validate(this, Optional.Unset<IReadOnlyList<Option<int>>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(this, Optional.Set<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) }))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class OptionalModelNullableOptionCollection
		{
			public ModelPropertyFactory<OptionalModelNullableOptionCollection> Data => ModelPropertyFactory<OptionalModelNullableOptionCollection>.Instance;
			
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
					.Validate(this, Optional.Set(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) })))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(this, Optional.Set(Option.None<IReadOnlyList<Option<int>>>()))
					.AssertSuccess();

			[Fact]
			public void ValidateUnsetSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(this, Optional.Unset<Option<IReadOnlyList<Option<int>>>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Optional()
					.WithInvalidValidator()
					.Validate(this, Optional.Set(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) })))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class DefaultedModelValue
		{
			public ModelPropertyFactory<DefaultedModelValue> Data => ModelPropertyFactory<DefaultedModelValue>.Instance;
			
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
					.Validate(this, 5)
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Value<int>()
					.Defaulted(2)
					.WithInvalidValidator()
					.Validate(this, 5)
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class DefaultedModelNullableValue
		{
			public ModelPropertyFactory<DefaultedModelNullableValue> Data => ModelPropertyFactory<DefaultedModelNullableValue>.Instance;
			
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
					.Validate(this, Option.Some(5))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Value<int>(o => o.Nullable())
					.Defaulted(Option.Some(2))
					.WithInvalidValidator()
					.Validate(this, Option.None<int>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Value<int>(o => o.Nullable())
					.Defaulted(Option.Some(2))
					.WithInvalidValidator()
					.Validate(this, Option.Some(5))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class DefaultedModelCollection
		{
			public ModelPropertyFactory<DefaultedModelCollection> Data => ModelPropertyFactory<DefaultedModelCollection>.Instance;
			
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
					.Validate(this, new[] { 5 })
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>()
					.Defaulted(new[] { 2 })
					.WithInvalidValidator()
					.Validate(this, new[] { 5 })
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class DefaultedModelNullableCollection
		{
			public ModelPropertyFactory<DefaultedModelNullableCollection> Data => ModelPropertyFactory<DefaultedModelNullableCollection>.Instance;
			
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
					.Validate(this, Option.Some<IReadOnlyList<int>>(new[] { 5 }))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Defaulted(Option.Some<IReadOnlyList<int>>(new[] { 2 }))
					.WithInvalidValidator()
					.Validate(this, Option.None<IReadOnlyList<int>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.Nullable())
					.Defaulted(Option.Some<IReadOnlyList<int>>(new[] { 2 }))
					.WithInvalidValidator()
					.Validate(this, Option.Some<IReadOnlyList<int>>(new[] { 5 }))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class DefaultedModelOptionCollection
		{
			public ModelPropertyFactory<DefaultedModelOptionCollection> Data => ModelPropertyFactory<DefaultedModelOptionCollection>.Instance;
			
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
					.Validate(this, new[] { Option.Some(5) })
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.ItemsNullable())
					.Defaulted(new[] { Option.Some(2) })
					.WithInvalidValidator()
					.Validate(this, new[] { Option.Some(5) })
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}

		public class DefaultedModelNullableOptionCollection
		{
			public ModelPropertyFactory<DefaultedModelNullableOptionCollection> Data => ModelPropertyFactory<DefaultedModelNullableOptionCollection>.Instance;
			
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
					.Validate(this, Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) }))
					.AssertSuccess();

			[Fact]
			public void ValidateNoneSucceeds()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Defaulted(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(2) }))
					.WithInvalidValidator()
					.Validate(this, Option.None<IReadOnlyList<Option<int>>>())
					.AssertSuccess();

			[Fact]
			public void ValidateValueFails()
				=> Data
					.Collection<int>(o => o.Nullable().ItemsNullable())
					.Defaulted(Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(2) }))
					.WithInvalidValidator()
					.Validate(this, Option.Some<IReadOnlyList<Option<int>>>(new[] { Option.Some(5) }))
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { TestValidator.Error });
		}
	}
}
