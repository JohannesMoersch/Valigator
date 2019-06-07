using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Valigator.Core;

namespace Valigator.AspNetCore
{
	public class ValigatorResultFilter : IAsyncResultFilter
	{
		private readonly Func<ValidationError[], IActionResult> _resultErrorCreator;

		public ValigatorResultFilter(Func<ValidationError[], IActionResult> resultErrorCreator)
		{
			_resultErrorCreator = resultErrorCreator;
		}

		public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
		{
			object toValidate = null;
			if (context.Result is ObjectResult objectResult && objectResult.Value != null)
				toValidate = objectResult.Value;
			else if (context.Result is ViewResult viewResult)
				toValidate = viewResult.Model;
			else if (context.Result is ViewComponentResult viewComponentResult)
				toValidate = viewComponentResult.Model;
			else if (context.Result is PartialViewResult partialViewResult)
				toValidate = partialViewResult.Model;
			else if (context.Result is JsonResult jsonResult)
				toValidate = jsonResult.Value;

			if (toValidate != null)
			{
				// Perform validation
				await Model
					.Verify(toValidate)
					.Match(async _ => await next.Invoke(), errors =>
					{
						context.Result = _resultErrorCreator?.Invoke(errors);
						return Task.CompletedTask;
					});
			}
			else
				await next.Invoke();
		}
	}
}
