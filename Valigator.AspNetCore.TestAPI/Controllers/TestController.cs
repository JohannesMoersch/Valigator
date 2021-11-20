using Functional;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valigator.AspNetCore.TestAPI.Controllers
{
	[ApiController]
	[Route("Test")]
	public class TestController : ControllerBase
	{
		[HttpGet]
		public TestModel Get()
			=> new TestModel
			(
				required: 10,
				requiredNullable: Option.Some(15),
				setOptional: Optional.Set(20),
				setOptionalNullable: Optional.Set(Option.Some(25)),
				unsetOptional: Optional.Unset<int>(),
				unsetOptionalNullable: Optional.Unset<Option<int>>(),
				defaulted: 30,
				defaultedNullable: Option.Some(35)
			);

		[HttpPost]
		public TestModel Post([FromBody] TestModel model)
			=> model;

		[HttpPost("Mutate")]
		public TestModel Mutate([FromBody] TestModel model)
			=> model
				with
				{
					Required = model.Required + 5,
					Defaulted = model.Defaulted + 5
				};
	}
}
