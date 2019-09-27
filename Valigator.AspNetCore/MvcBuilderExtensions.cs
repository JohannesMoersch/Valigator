using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Valigator.AspNetCore;
using Valigator.Newtonsoft.Json;
using ModelError = Valigator.AspNetCore.ModelError;

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
				  })
				  .AddNewtonsoftJson(options =>
				  {
					  options.SerializerSettings.Converters.Add(new ValigatorConverter(options.SerializerSettings));
				  });

			var provider = newBuilder.Services.BuildServiceProvider();
			var wrapped = provider.GetRequiredService<IObjectModelValidator>();
			newBuilder.Services.Remove(newBuilder.Services.FirstOrDefault(descriptor => descriptor.ServiceType == typeof(IObjectModelValidator)));
			newBuilder.Services.TryAddSingleton<IObjectModelValidator>(new ValigatorObjectModelValidator(wrapped));

			return newBuilder;
		}

		public class ValigatorObjectModelValidator : IObjectModelValidator
		{
			private readonly IObjectModelValidator _validator;

			public ValigatorObjectModelValidator(IObjectModelValidator validator)
			{
				_validator = validator ?? throw new ArgumentNullException(nameof(validator));
			}

			public void Validate(ActionContext actionContext, ValidationStateDictionary validationState, string prefix, object model)
			{
				if (!ContainsValigatorData(model))
					_validator.Validate(actionContext, validationState, prefix, model);
			}

			private static bool ContainsValigatorData(object obj)
				=> obj.GetType().GetProperties().Any(property => property.PropertyType.IsConstructedGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Data<>));
		}
	}
}
