using System;
using Functional;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Valigator.TestApi.Core31;

namespace Valigator.TestApi.Core31.MappedGuid
{
	public class NewtonsoftMappedGuidConverter : JsonConverter
	{
		public static readonly NewtonsoftMappedGuidConverter Instance = new NewtonsoftMappedGuidConverter();

		public override bool CanRead { get; } = true;
		public override bool CanWrite { get; } = true;

		public override bool CanConvert(Type objectType)
			=> objectType == typeof(MappedGuid);

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			=> reader
				.TryParseGuidValue<MappedGuid>()
				.Bind(MappedGuidHelpers.Create)
				.Match(_ => _, e => throw e);

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value == null)
				writer.WriteNull();
			else
				JToken.FromObject(((MappedGuid)value).Value).WriteTo(writer);
		}
	}
}
