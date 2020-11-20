using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Threading.Tasks;

namespace Valigator.AspNetCore.Newtonsoft.Json
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
