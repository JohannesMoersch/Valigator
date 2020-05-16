using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Valigator.Newtonsoft.Json;

namespace Valigator.Newtonsoft.Json.Tests
{
	public static class JsonTestSettings
	{
		public static JsonSerializerSettings NewtonsoftSettings { get; } = CreateNewtonsoftSettings();

		private static JsonSerializerSettings CreateNewtonsoftSettings()
		{
			var settings = new JsonSerializerSettings();

			settings.Converters.Add(new ValigatorConverter(settings));

			return settings;
		}
	}
}
