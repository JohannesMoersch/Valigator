using Microsoft.AspNetCore.Mvc;
using System;
using Valigator.Text.Json;

namespace Valigator.AspNetCore.Text.Json
{
	public static class MvcOptionsExtensions
	{
		public static void AddValigatorJsonExceptionHandler(this MvcOptions options, Func<ValigatorJsonException, IActionResult> errorCreator)
			=> options.Filters.Add(new ValigatorJsonExceptionFilter(errorCreator));
	}
}
