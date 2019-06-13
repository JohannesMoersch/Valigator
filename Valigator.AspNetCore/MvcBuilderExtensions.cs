using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
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
				.AddJsonOptions(options => options.SerializerSettings.Converters.Add(new ValigatorConverter()));
	}
}
