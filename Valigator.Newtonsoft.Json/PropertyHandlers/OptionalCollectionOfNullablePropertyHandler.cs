using Functional;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Valigator.Newtonsoft.Json.PropertyHandlers
{
	internal class OptionalCollectionOfNullablePropertyHandler<TObject, TValue, TSource> : ValigatorJsonPropertyHandler<TObject>
	{
		private readonly Func<TObject, Data<Optional<Option<TValue>[]>>> _getValue;
		private readonly Action<TObject, Data<Optional<Option<TValue>[]>>> _setValue;

		public string PropertyName { get; }

		public override bool CanRead => _getValue != null;
		public override bool CanWrite => _setValue != null;

		public OptionalCollectionOfNullablePropertyHandler(PropertyInfo property)
		{
			PropertyName = property.Name;
			_getValue = property.GetGetter<TObject, Optional<Option<TValue>[]>>();
			_setValue = property.GetSetter<TObject, Optional<Option<TValue>[]>>();
		}

		public override void ReadProperty(JsonReader reader, JsonSerializer serializer, TObject obj)
		{
			if (_getValue == null && _setValue == null)
				throw new NotSupportedException();

			var data = _getValue.Invoke(obj);

			if (reader.TokenType != JsonToken.Null)
			{
				var values = new List<Option<TSource>>();

				while (reader.Read() && reader.TokenType != JsonToken.EndArray)
				{
					if (reader.TokenType != JsonToken.Null)
					{
						var value = serializer.Deserialize<TSource>(reader);

						values.Add(Option.Create(value != null, value));
					}
					else
						values.Add(Option.None<TSource>());
				}

				data = data.WithMappedValue(values.ToArray());
			}
			else
				data = data.WithNull();

			_setValue.Invoke(obj, data);
		}

		public override void WriteProperty(JsonWriter writer, JsonSerializer serializer, TObject obj)
		{
			if (_getValue != null)
			{
				if (_getValue.Invoke(obj).Value.TryGetValue(out var value))
				{
					writer.WritePropertyName(PropertyName);

					writer.WriteStartArray();

					foreach (var option in value)
					{
						if (option.TryGetValue(out var item))
							serializer.Serialize(writer, item);
						else
							writer.WriteNull();
					}

					writer.WriteEndArray();
				}
			}
			else
				throw new NotSupportedException();
		}
	}
}
