using System;
using System.Linq;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using Functional;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Valigator.AspNetCore;
using Xunit;

namespace Valigator.Tests.AspNetCore
{
	public class ValidateModelBinderAttributeTests
	{
		private const string _invalidDespiteBeingInRange = "4";

		public class TestValidateModelBinderAttribute : ValidateModelBinderAttribute, IValidateType<int>
		{
			public override async Task<Result<object, ValidationError[]>> BindModel(ModelBindingContext bindingContext)
				=> (await Result.TryAsync(
					() =>
					{
						var value = bindingContext?.ValueProvider?.GetValue(bindingContext.FieldName).TryFirst() ?? Option.None<string>();
						var result = value
							.Select(s => int.Parse(s))
							.Match(v =>
							{
								if (v == int.Parse(_invalidDespiteBeingInRange))
									return Result.Failure<object, ValidationError[]>(new[] { new ValidationError("Inner Error1", null) });
								return Result.Success<object, ValidationError[]>(v);
							},
							() => Result.Failure<object, ValidationError[]>(new[] { new ValidationError("Error1", null) }));
						return Task.FromResult(result);
					},
					ex => Result.Failure<object, ValidationError[]>(new[] { new ValidationError("Exception Error1", null) })
				))
				.Match(_ => _, f => f);


			public Data<int> GetData() => Data.Required<int>().InRange(greaterThan: -5, lessThan: 10);
		}

		[Fact]
		public void SucceedsAsserting()
			=> new TestValidateModelBinderAttribute()
				.Verify(typeof(int), 0)
				.AssertSuccess();

		[Fact]
		public void ThrowsError()
			=> Assert.Throws<ValidateAttributeDoesNotSupportTypeException>(() => new TestValidateModelBinderAttribute().Verify(typeof(float), 1.0f));

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
		[InlineData(null, "Error1")]
		public async Task ProducesError(string value, string errorMessage)
		{
			var context = new TestModelBindingContext(value);
			await new TestValidateModelBinderAttribute().BindModelAsync(context);
			var errors = context.ModelState.SelectMany(modelState => modelState.Value.Errors.SelectMany(ex => (ex.Exception as ValigatorModelStateException).ValidationErrors.Select(error => error.Message))).ToArray();
			if (string.IsNullOrEmpty(errorMessage))
				errors.Should().HaveCount(0);
			else
				errors.Should().BeEquivalentTo(new[] { errorMessage });
		}

		private class TestModelBindingContext : ModelBindingContext
		{
			public TestModelBindingContext(string value)
			{
				ValueProvider = CreateValueProvider(value);
			}

			public override ActionContext ActionContext { get; set; }
			public override string BinderModelName { get; set; } = "TheName";
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
				A.CallTo(() => result.GetValue(A<string>.Ignored)).Returns(new ValueProviderResult(new Microsoft.Extensions.Primitives.StringValues(value)));
				return result;
			}

			public override ModelBindingResult Result { get; set; }

			public override NestedScope EnterNestedScope(ModelMetadata modelMetadata, string fieldName, string modelName, object model) => throw new NotImplementedException();
			public override NestedScope EnterNestedScope() => throw new NotImplementedException();
			protected override void ExitNestedScope() => throw new NotImplementedException();
		}
	}
}
