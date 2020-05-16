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
			=> typeToConvert.IsClass && CreateConverter(typeToConvert, null) != null;

		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions _)
			=> _converters
				.GetOrAdd
				(
					typeToConvert,
					type => type.GetCustomAttribute<ValigatorModelAttribute>() is ValigatorModelAttribute attribute
						? Activator.CreateInstance(typeof(ValigatorConverter<>).MakeGenericType(type), type.GetCustomAttribute<ValigatorModelAttribute>()?.ModelConstructionBehaviour ?? ValigatorModelConstructionBehaviour.CloneCached) as JsonConverter // TODO - Validate type signature and properties (no public instance fields, no private instance properties)
						: null
				);
	}
}
