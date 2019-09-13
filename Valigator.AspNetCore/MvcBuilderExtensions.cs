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
			=> builder
				.AddMvcOptions(options =>
				{
					options.Filters.Add(new ValigatorActionFilter(inputErrorCreater));
					options.Filters.Add(new ValigatorResultFilter(resultErrorCreator));
				})
				.AddJsonOptions(options =>
				{
					options.SerializerSettings.Converters.Add(new ValigatorConverter(options.SerializerSettings));
					options.SerializerSettings.ContractResolver = new FancyContractResolver();
				});

		private class FancyContractResolver : DefaultContractResolver
		{
			public override JsonContract ResolveContract(Type type)
			{
				var result = base.ResolveContract(type);

				result.OnErrorCallbacks.Add(Fancy);

				return result;
			}

			private void Fancy(object o, StreamingContext context, ErrorContext errorContext)
			{
				errorContext.Handled = false;
			}
		}
	}
}
