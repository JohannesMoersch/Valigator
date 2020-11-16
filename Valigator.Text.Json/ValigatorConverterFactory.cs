using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Valigator.Core.Helpers;

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
					type => type.GetCustomAttribute<ValigatorModelAttribute>() is ValigatorModelAttribute attribute || type.IsValigatorModelBase()
						? CreateConverterInstance(type)
						: null
				);

		private JsonConverter CreateConverterInstance(Type type)
		{
			ValidateModelSchema(type);

			return (JsonConverter)Activator
				.CreateInstance
				(
					typeof(ValigatorConverter<>).MakeGenericType(type), 
					type.GetCustomAttribute<ValigatorModelAttribute>()?.ModelConstructionBehaviour ?? ValigatorModelConstructionBehaviour.CloneCached
				);
		}

		private static void ValidateModelSchema(Type type)
		{
			foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
				throw new ValigatorModelSchemaException($"\"{type.FullName}\" has public non-static fields. Valigator models cannot have public non-static fields.");
		}
	}
}
