using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Threading.Tasks;
using Valigator.Core;

namespace Valigator.AspNetCore.Newtonsoft.Json
{
	public class ValigatorJsonExceptionFilter : ExceptionFilterAttribute
	{
		private readonly Func<ValigatorSerializationException, IActionResult> _errorCreator;

		public ValigatorJsonExceptionFilter(Func<ValigatorSerializationException, IActionResult> errorCreator)
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
			if (context.Exception is ValigatorSerializationException valigatorJsonException)
				context.Result = _errorCreator.Invoke(valigatorJsonException);
		}
	}
}
