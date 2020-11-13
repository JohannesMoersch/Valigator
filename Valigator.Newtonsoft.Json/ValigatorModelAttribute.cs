using System;
using Valigator.Newtonsoft.Json;

namespace Valigator
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class ValigatorModelAttribute : Attribute
	{
		public ValigatorModelConstructionBehaviour ModelConstructionBehaviour { get; set; }
	}
}
