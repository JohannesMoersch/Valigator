using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Valigator.Text.Json;

namespace Valigator
{

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class ValigatorConverterAttribute : JsonConverterAttribute
	{
		public ValigatorObjectConstructionBehaviour ObjectConstructionBehaviour { get; set; }

		public ValigatorConverterAttribute()
			: base(typeof(ValigatorConverterFactory))
		{
		}
	}
}
