using System;
using System.Linq;
using System.Threading.Tasks;
using Functional;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Valigator.Core;

namespace Valigator
{
	public abstract class ValidateModelBinderAttribute : Attribute, IModelNameProvider, IBinderTypeProviderMetadata, IBindingSourceMetadata, IModelBinder, IVerifiable, IDescriptorProvider
	{
		public ValidateModelBinderAttribute()
		{
			BinderType = GetType();
		}

		/// <inheritdoc />
		public virtual string Name { get; set; }

		/// <inheritdoc />
		public Type BinderType { get; }

		/// <inheritdoc />
		public BindingSource BindingSource { get; }

		/// <inheritdoc />
		public async Task BindModelAsync(ModelBindingContext bindingContext)
		{
			(await BindModel(bindingContext))
				.Match(
					s => Result.Success<object, ValidationError[]>(s),
					f => Result.Failure<object, ValidationError[]>(f)
				)
				.Match(
					value => this.Verify(value.GetType(), value),
					f => Result.Failure<object, ValidationError[]>(f)
				)
				.Match(
					s =>
					{
						bindingContext.Model = Result.Success<object, ValidationError[]>(s);
						bindingContext.Result = ModelBindingResult.Success(s);
						return Unit.Value;
					},
					f =>
					{
						var parameter = bindingContext.ActionContext.ActionDescriptor.Parameters.FirstOrDefault(descriptor => descriptor.Name == bindingContext.ModelMetadata.ParameterName);
						bindingContext.ModelState.TryAddModelException("ValigatorModelError", new ValigatorModelStateException(parameter, f));
						bindingContext.Result = ModelBindingResult.Failed();
						return Unit.Value;
					}
				);
		}

		public abstract Task<Result<object, ValidationError[]>> BindModel(ModelBindingContext bindingContext);
	}
}
