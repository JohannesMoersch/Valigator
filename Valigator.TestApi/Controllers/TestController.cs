using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Functional;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Valigator.TestApi.Controllers
{
	[Route("test")]
	public class TestController : ControllerBase
	{
		[HttpGet("header")]
		public JsonResult Header([DefaultedModelBinder]Option<string> header)
			=> new JsonResult(header.Match(_ => _, () => null));
	}

	public class DefaultedModelBinder : ValidateModelBinderAttribute
	{
		private readonly Data<Option<string>> _data = Data.Defaulted("Default").Nullable();
		private readonly Data<string> _d = Data.Defaulted("Default");

		public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
			=> Task
				.FromResult
				(
					BindResult.Create(
						Option.FromNullable(bindingContext
						.HttpContext
						.Request
						.Headers
						.FirstOrDefault(s => s.Key.ToLower() == "testheader")
						.Value
						.FirstOrDefault())
						.Match(s => _data.WithValue(Option.Some(s)), () => _data)
					)
				);
	}
}
