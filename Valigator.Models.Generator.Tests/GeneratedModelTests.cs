using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Valigator.Models.Generator.Tests
{
	public partial class GeneratedModelTests
	{
		//[GenerateModel(DefaultPropertyAccessors = PropertyAccessors.GetAndSet)]
		public partial class RequiredValueModelDefinition
		{
			//public Property<int> Value => Data.Value<int>().Required();
		}

		[global::Valigator.GeneratedFrom(typeof(global::Valigator.Models.Generator.Tests.GeneratedModelTests.RequiredValueModelDefinition))]
		public sealed partial class RequiredValueModel : global::Valigator.IModel, global::System.IEquatable<RequiredValueModel?>
		{
			static RequiredValueModel()
			{
				ModelDefinition = new global::Valigator.Models.Generator.Tests.GeneratedModelTests.RequiredValueModelDefinition();
				//_value_Property = ModelDefinition.Value;
			}

			public static global::Valigator.Models.Generator.Tests.GeneratedModelTests.RequiredValueModelDefinition ModelDefinition { get; }

			private volatile global::Valigator.Models.IReadOnlyModelErrorDictionary? _errorDictionary;

			private static global::Valigator.Models.ModelDefinition<ModelView>.Property<int> _value_Property = new ModelDefinition<ModelView>.Property<int>(null);
			private global::Valigator.Models.ModelPropertyState _value_State;
			private int _value;
			public int Value
			{
				get => Get(nameof(Value), ref _value, ref _value_State);
				set => Set(value, ref _value, ref _value_State);
			}

			public RequiredValueModel()
			{
			}

			public RequiredValueModel(int value)
			{
				this.Value = value;
			}

			private TValue Get<TValue>(string propertyName, ref TValue value, ref global::Valigator.Models.ModelPropertyState state)
			{
				var errorDictionary = _errorDictionary;

				if (Object.ReferenceEquals(errorDictionary, ModelErrorDictionaryBase.Valid))
					return value;

				if (Object.ReferenceEquals(errorDictionary, ModelErrorDictionaryBase.Uncoerced))
				{
					var coercedDictionary = Coerce();
					var validatedDictionary = Validate(coercedDictionary);

					_errorDictionary = errorDictionary = validatedDictionary ?? ModelErrorDictionaryBase.Valid;
				}
				else if (Object.ReferenceEquals(errorDictionary, ModelErrorDictionaryBase.Unvalidated) || errorDictionary is CoercedModelErrorDictionary)
				{
					var validatedDictionary = Validate(errorDictionary as CoercedModelErrorDictionary);

					_errorDictionary = errorDictionary = validatedDictionary ?? ModelErrorDictionaryBase.Valid;
				}

				return Object.ReferenceEquals(errorDictionary, ModelErrorDictionaryBase.Valid)
					? value
					: !errorDictionary.TryGetValue(propertyName, out var errors)
						? value
						: throw new global::Valigator.DataInvalidException(errors);
			}

			private void Set<TValue>(TValue newValue, ref TValue value, ref global::Valigator.Models.ModelPropertyState state)
			{
				value = newValue;
				state = global::Valigator.Models.ModelPropertyState.Set;

				if (_errorDictionary != ModelErrorDictionaryBase.Uncoerced)
					_errorDictionary = ModelErrorDictionaryBase.Unvalidated;

				_errorDictionary = global::Valigator.Models.ModelErrorDictionaryBase.Unvalidated;
			}

			private CoercedModelErrorDictionary? Coerce()
			{
				CoercedModelErrorDictionary? newDictionary = null;

				if (_value_State == global::Valigator.Models.ModelPropertyState.Unset)
					global::Valigator.Models.ModelDefinitionPropertyExtensions.CoerceUnset(_value_Property, nameof(Value), ref _value, ref _value_State, ref newDictionary);

				return newDictionary;
			}

			private IReadOnlyModelErrorDictionary? Validate(CoercedModelErrorDictionary? readOnlyErrorDictionary)
			{
				ValidatedModelErrorDictionary? newDictionary = null;

				var view = new ModelView(this);

				if (_value_State != global::Valigator.Models.ModelPropertyState.CoerceFailed)
					global::Valigator.Models.ModelDefinitionPropertyExtensions.Validate(_value_Property, view, nameof(Value), _value, readOnlyErrorDictionary, ref newDictionary);

				return (IReadOnlyModelErrorDictionary?)newDictionary ?? readOnlyErrorDictionary;
			}

			public override bool Equals(object? obj)
				=> obj is RequiredValueModel value && Equals(value);

			public bool Equals(RequiredValueModel? other)
				=> other is RequiredValueModel value &&
					Value == value.Value;

			public override int GetHashCode()
			{
				var hash = new System.HashCode();
				hash.Add(Value);
				return hash.ToHashCode();
			}

			public struct ModelView
			{
				private RequiredValueModel _model;

				public ModelView(RequiredValueModel model)
					=> _model = model;

				public global::Functional.Result<int, global::Valigator.Models.ModelPropertyNotSet> Value => Get(ref _model._value);

				private global::Functional.Result<TValue, global::Valigator.Models.ModelPropertyNotSet> Get<TValue>(ref TValue value)
				{
					var errorDictionary = _model._errorDictionary;

					if (Object.ReferenceEquals(errorDictionary, ModelErrorDictionaryBase.Valid))
						return Result.Success<TValue, global::Valigator.Models.ModelPropertyNotSet>(value);

					if (Object.ReferenceEquals(errorDictionary, ModelErrorDictionaryBase.Uncoerced))
					{
						var coercedDictionary = _model.Coerce();

						_model._errorDictionary = errorDictionary = coercedDictionary ?? ModelErrorDictionaryBase.Unvalidated;
					}

					return Object.ReferenceEquals(errorDictionary, ModelErrorDictionaryBase.Valid)
						? value
						: !errorDictionary.TryGetValue(propertyName, out var errors)
							? value
							: throw new global::Valigator.DataInvalidException(errors);







					if (_model._modelState == global::Valigator.Models.ModelState.Unset)
						_model.Coerce();

					return global::Functional.Result
						.Create
						(
							state != global::Valigator.Models.ModelPropertyState.CoerceFailed,
							value,
							global::Valigator.Models.ModelPropertyNotSet.Value
						);
				}
			}
		}

		[Fact]
		public void SetWhenRequired()
			=> new RequiredValueModel()
				.Do(o => o.Value = 5)
				.Value
				.Should()
				.Be(5);

		[Fact]
		public void UnsetWhenRequired()
			=> new RequiredValueModel()
				.Throws(default(DataInvalidException), o => o.Value);

		[GenerateModel(DefaultPropertyAccessors = PropertyAccessors.GetAndSet)]
		public partial class RequiredNullableValueModelDefinition
		{
			public Property<Option<int>> Value => Data.Value<int>(o => o.Nullable()).Required();
		}

		[Fact]
		public void SetSomeWhenNullableRequired()
			=> new RequiredNullableValueModel()
				.Do(o => o.Value = Option.Some(5))
				.Value
				.AssertSome()
				.Should()
				.Be(5);

		[Fact]
		public void SetNoneWhenNullableRequired()
			=> new RequiredNullableValueModel()
				.Do(o => o.Value = Option.None<int>())
				.Value
				.AssertNone();

		[Fact]
		public void UnsetWhenNullableRequired()
			=> new RequiredNullableValueModel()
				.Throws(default(DataInvalidException), o => o.Value);

		[GenerateModel(DefaultPropertyAccessors = PropertyAccessors.GetAndSet)]
		public partial class OptionalValueModelDefinition
		{
			public Property<Optional<int>> Value => Data.Value<int>().Optional();
		}

		[Fact]
		public void SetWhenOptional()
			=> new OptionalValueModel()
				.Do(o => o.Value = Optional.Set(5))
				.Value
				.AssertSet()
				.Should()
				.Be(5);

		[Fact]
		public void UnsetWhenOptional()
			=> new OptionalValueModel()
				.Value
				.AssertUnset();

		[GenerateModel(DefaultPropertyAccessors = PropertyAccessors.GetAndSet)]
		public partial class OptionalNullableValueModelDefinition
		{
			public Property<Optional<Option<int>>> Value => Data.Value<int>(o => o.Nullable()).Optional();
		}

		[Fact]
		public void SetSomeWhenNullableOptional()
			=> new OptionalNullableValueModel()
				.Do(o => o.Value = Optional.Set(Option.Some(5)))
				.Value
				.AssertSet()
				.AssertSome()
				.Should()
				.Be(5);

		[Fact]
		public void SetNoneWhenNullableOptional()
			=> new OptionalNullableValueModel()
				.Do(o => o.Value = Optional.Set(Option.None<int>()))
				.Value
				.AssertSet()
				.AssertNone();

		[Fact]
		public void UnsetWhenNullableOptional()
			=> new OptionalNullableValueModel()
				.Value
				.AssertUnset();

		[GenerateModel(DefaultPropertyAccessors = PropertyAccessors.GetAndSet)]
		public partial class DefaultedValueModelDefinition
		{
			public Property<int> Value => Data.Value<int>().Defaulted(2);
		}

		[Fact]
		public void SetWhenDefaulted()
			=> new DefaultedValueModel()
				.Do(o => o.Value = 5)
				.Value
				.Should()
				.Be(5);

		[Fact]
		public void UnsetWhenDefaulted()
			=> new DefaultedValueModel()
				.Value
				.Should()
				.Be(2);

		[GenerateModel(DefaultPropertyAccessors = PropertyAccessors.GetAndSet)]
		public partial class DefaultedNullableValueModelDefinition
		{
			public Property<Option<int>> Value => Data.Value<int>(o => o.Nullable()).Defaulted(Option.Some(2));
		}

		[Fact]
		public void SetSomeWhenNullableDefaulted()
			=> new DefaultedNullableValueModel()
				.Do(o => o.Value = Option.Some(5))
				.Value
				.AssertSome()
				.Should()
				.Be(5);

		[Fact]
		public void SetNoneWhenNullableDefaulted()
			=> new DefaultedNullableValueModel()
				.Do(o => o.Value = Option.None<int>())
				.Value
				.AssertNone();

		[Fact]
		public void UnsetWhenNullableDefaulted()
			=> new DefaultedNullableValueModel()
				.Value
				.AssertSome()
				.Should()
				.Be(2);

		public class ValueValidator : IValidator<int>
		{
			public Result<Unit, ValidationError[]> Validate(int value)
				=> Result.Create(value >= 0, Unit.Value, () => new[] { new ValidationError("Value invalid.") });
		}

		[GenerateModel(DefaultPropertyAccessors = PropertyAccessors.GetAndSet)]
		public partial class ValueWithValidatorModelDefinition
		{
			public Property<int> Value { get; } = Data.Value<int>().Required().WithValidator(new ValueValidator());
		}

		[Fact]
		public void ValidValueWithValidator()
			=> new ValueWithValidatorModel()
				.Do(o => o.Value = 5)
				.Value
				.Should()
				.Be(5);

		[Fact]
		public void InvalidValueWithValidator()
			=> new ValueWithValidatorModel()
				.Do(o => o.Value = -5)
				.Throws(default(DataInvalidException), o => o.Value);

		[GenerateModel(DefaultPropertyAccessors = PropertyAccessors.GetAndSet)]
		public partial class NullableValueWithValidatorModelDefinition
		{
			public Property<Option<int>> Value { get; }
			
			public NullableValueWithValidatorModelDefinition()
				=> Value = Data.Value<int>(o => o.Nullable()).Required().WithValidator(new ValueValidator());
		}

		[Fact]
		public void ValidNullableValueWithValidator()
			=> new NullableValueWithValidatorModel()
				.Do(o => o.Value = Option.Some(5))
				.Value
				.AssertSome()
				.Should()
				.Be(5);

		[Fact]
		public void InvalidNullableValueWithValidator()
			=> new NullableValueWithValidatorModel()
				.Do(o => o.Value = Option.Some(-5))
				.Throws(default(DataInvalidException), o => o.Value);

		[Fact]
		public void NoneNullableValueWithValidator()
			=> new NullableValueWithValidatorModel()
				.Do(o => o.Value = Option.None<int>())
				.Value
				.AssertNone();
	}
}
