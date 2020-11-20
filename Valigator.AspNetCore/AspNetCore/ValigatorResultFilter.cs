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
			=> context.Result = context.Result.GetVerifiedActionResult(_resultErrorCreator);

		public void OnResultExecuted(ResultExecutedContext context)
		{
		}
	}
}
