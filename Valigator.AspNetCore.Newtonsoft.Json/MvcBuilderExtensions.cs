using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Valigator.AspNetCore;
using Valigator.Core.ValueDescriptors;
using Valigator.Newtonsoft.Json;

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
		public static IMvcBuilder AddValigator(this IMvcBuilder builder, Func<AspNetCore.ModelError[], IActionResult> inputErrorCreater, Func<ValidationError[], IActionResult> resultErrorCreator)
		{
			builder
				.Services
#if NETCOREAPP3_0
				.AddSingleton<IObjectModelValidator, NullObjectModelValidator>() //Disables ASP.NET Core validation because it skips over the ValigatorFilter and, as a result, the AddValigator Funcs will not be called.
#endif
				.AddSingleton<IModelBinderFactory, Factory>();

			return builder
				.AddMvcOptions(options =>
				{
					options.Filters.Add(new ValigatorActionFilter(inputErrorCreater));
					options.Filters.Add(new ValigatorResultFilter(resultErrorCreator));
				})
#if NETCOREAPP3_0
				.AddNewtonsoftJson(o => o.SerializerSettings.Converters.Add(new ValigatorConverter()))
				.ConfigureApiBehaviorOptions(opt => opt.InvalidModelStateResponseFactory = arg => CreateInvalidModelStateResponse(arg, inputErrorCreater));
#else
				.AddJsonOptions(o => o.SerializerSettings.Converters.Add(new ValigatorConverter()));
#endif
		}

		private static IActionResult CreateInvalidModelStateResponse(ActionContext arg, Func<AspNetCore.ModelError[], IActionResult> resultErrorCreator)
			=> resultErrorCreator.Invoke(GetModelErrors(arg).ToArray());

		private static IEnumerable<AspNetCore.ModelError> GetModelErrors(ActionContext arg)
			=> arg.ModelState.Select(kvp => new AspNetCore.ModelError(kvp.Key, ModelSource.Body, new ValidationError(kvp.Value.AttemptedValue, new MappingDescriptor(typeof(int), typeof(double)))));

		private class NullObjectModelValidator : IObjectModelValidator
		{
			public void Validate(ActionContext actionContext, ValidationStateDictionary validationState, string prefix, object model) { }
		}
	}
}
