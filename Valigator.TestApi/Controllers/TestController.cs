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
		public Data<Option<string>> GetData() => Data.Defaulted("Default").Nullable();

		public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
			=> Task
				.FromResult
				(
					BindResult.Create(
						GetData().WithValue(Option.FromNullable(bindingContext
						.HttpContext
						.Request
						.Headers
						.FirstOrDefault(s => s.Key.ToLower() == "testheader")
						.Value
						.FirstOrDefault()))
					)
				);
	}
}
