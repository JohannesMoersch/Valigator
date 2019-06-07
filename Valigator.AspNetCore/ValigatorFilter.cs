using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Microsoft.AspNetCore.Mvc.Filters;
using Valigator.Core;

namespace Valigator.AspNetCore
{
	public class ValigatorFilter : IActionFilter, IOrderedFilter
	{
		public int Order => -2500;

		public void OnActionExecuted(ActionExecutedContext context)
		{
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			foreach (var kvp in context.ActionArguments)
			{
				Model
					.Verify(kvp.Value)
					.Match
					(
						_ => _,
						errors =>
						{
							context.ModelState.AddModelError(kvp.Key, String.Join(", ", errors.Select(e => e.Message)));

							return Unit.Value;
						}
					);
			}
		}
	}
}
