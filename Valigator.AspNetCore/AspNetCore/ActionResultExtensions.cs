using System;
using Microsoft.AspNetCore.Mvc;

namespace Valigator.AspNetCore
{
	public static class ActionResultExtensions
	{
		public static IActionResult GetVerifiedActionResult(this IActionResult result, Func<ValidationError[], IActionResult> resultErrorCreator)
		{
			object toValidate = null;
			if (result is ObjectResult objectResult && objectResult.Value != null)
				toValidate = objectResult.Value;
			else if (result is ViewResult viewResult)
				toValidate = viewResult.Model;
			else if (result is ViewComponentResult viewComponentResult)
				toValidate = viewComponentResult.Model;
			else if (result is PartialViewResult partialViewResult)
				toValidate = partialViewResult.Model;
			else if (result is JsonResult jsonResult)
				toValidate = jsonResult.Value;

			if (toValidate != null)
			{
				// Perform validation
				return Model
					.Verify(toValidate)
					.Match(_ => result, errors => resultErrorCreator?.Invoke(errors)
				);
			}
			return result;
		}
	}
}
