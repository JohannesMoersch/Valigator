using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;
using Valigator.Text.Json;

namespace Valigator.AspNetCore.Text.Json
{
	public class ValigatorJsonExceptionFilter : ExceptionFilterAttribute
	{
		private readonly Func<ValigatorJsonException, IActionResult> _errorCreator;

		public ValigatorJsonExceptionFilter(Func<ValigatorJsonException, IActionResult> errorCreator)
		{
			_errorCreator = errorCreator;
		}

		public override Task OnExceptionAsync(ExceptionContext context)
		{
			OnException(context);
			return Task.CompletedTask;
		}

		public override void OnException(ExceptionContext context)
		{
			if (context.Exception is ValigatorJsonException valigatorJsonException)
				context.Result = _errorCreator.Invoke(valigatorJsonException);
		}
	}
}
