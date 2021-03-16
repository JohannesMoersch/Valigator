using Functional;
using System;
using System.Collections.Generic;
using Xunit;

namespace Valigator.Models.Generator.Tests
{
	[GenerateModel]
	public partial class OtherDefinition
	{
		public Property<int> A => Data.Value<int>().Required();
	}

	public class ModeDefinitionPropertyExtensionTests
	{
		public partial class TestModel : IModel
		{
			public partial class Definition : ModelDefinition<TestModelView>
			{
				public Property<int> A { get; } = Data.Value<int>().Defaulted(5);

				public Property<IReadOnlyList<int>> B { get; } = Data.Collection<int>().Required();
			}

			static TestModel()
			{
				ModelDefinition = new Definition();
				_a_Property = ModelDefinition.A;
				_b_Property = ModelDefinition.B;
			}

			public static Definition ModelDefinition { get; }

			private ModelErrorDictionary _errorDictionary = new ModelErrorDictionary();

			private ModelState _modelState = ModelState.Unset;

			private static ModelDefinition<TestModelView>.Property<int> _a_Property;
			private ModelPropertyState _a_State;
			private int _a;
			public int A
			{
				get => Get(nameof(A), _a, _a_State);
				set => Set(value, ref _a, ref _a_State);
			}

			private static ModelDefinition<TestModelView>.Property<IReadOnlyList<int>> _b_Property;
			private ModelPropertyState _b_State;
			private IReadOnlyList<int> _b;
			public IReadOnlyList<int> B
			{
				get => Get(nameof(B), _b, _b_State);
				set => Set(value, ref _b, ref _b_State);
			}

			private TValue Get<TValue>(string propertyName, TValue value, ModelPropertyState state)
			{
				if (_modelState == ModelState.Unset)
				{
					Coerce();
					Validate();
				}
				else if (_modelState == ModelState.Unvalidated)
					Validate();

				return state == ModelPropertyState.Valid
					? value
					: throw new DataInvalidException(_errorDictionary[propertyName]);
			}

			private void Set<TValue>(TValue newValue, ref TValue value, ref ModelPropertyState state)
			{
				value = newValue;
				state = ModelPropertyState.Unvalidated;
				
				if (_modelState == ModelState.Validated)
					_modelState = ModelState.Unvalidated;

				_errorDictionary.Clear();
			}

			private void Coerce()
			{
				if (_a_State == ModelPropertyState.Unset)
					_a_Property.CoerceUnset(nameof(A), ref _a, ref _a_State, ref _errorDictionary);

				if (_b_State == ModelPropertyState.Unset)
					_b_Property.CoerceUnset(nameof(B), ref _b, ref _b_State, ref _errorDictionary);

				_modelState = ModelState.Unvalidated;
			}

			private void Validate()
			{
				var view = new TestModelView(this);

				if (_a_State != ModelPropertyState.CoerceFailed)
					_a_Property.Validate(view, nameof(A), _a, ref _a_State, ref _errorDictionary);

				if (_b_State != ModelPropertyState.CoerceFailed)
					_b_Property.Validate(view, nameof(B), _b, ref _b_State, ref _errorDictionary);

				_modelState = ModelState.Validated;
			}

			public struct TestModelView
			{
				private TestModel _model;

				public TestModelView(TestModel model)
					=> _model = model;

				public int A => Get(_model._a);

				public Result<IReadOnlyList<int>, ModelPropertyNotSet> B => Get(_model._b, _model._b_State);

				private TValue Get<TValue>(TValue value)
				{
					if (_model._modelState == ModelState.Unset)
						_model.Coerce();

					return value;
				}

				private Result<TValue, ModelPropertyNotSet> Get<TValue>(TValue value, ModelPropertyState state)
				{
					if (_model._modelState == ModelState.Unset)
						_model.Coerce();

					return Result
						  .Create
						  (
							  state != ModelPropertyState.CoerceFailed,
							  value,
							  ModelPropertyNotSet.Value
						  );
				}
			}
		}

		[Fact]
		public void Test1()
		{
		}
	}
}
