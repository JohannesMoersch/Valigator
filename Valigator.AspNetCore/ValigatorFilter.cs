using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Valigator.Core;

namespace Valigator.AspNetCore
{
	public class ValigatorActionFilter : IActionFilter, IOrderedFilter
	{
		public int Order => -2500;

		private readonly Func<ValidationError[], IActionResult> _resultErrorCreator;

		public ValigatorActionFilter(Func<ValidationError[], IActionResult> resultErrorCreator)
			=> _resultErrorCreator = resultErrorCreator;

		public void OnActionExecuting(ActionExecutingContext context)
		{
			foreach (var parameter in context.ActionDescriptor.Parameters)
			{
			}

			foreach (var kvp in context.ActionArguments)
			{
				Model
					.Verify(kvp.Value)
					.Match(_ => _, errors =>
					{
						context.Result = _resultErrorCreator?.Invoke(errors);
						return Unit.Value;
					});
			}
		}

		public void OnActionExecuted(ActionExecutedContext context)
		{
		}
	}
}
