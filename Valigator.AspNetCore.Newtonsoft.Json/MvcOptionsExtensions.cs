using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Valigator.AspNetCore.Newtonsoft.Json
{
	public static class MvcOptionsExtensions
	{
		public static void AddValigatorJsonExceptionHandler(this MvcOptions options, Func<ErrorContext, IActionResult> errorCreator)
			=> options.Filters.Add(new ValigatorJsonExceptionFilter(errorCreator));
	}
}
