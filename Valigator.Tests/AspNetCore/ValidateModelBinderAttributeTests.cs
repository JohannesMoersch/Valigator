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
		private const int _invalidDespiteBeingInRange = 4;

		public class TestMappedValidateModelBinderAttribute : ValidateModelBinderAttribute
		{
			public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
				=> Task.FromResult(
						BindResult.Create(
							GetValue(bindingContext)
							.Match(
								s => s.Match(i => GetData().WithUncheckedValue(i), () => GetData().WithNull()),
								() => GetData().WithErrors(new[] { MappingError.Create("Not an Int", typeof(string), typeof(int)) })
							)
						)
					);

			private Data<int> GetData() => Data
								.Required<int>()
								.MappedFrom<string>(int.Parse, str => str.NotEmpty())
								.InRange(greaterThan: -5, lessThan: 10)
								.Assert("Inner Error1", i => i != _invalidDespiteBeingInRange);


			private static Option<Option<int>> GetValue(ModelBindingContext bindingContext)
				=> ConvertToInt(bindingContext.ValueProvider.GetValue(bindingContext.FieldName).FirstValue);

			private static Option<Option<int>> ConvertToInt(string arg)
				=> Int32.TryParse(arg, out var i) ? Option.Some(Option.Some(i)) : Option.Create(String.IsNullOrWhiteSpace(arg), () => Option.None<int>());
		}

		public class TestValidateModelBinderAttribute : ValidateModelBinderAttribute
		{
			public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
				=> Task.FromResult(
						BindResult.Create(
							GetValue(bindingContext)
							.Match(
								s => GetData().WithValue(s.Match(_ => _, () => (int?)null)),
								() => GetData().WithErrors(new[] { MappingError.Create("Not an Int", typeof(string), typeof(int)) })
							)
						)
					);

			private Data<int> GetData() => Data
								.Required<int>()
								.InRange(greaterThan: -5, lessThan: 10)
								.Assert("Inner Error1", i => i != _invalidDespiteBeingInRange);



			private static Option<Option<int>> GetValue(ModelBindingContext bindingContext)
				=> ConvertToInt(bindingContext.ValueProvider.GetValue(bindingContext.FieldName).FirstValue);

			private static Option<Option<int>> ConvertToInt(string arg)
				=> Int32.TryParse(arg, out var i) ? Option.Some(Option.Some(i)) : Option.Create(String.IsNullOrWhiteSpace(arg), () => Option.None<int>());
		}

		public class RequiredInt
		{
			public class Unmapped
			{
				[Theory]
				[InlineData("4", "Inner Error1")]
				[InlineData("-4", null)]
				[InlineData("9", null)]
				[InlineData("10", "RangeValidator_Int32")]
				[InlineData("11", "RangeValidator_Int32")]
				[InlineData("-5", "RangeValidator_Int32")]
				[InlineData("-6", "RangeValidator_Int32")]
				[InlineData("z", "Not an Int")]
				[InlineData("", "Value cannot be null.")]
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

			public class Mapped
			{
				[Theory]
				[InlineData("4", "Inner Error1")]
				[InlineData("-4", null)]
				[InlineData("9", null)]
				[InlineData("10", "RangeValidator_Int32")]
				[InlineData("11", "RangeValidator_Int32")]
				[InlineData("-5", "RangeValidator_Int32")]
				[InlineData("-6", "RangeValidator_Int32")]
				[InlineData("z", "Not an Int")]
				[InlineData("", "Value cannot be null.")]
				[InlineData(null, "Value cannot be null.")]
				public async Task ProducesError(string value, string errorMessage)
				{
					var context = new TestModelBindingContext(value, "theName");
					await new TestMappedValidateModelBinderAttribute().BindModelAsync(context);
					var errors = context.ModelState.SelectMany(modelState => modelState.Value.Errors.SelectMany(ex => (ex.Exception as ValigatorModelStateException).ValidationErrors.Select(error => error.Message))).ToArray();
					if (errorMessage == null)
						errors.Should().HaveCount(0);
					else
						errors.Should().BeEquivalentTo(new[] { errorMessage });
				}
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
