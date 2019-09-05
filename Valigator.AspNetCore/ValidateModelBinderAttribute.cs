using System;
using System.Linq;
using System.Threading.Tasks;
using Functional;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Valigator.AspNetCore;
using Valigator.Core;

namespace Valigator
{
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = true)]
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
		public virtual BindingSource BindingSource { get; }

		/// <inheritdoc />
		public async Task BindModelAsync(ModelBindingContext bindingContext)
		{
			(await BindModel(bindingContext))
				.Match(
					set => this.Verify(set),
					() => this.Verify(),
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
						GetParameterDescriptorForParameter(bindingContext)
							.Match(
								descriptor => Option.Some(descriptor), 
								() => GetParameterDescriptorForProperty(bindingContext)
							)
							.Match(
								parameter => 
								{
									bindingContext.ModelState.TryAddModelException("ValigatorModelError", new ValigatorModelStateException(parameter, f));
									return Unit.Value;
								},
								() => Unit.Value
							);
						
						bindingContext.Result = ModelBindingResult.Failed();
						return Unit.Value;
					}
				);
		}

		private Option<ParameterDescriptor> GetParameterDescriptorForProperty(ModelBindingContext bindingContext)
		{
			if (bindingContext.ModelMetadata.PropertyName == null)
				return Option.None<ParameterDescriptor>();

			var value = bindingContext.ActionContext.ActionDescriptor.BoundProperties.FirstOrDefault(descriptor => descriptor.Name == bindingContext.ModelMetadata.PropertyName);

			if (value == null)
				return Option.None<ParameterDescriptor>();

			return Option.Some(value);
		}

		private Option<ParameterDescriptor> GetParameterDescriptorForParameter(ModelBindingContext bindingContext)
		{
			if (bindingContext.ModelMetadata.ParameterName == null)
				return Option.None<ParameterDescriptor>();

			var value = bindingContext.ActionContext.ActionDescriptor.Parameters.FirstOrDefault(descriptor => descriptor.Name == bindingContext.ModelMetadata.ParameterName);

			if (value == null)
				return Option.None<ParameterDescriptor>();

			return Option.Some(value);
		}

		public abstract Task<BindResult> BindModel(ModelBindingContext bindingContext);
	}
}
