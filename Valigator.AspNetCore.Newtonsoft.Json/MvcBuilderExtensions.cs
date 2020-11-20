using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Valigator.AspNetCore;
using Valigator.Newtonsoft.Json;
using Valigator.Core.Helpers;
using System.Reflection;
using System.Linq;
using Valigator.AspNetCore.Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Valigator
{
	public struct Wrapper : IModelBinder
	{
		private readonly IModelBinder _binder;

		public Wrapper(IModelBinder binder)
		{
			_binder = binder ?? throw new ArgumentNullException(nameof(binder));
		}

		public async Task BindModelAsync(ModelBindingContext bindingContext)
		{
			await _binder.BindModelAsync(bindingContext);

			if (bindingContext.Result.IsModelSet)
				Model.Verify(bindingContext.Result.Model);
		}
	}

	public class Factory : IModelBinderFactory
	{
		private readonly IModelBinderFactory _modelBinderFactory;

		public Factory(IModelMetadataProvider metadataProvider, IOptions<MvcOptions> options, IServiceProvider serviceProvider)
			=> _modelBinderFactory = new ModelBinderFactory(metadataProvider, options, serviceProvider);

		public IModelBinder CreateBinder(ModelBinderFactoryContext context)
			=> new Wrapper(_modelBinderFactory.CreateBinder(context));
	}

	public static class MvcBuilderExtensions
	{
		public static IMvcBuilder AddValigatorJsonExceptionFilter(this IMvcBuilder builder, Func<ErrorContext, IActionResult> errorCreater)
			=> builder
#if NETCOREAPP3_0
				.AddNewtonsoftJson(options => options.AddValigatorJsonExceptionHandler())
#endif
				.AddMvcOptions(options => options.AddValigatorJsonExceptionHandler(errorCreater));

		public static IMvcBuilder AddValigator(this IMvcBuilder builder, Func<AspNetCore.ModelError[], IActionResult> inputErrorCreater, Func<ValidationError[], IActionResult> resultErrorCreator)
		{
			builder
				.Services
#if NETCOREAPP3_0
				.AddSingleton<IObjectModelValidator, ValigatorObjectModelValidator>() //Disables ASP.NET Core validation because it skips over the ValigatorFilter and, as a result, the AddValigator Funcs will not be called.
#endif
				.AddSingleton<IModelBinderFactory, Factory>();

			return builder
				.AddMvcOptions(options =>
				{
					options.Filters.Add(new ValigatorActionFilter(inputErrorCreater));
					options.Filters.Add(new ValigatorResultFilter(resultErrorCreator));
				})
#if NETCOREAPP3_0
				.AddNewtonsoftJson(o => o.SerializerSettings.Converters.Add(new ValigatorConverter(o.SerializerSettings)));
#else
				.AddJsonOptions(o => o.SerializerSettings.Converters.Add(new ValigatorConverter(o.SerializerSettings)));
#endif
		}

#if NETCOREAPP3_0
		private class ValigatorObjectModelValidator : IObjectModelValidator
		{
			private readonly IObjectModelValidator _defaultObjectValidator;
			private static readonly IObjectModelValidator _nullObjectModelValidator = new NullObjectModelValidator();

			public ValigatorObjectModelValidator(
				IModelMetadataProvider modelMetadataProvider,
				IOptions<MvcOptions> options)
			{
				_defaultObjectValidator = new DefaultObjectValidator(modelMetadataProvider, options.Value.ModelValidatorProviders, options.Value);
			}
			public void Validate(ActionContext actionContext, ValidationStateDictionary validationState, string prefix, object model)
				=> (IsValigatorModel(model.GetType()) ? _nullObjectModelValidator : _defaultObjectValidator).Validate(actionContext, validationState, prefix, model);

			private bool IsValigatorModel(Type type)
				=> type.GetCustomAttributes().OfType<ValigatorModelAttribute>().Any();

			private class NullObjectModelValidator : IObjectModelValidator
			{
				public void Validate(ActionContext actionContext, ValidationStateDictionary validationState, string prefix, object model) { }
			}

			private class DefaultObjectValidator : ObjectModelValidator
			{
				private readonly MvcOptions _mvcOptions;

				public DefaultObjectValidator(
					IModelMetadataProvider modelMetadataProvider,
					IList<IModelValidatorProvider> validatorProviders,
					MvcOptions mvcOptions)
					: base(modelMetadataProvider, validatorProviders)
				{
					_mvcOptions = mvcOptions;
				}

				public override ValidationVisitor GetValidationVisitor(
					ActionContext actionContext,
					IModelValidatorProvider validatorProvider,
					ValidatorCache validatorCache,
					IModelMetadataProvider metadataProvider,
					ValidationStateDictionary validationState)
				{
					var visitor = new ValidationVisitor(
						actionContext,
						validatorProvider,
						validatorCache,
						metadataProvider,
						validationState)
					{
						MaxValidationDepth = _mvcOptions.MaxValidationDepth,
						ValidateComplexTypesIfChildValidationFails = _mvcOptions.ValidateComplexTypesIfChildValidationFails,
					};

					return visitor;
				}
			}
		}
#endif
	}
}
