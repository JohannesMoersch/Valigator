using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Valigator.Text.Json;

namespace Valigator.Text.Json.Tests
{
	public static class JsonTestSettings
	{
		public static JsonSerializerOptions SystemTextJsonSettings { get; } = CreateSystemTextJsonSettings();

		private static JsonSerializerOptions CreateSystemTextJsonSettings()
		{
			var settings = new JsonSerializerOptions();

			settings.Converters.Add(new ValigatorConverterFactory());

			return settings;
		}
	}
}
