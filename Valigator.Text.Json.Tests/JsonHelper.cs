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
			_caseSensitiveOptions = CreateOptions(true);
			_caseInsensitiveOptions = CreateOptions(false);
		}

		private static JsonSerializerOptions CreateOptions(bool caseSensitive)
		{
			var options = new JsonSerializerOptions();

			options.Converters.Add(new OptionConverterFactory());
			options.Converters.Add(new OptionalConverterFactory());
			options.Converters.Add(new ModelConverterFactory());

			options.WriteIndented = true;

			options.PropertyNameCaseInsensitive = !caseSensitive;

			return options;
		}

		private static readonly JsonSerializerOptions _caseSensitiveOptions;
		private static readonly JsonSerializerOptions _caseInsensitiveOptions;

		private static JsonSerializerOptions GetOptions(bool caseSensitive)
			=> caseSensitive ? _caseSensitiveOptions : _caseInsensitiveOptions;

		public static string Serialize<T>(T value)
			=> JsonSerializer.Serialize(value, GetOptions(true));

		public static T Deserialize<T>(string json, bool caseSensitive = true)
			=> JsonSerializer.Deserialize<T>(json, GetOptions(caseSensitive));

		public static T CloneViaSerialization<T>(T value, bool caseSensitive = true)
			=> Deserialize<T>(Serialize(value), caseSensitive);

		public static string Format(string json)
			=> JsonSerializer
				.Serialize
				(
					JsonDocument.Parse(json),
					_caseSensitiveOptions
				);
				
				
	}
}
