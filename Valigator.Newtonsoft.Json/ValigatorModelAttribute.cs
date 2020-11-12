using System;
using Valigator.Newtonsoft.Json;

namespace Valigator
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class ValigatorModelAttribute : Attribute
	{
		public ValigatorModelConstructionBehaviour ModelConstructionBehaviour { get; set; }
	}

	public static class ValigatorModelHelpers
	{
		public static ValigatorModel ToValigatorModel(this object obj)
			=> ValigatorModel.Create(obj);
	}
}
