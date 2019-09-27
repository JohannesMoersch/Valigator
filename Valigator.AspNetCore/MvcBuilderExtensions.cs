using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Valigator.AspNetCore;
using Valigator.Newtonsoft.Json;

namespace Valigator
{
	public static class MvcBuilderExtensions
	{
		public static IMvcBuilder AddValigator(this IMvcBuilder builder, Func<ModelError[], IActionResult> inputErrorCreater, Func<ValidationError[], IActionResult> resultErrorCreator)
			=> builder
				.AddMvcOptions(options =>
				{
					options.Filters.Add(new ValigatorActionFilter(inputErrorCreater));
					options.Filters.Add(new ValigatorResultFilter(resultErrorCreator));
				})
				.AddJsonOptions(opts => opts.JsonSerializerOptions.Converters.Add(new ValigatorConverter(opts.JsonSerializerOptions)));
	}
}
