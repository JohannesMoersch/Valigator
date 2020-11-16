using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using Valigator.Core.Helpers;

namespace Valigator.Newtonsoft.Json
{
	public class Converter<TObject> : IConverter
		where TObject : class
	{
		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> CreatePropertyHandlers()
		{
			var result = new Dictionary<string, ValigatorJsonPropertyHandler<TObject>>();

			foreach (var property in ValigatorModelBaseHelpers.GetProperties(typeof(TObject), BindingFlags.Public | BindingFlags.Instance))
				result.Add(property.Name, ValigatorJsonPropertyHandler<TObject>.Create(property));

			return result;
		}

		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> _propertyHandlers;
		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> PropertyHandlers => _propertyHandlers ??= CreatePropertyHandlers();

		private readonly bool _useNewInstances;

		public Converter(ValigatorModelConstructionBehaviour instanceConstructionBehaviour)
		{
			switch (instanceConstructionBehaviour)
			{
				case ValigatorModelConstructionBehaviour.NewInstance:
					_useNewInstances = true;
					break;
				case ValigatorModelConstructionBehaviour.CloneCached:
					_useNewInstances = false;
					break;
				default:
					throw new Exception();
			}
		}

		public TObject Read(JsonReader reader, JsonSerializer serializer)
		{
			var obj = GetObjectInstance();

			while (true)
			{
				if (!reader.Read())
					throw new Exception();

				if (reader.TokenType == JsonToken.EndObject)
					break;

				if (reader.TokenType != JsonToken.PropertyName)
					throw new Exception();

				var propertyName = (string)reader.Value;

				if (PropertyHandlers.TryGetValue(propertyName, out var propertyHandler) && propertyHandler.CanWrite)
				{
					if (!reader.Read())
						throw new Exception();

					propertyHandler.ReadProperty(reader, serializer, obj);
				}
				else
					serializer.Deserialize(reader, typeof(object));
			}

			return obj;
		}

		private TObject GetObjectInstance()
			=> _useNewInstances
				? Model.CreateNew<TObject>()
				: Model.CreateClone<TObject>();

		public void Write(JsonWriter writer, TObject value, JsonSerializer serializer)
		{
			writer.WriteStartObject();

			foreach (var handler in PropertyHandlers.Where(kvp => kvp.Value.CanRead))
			{
				writer.WritePropertyName(handler.Key);

				handler.Value.WriteProperty(writer, serializer, value);
			}

			writer.WriteEndObject();
		}

		object IConverter.Read(JsonReader reader, JsonSerializer serializer)
			=> Read(reader, serializer);

		void IConverter.Write(JsonWriter writer, object value, JsonSerializer serializer)
			=> Write(writer, (TObject)value, serializer);
	}
}
