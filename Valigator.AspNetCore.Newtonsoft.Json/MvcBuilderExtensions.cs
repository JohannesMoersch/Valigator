﻿using Microsoft.AspNetCore.Mvc;
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
using Valigator.Core;

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
		public static IMvcBuilder AddValigatorJsonExceptionFilter(this IMvcBuilder builder, Func<ValigatorSerializationException, IActionResult> errorCreater)
			=> builder
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
	}
}
