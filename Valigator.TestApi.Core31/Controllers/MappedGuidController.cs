extern alias NewtonsoftValigator;
extern alias SystemTextValigator;
using System;
using Functional;
using Microsoft.AspNetCore.Mvc;
using Valigator.Core.Extensions;
using Valigator.TestApi.Core31.MappedGuid;

namespace Valigator.TestApi.Controllers
{
	[Route("mappedGuid")]
	public class MappedGuidController : ControllerBase
	{
		[HttpPost("mappedGuid")]
		public JsonResult MappedGuidEndpoint([FromBody] MappedGuidCollection bodyValue)
			=> new JsonResult(true);

		[HttpPost("mappedGuidHeader")]
		public JsonResult MappedGuidHeaderEndpoint([MappedGuidHelpers.ModelBindings.Required.Header] Data<MappedGuid> mappedGuid)
			=> new JsonResult(true);
	}

	[NewtonsoftValigator::Valigator.ValigatorModel]
	[SystemTextValigator::Valigator.ValigatorModel]
	public class MappedGuidCollection
	{
		public Data<MappedGuidClass[]> Items { get; set; } = Data
			.Collection<MappedGuidClass>()
			.Required()
			.ItemCount(minimumItems: 1)
			.ElementsUnique(p => p.MappedGuid.TryGetValue().Match(Option.Some, _ => Option.None<MappedGuid>()), $"The {nameof(MappedGuidClass.MappedGuid)} must be unique for each element of {nameof(MappedGuid)}");
	}

	[NewtonsoftValigator::Valigator.ValigatorModel]
	[SystemTextValigator::Valigator.ValigatorModel]
	public class MappedGuidClass
	{
		private static readonly Data<Guid> _data = Data.Required<Guid>().NotEmpty();

		public Data<MappedGuid> MappedGuid { get; set; } = Data.Required<MappedGuid>().MappedFrom<Guid>(CreateMappedGuid, _ => _data);

		private static MappedGuid CreateMappedGuid(Guid guid)
				=> new MappedGuid(guid);
	}
}
