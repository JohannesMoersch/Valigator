using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Valigator.Text.Json
{
	public class ValigatorConverterFactory : JsonConverterFactory
	{
		private ConcurrentDictionary<Type, JsonConverter> _converters = new ConcurrentDictionary<Type, JsonConverter>();

		public override bool CanConvert(Type typeToConvert)
			=> true;

		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
			=> _converters
				.GetOrAdd
				(
					typeToConvert,
					type => Activator.CreateInstance(typeof(ValigatorConverter<>).MakeGenericType(type), type.GetCustomAttribute<ValigatorConverterAttribute>()?.ObjectConstructionBehaviour ?? ValigatorObjectConstructionBehaviour.CloneCached) as JsonConverter // TODO - Validate type signature and properties (no public instance fields, no private instance properties)
				);
	}
}
