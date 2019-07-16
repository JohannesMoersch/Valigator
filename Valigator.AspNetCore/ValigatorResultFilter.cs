using System;
using System.Threading.Tasks;
using Functional;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Valigator.Core;

namespace Valigator.AspNetCore
{
	public class ValigatorResultFilter : IResultFilter, IOrderedFilter
	{
		public static int Order => 2500;

		int IOrderedFilter.Order => Order;

		private readonly Func<ValidationError[], IActionResult> _resultErrorCreator;

		public ValigatorResultFilter(Func<ValidationError[], IActionResult> resultErrorCreator) 
			=> _resultErrorCreator = resultErrorCreator;

		public void OnResultExecuting(ResultExecutingContext context)
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
				Model
					.Verify(toValidate)
					.Match(_ => _, errors =>
					{
						context.Result = _resultErrorCreator?.Invoke(errors);
						return Unit.Value;
					});
			}
		}

		public void OnResultExecuted(ResultExecutedContext context)
		{
		}
	}
}
