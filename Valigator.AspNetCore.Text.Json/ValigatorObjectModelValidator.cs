using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Valigator
{
#if NETCOREAPP3_0
	public static partial class MvcBuilderExtensions
	{
		internal class ValigatorObjectModelValidator : IObjectModelValidator
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
	}
#endif
}
