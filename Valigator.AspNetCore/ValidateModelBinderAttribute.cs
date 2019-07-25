using System;
using System.Threading.Tasks;
using Functional;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Valigator.Core;

namespace Valigator
{
	public abstract class ValidateModelBinderAttribute : Attribute, IModelNameProvider, IBinderTypeProviderMetadata, IBindingSourceMetadata, IModelBinder, IVerifiable, IDescriptor
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
					Result.Failure<object, ValidationError[]>
				)
				.Match(
					value => Verify(value.GetType(), value),
					Result.Failure<object, ValidationError[]>
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
						var name = bindingContext.BinderModelName ?? bindingContext.ModelMetadata?.ParameterName ?? bindingContext.ModelMetadata?.PropertyName ?? bindingContext?.ModelMetadata?.DisplayName ?? String.Empty;
						bindingContext.ModelState.TryAddModelException("ValigatorModelError", new ValigatorModelStateException(name, bindingContext.BindingSource, f));
						bindingContext.Result = ModelBindingResult.Failed();
						return Unit.Value;
					}
				);
		}

		public abstract Task<Result<object, ValidationError[]>> BindModel(ModelBindingContext bindingContext);
		public DataDescriptor GetDescriptor(Type type) => this.GetDataDescriptor(type);
		public Result<object, ValidationError[]> Verify(Type type, object value) => this.VerifyObject(type, value);
		public Result<object, ValidationError[]> Verify(Type type) => this.VerifyObject(type);
	}
}
