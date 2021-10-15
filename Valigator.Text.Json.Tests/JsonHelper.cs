using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Valigator.Text.Json.Tests
{
	public static class JsonHelper
	{
		static JsonHelper()
		{
			var options = new JsonSerializerOptions();
				
			options.Converters.Add(new OptionConverterFactory());
			options.Converters.Add(new OptionalConverterFactory());

			_options = options;
		}

		private static readonly JsonSerializerOptions _options;

		public static string Serialize<T>(T value)
			=> JsonSerializer.Serialize(value, _options);

		public static T Deserialize<T>(string json)
			=> JsonSerializer.Deserialize<T>(json, _options);

		public static T CloneViaSerialization<T>(T value)
			=> Deserialize<T>(Serialize(value));
	}
}
