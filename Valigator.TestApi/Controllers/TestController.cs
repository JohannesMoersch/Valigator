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

	public class DefaultedModelBinder : ValidateModelBinderAttribute, IValidateType<Option<string>>
	{
		public Data<Option<string>> GetData() => Data.Defaulted("Default").Nullable();

		public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
			=> Task
				.FromResult
				(
					bindingContext
					.HttpContext
					.Request
					.Headers
					.TryFirst(s => s.Key.ToLower() == "testheader")
					.Match
					(
						kvp => BindResult
							.CreateSet
							(
								Option
								.FromNullable(kvp.Value.FirstOrDefault())
								.Where(s => !String.IsNullOrWhiteSpace(s))
								.Select(s => (object)s)
							),
						() => BindResult.CreateUnSet()
					)
				);
	}
}
