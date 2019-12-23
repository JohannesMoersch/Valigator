using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using Valigator.AspNetCore;
using Valigator.Newtonsoft.Json;

namespace Valigator
{
	public static class MvcBuilderExtensions
	{
		public static IMvcBuilder AddValigator(this IMvcBuilder builder, Func<ModelError[], IActionResult> inputErrorCreater, Func<ValidationError[], IActionResult> resultErrorCreator)
		{
			var newBuilder = builder
				.AddMvcOptions(options =>
				{
					options.Filters.Add(new ValigatorActionFilter(inputErrorCreater));
					options.Filters.Add(new ValigatorResultFilter(resultErrorCreator));
				});
#if NETCOREAPP3_1
			newBuilder = builder
				.AddNewtonsoftJson(options =>
				{
					options.SerializerSettings.Converters.Add(new ValigatorConverter(options.SerializerSettings));
				});
#elif NETSTANDARD2_0
			newBuilder = builder
				.AddJsonOptions(options =>
				{
					options.SerializerSettings.Converters.Add(new ValigatorConverter(options.SerializerSettings));
				});
#else
#error unknown target framework
#endif
			return newBuilder;
		}
	}
}
