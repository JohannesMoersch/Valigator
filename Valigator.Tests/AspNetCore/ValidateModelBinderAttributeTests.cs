using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using Functional;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Routing;
using Valigator.AspNetCore;
using Xunit;

namespace Valigator.Tests.AspNetCore
{
	public class ValidateModelBinderAttributeTests
	{
		private const string _invalidDespiteBeingInRange = "4";

		public class TestNullableValidateModelBinderAttribute : ValidateModelBinderAttribute, IValidateType<Option<int>>
		{
			public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
				=> Result
					.TryAsync
					(
						() =>
						{
							var valueSet = bindingContext.ValueProvider.GetValue(bindingContext.FieldName);
							if (!valueSet.Any())
								return Task.FromResult(BindResult.CreateUnSet());

							var value = Option.FromNullable(valueSet.FirstOrDefault());
							var result = value
								.Select(s => int.Parse(s))
								.Match(v =>
									{
										if (v == int.Parse(_invalidDespiteBeingInRange))
											return BindResult.CreateFailed(new ValidationError("Inner Error1", null));
										return BindResult.CreateSet(Option.Some<object>(v));
									},
									() => BindResult.CreateSet(Option.None<object>())
								);
							return Task.FromResult(result);
						}
					)
					.Match(_ => _, ex => BindResult.CreateFailed(new ValidationError("Exception Error1", null)));


			public Data<Option<int>> GetData() => Data.Required<int>().Nullable().InRange(greaterThan: -5, lessThan: 10);
		}

		public class TestValidateModelBinderAttribute : ValidateModelBinderAttribute, IValidateType<int>
		{
			public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
				=> Result
					.TryAsync
					(
						() =>
						{
							var valueSet = bindingContext.ValueProvider.GetValue(bindingContext.FieldName);
							if (!valueSet.Any())
								return Task.FromResult(BindResult.CreateUnSet());

							var value = Option.FromNullable(valueSet.FirstOrDefault());
							var result = value
								.Select(s => int.Parse(s))
								.Match(v =>
									{
										if (v == int.Parse(_invalidDespiteBeingInRange))
											return BindResult.CreateFailed(new ValidationError("Inner Error1", null));
										return BindResult.CreateSet(Option.Some((object)v));
									},
									() => BindResult.CreateSet(Option.None<object>())
								);
							return Task.FromResult(result);
						}
					)
					.Match(_ => _, ex => BindResult.CreateFailed(new ValidationError("Exception Error1", null)));


			public Data<int> GetData() => Data.Required<int>().InRange(greaterThan: -5, lessThan: 10);
		}

		public class RequiredInt
		{

			[Fact]
			public void SucceedsAsserting()
				=> new TestValidateModelBinderAttribute()
					.Verify(0)
					.AssertSuccess();

			[Fact]
			public void ThrowsError()
				=> Assert.Throws<ValidateAttributeDoesNotSupportTypeException>(() => new TestValidateModelBinderAttribute().Verify(1.0f));

			[Fact]
			public void SucceedsGettingDescriptor()
			{
				var descriptor = new TestValidateModelBinderAttribute()
					.GetDescriptor(typeof(int));
			}

			[Theory]
			[InlineData(_invalidDespiteBeingInRange, "Inner Error1")]
			[InlineData("-4", null)]
			[InlineData("9", null)]
			[InlineData("10", "RangeValidator_Int32")]
			[InlineData("11", "RangeValidator_Int32")]
			[InlineData("-5", "RangeValidator_Int32")]
			[InlineData("-6", "RangeValidator_Int32")]
			[InlineData("z", "Exception Error1")]
			[InlineData("", "Exception Error1")]
			[InlineData(null, "Value cannot be null.")]
			public async Task ProducesError(string value, string errorMessage)
			{
				var context = new TestModelBindingContext(value, "theName");
				await new TestValidateModelBinderAttribute().BindModelAsync(context);
				var errors = context.ModelState.SelectMany(modelState => modelState.Value.Errors.SelectMany(ex => (ex.Exception as ValigatorModelStateException).ValidationErrors.Select(error => error.Message))).ToArray();
				if (errorMessage == null)
					errors.Should().HaveCount(0);
				else
					errors.Should().BeEquivalentTo(new[] { errorMessage });
			}
		}

		public class OptionalInt
		{

			[Fact]
			public void SucceedsAsserting()
				=> new TestNullableValidateModelBinderAttribute()
					.Verify(null)
					.AssertSuccess();

			[Fact]
			public void ThrowsError()
				=> Assert.Throws<ValidateAttributeDoesNotSupportTypeException>(() => new TestNullableValidateModelBinderAttribute().Verify(1.0f));

			[Fact]
			public void SucceedsGettingDescriptor()
			{
				var descriptor = new TestNullableValidateModelBinderAttribute()
					.GetDescriptor(typeof(Option<int>));
			}

			[Theory]
			[InlineData(_invalidDespiteBeingInRange, "Inner Error1")]
			[InlineData("-4", null)]
			[InlineData("9", null)]
			[InlineData("10", "RangeValidator_Int32")]
			[InlineData("11", "RangeValidator_Int32")]
			[InlineData("-5", "RangeValidator_Int32")]
			[InlineData("-6", "RangeValidator_Int32")]
			[InlineData("z", "Exception Error1")]
			[InlineData("", "Exception Error1")]
			[InlineData(null, null)]
			public async Task ProducesError(string value, string errorMessage)
			{
				var context = new TestModelBindingContext(value, "theName");
				await new TestNullableValidateModelBinderAttribute().BindModelAsync(context);
				var errors = context.ModelState.SelectMany(modelState => modelState.Value.Errors.SelectMany(ex => (ex.Exception as ValigatorModelStateException).ValidationErrors.Select(error => error.Message))).ToArray();
				if (errorMessage == null)
					errors.Should().HaveCount(0);
				else
					errors.Should().BeEquivalentTo(new[] { errorMessage });
			}
		}

		private class TestParameterInfo : ParameterInfo
		{
			public TestParameterInfo(string name)
				=> Name = name;

			public override string Name { get; }
		}

		private class TestModelBindingContext : ModelBindingContext
		{
			private IList<ParameterDescriptor> _parameterDescriptors = new List<ParameterDescriptor>(new[] { new ParameterDescriptor() { Name = "theName" } });

			public TestModelBindingContext(string value, string parameterName)
			{
				ValueProvider = CreateValueProvider(value);

				var httpContext = A.Dummy<HttpContext>();
				var actionDescriptor = new ActionDescriptor() { BoundProperties = _parameterDescriptors, Parameters = _parameterDescriptors };
				ActionContext = new ActionContext(httpContext, new RouteData(), actionDescriptor);

				var parameter = GetType().GetMethod(nameof(MethodForParameterInfo), BindingFlags.Instance | BindingFlags.NonPublic).GetParameters().FirstOrDefault(p => p.Name == parameterName);
				ModelMetadata = new EmptyModelMetadataProvider().GetMetadataForParameter(parameter);
			}

			private void MethodForParameterInfo(int theName, Option<int> theNameOptional)
			{ }

			public override ActionContext ActionContext { get; set; }
			public override string BinderModelName { get; set; }
			public override BindingSource BindingSource { get; set; }
			public override string FieldName { get; set; }
			public override bool IsTopLevelObject { get; set; }
			public override object Model { get; set; }
			public override ModelMetadata ModelMetadata { get; set; }
			public override string ModelName { get; set; }
			public override ModelStateDictionary ModelState { get; set; } = new ModelStateDictionary();
			public override Func<ModelMetadata, bool> PropertyFilter { get; set; }
			public override ValidationStateDictionary ValidationState { get; set; }
			public override IValueProvider ValueProvider { get; set; }

			private static IValueProvider CreateValueProvider(string value)
			{
				var result = A.Fake<IValueProvider>();
				A.CallTo(() => result.GetValue(A<string>.Ignored)).Returns(new ValueProviderResult(new Microsoft.Extensions.Primitives.StringValues(new string[] { value })));
				return result;
			}

			public override ModelBindingResult Result { get; set; }

			public override NestedScope EnterNestedScope(ModelMetadata modelMetadata, string fieldName, string modelName, object model) => throw new NotImplementedException();
			public override NestedScope EnterNestedScope() => throw new NotImplementedException();
			protected override void ExitNestedScope() => throw new NotImplementedException();
		}
	}
}
