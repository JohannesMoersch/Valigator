using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;

namespace Valigator.Newtonsoft.Json
{
	public class Converter<TObject> : IConverter
		where TObject : class
	{
		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> CreatePropertyHandlers(TObject obj)
		{
			var result = new Dictionary<string, ValigatorJsonPropertyHandler<TObject>>();

			foreach (var property in typeof(TObject).GetProperties(BindingFlags.Public | BindingFlags.Instance))
				result.Add(property.Name, ValigatorJsonPropertyHandler<TObject>.Create(obj, property));

			return result;
		}

		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> _getPropertyHandlers;
		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> GetPropertyHandlers(TObject obj)
			=> _getPropertyHandlers ??= CreatePropertyHandlers(obj);

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

		public object Read(JsonReader reader, JsonSerializer serializer)
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

				if (!reader.Read())
					throw new Exception();

				if (GetPropertyHandlers(obj).TryGetValue(propertyName, out var propertyHandler))
					propertyHandler.ReadProperty(reader, serializer, obj);
				else
					serializer.Deserialize(reader, typeof(JObject));
			}

			return obj;
		}

		private TObject GetObjectInstance()
			=> _useNewInstances
				? Model.CreateNew<TObject>()
				: Model.CreateClone<TObject>();

		public void Write(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteStartObject();

			foreach (var handler in GetPropertyHandlers((TObject)value))
				handler.Value.WriteProperty(writer, serializer, (TObject)value);

			writer.WriteEndObject();
		}
	}
}
