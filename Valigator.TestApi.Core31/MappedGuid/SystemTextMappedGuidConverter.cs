using System;

namespace Valigator.TestApi.Core31.MappedGuid
{
	public class SystemTextMappedGuidConverter : System.Text.Json.Serialization.JsonConverter<MappedGuid>
	{
		public static SystemTextMappedGuidConverter Instance = new SystemTextMappedGuidConverter();

		public override MappedGuid Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
		{
			if (reader.Read())
			{
				var guid = Guid.Parse(reader.GetString());
				return MappedGuidHelpers.Create(guid).Match(s => s, e => throw e);
			}

			throw new Exception("Didn't map guid");
		}

		public override void Write(System.Text.Json.Utf8JsonWriter writer, MappedGuid value, System.Text.Json.JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.Value);
		}
	}
}
