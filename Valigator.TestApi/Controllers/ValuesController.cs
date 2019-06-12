using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Functional;
using Microsoft.AspNetCore.Mvc;
using Valigator;

namespace Valigator.TestApi.Controllers
{
	public class Model
	{
		public Data<Option<int>> One { get; set; } = Data.Defaulted<int>(-1).Nullable().Not(o => o.InRange(greaterThanOrEqualTo: 0, lessThanOrEqualTo: 2));

		public Data<Option<int[]>> Two { get; set; } = Data.Collection<int>(f => f.Not(o => o.GreaterThan(10))).DefaultedToEmpty().Nullable().Not(o => o.ItemCount(maximumItems: 10)).Not(o => o.Unique()).Assert("", _ => true);

		public Data<Stuff[]> Three { get; set; } = Data.Collection<Stuff>().Defaulted(() => new[] { new Stuff(), new Stuff() });

		public Data<DateTime> Test { get; set; } = Data.Required<DateTime>().InRange(DateTime.Now);
	}

	public class Stuff
	{
		public Data<int> A { get; set; } = Data.Defaulted<int>(5).LessThan(0);
	}

	public class Test : ValidateAttribute, ValidateAttribute.IValidateType<int>
	{
		public Data<int> GetData() => throw new NotImplementedException();
	}

	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			return "value";
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody]Model value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
