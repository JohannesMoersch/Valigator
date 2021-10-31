using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valigator.Text.Json;

namespace Valigator.AspNetCore
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddValigator(this IServiceCollection services)
		{
			services
				.AddMvcCore()
				.AddJsonOptions(o =>
				{
					o.JsonSerializerOptions.Converters.Add(new OptionalConverterFactory());
					o.JsonSerializerOptions.Converters.Add(new OptionConverterFactory());
					o.JsonSerializerOptions.Converters.Add(new ModelConverterFactory());
				});

			return services;
		}
	}
}
