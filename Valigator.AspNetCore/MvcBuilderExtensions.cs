using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Valigator.AspNetCore;
using Valigator.Newtonsoft.Json;

namespace Valigator
{
	public static class MvcBuilderExtensions
	{
		public static IMvcBuilder AddValigator(this IMvcBuilder builder)
			=> builder
				.AddMvcOptions(options => options.Filters.Add(new ValigatorFilter()))
				.AddJsonOptions(options => options.SerializerSettings.Converters.Add(new ValigatorConverter()));
	}
}
