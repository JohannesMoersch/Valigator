using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Valigator.AspNetCore.Newtonsoft.Json
{
	public static class MvcNewtonsoftJsonOptionsExtensions
	{
#if NETCOREAPP3_0
		public static void AddValigatorJsonExceptionHandler(this MvcNewtonsoftJsonOptions options)
			=> options.SerializerSettings.Error += (obj, args) =>
			{
				if (args.ErrorContext.Error is JsonSerializationException)
				{
					args.ErrorContext.Handled = true;
					throw new ValigatorJsonException(args.ErrorContext);
				}
			};
#endif
	}
}
