using System;
using Valigator.Text.Json;

namespace Valigator
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class ValigatorModelAttribute : Attribute
	{
		public ValigatorModelConstructionBehaviour ModelConstructionBehaviour { get; set; }
	}
}
