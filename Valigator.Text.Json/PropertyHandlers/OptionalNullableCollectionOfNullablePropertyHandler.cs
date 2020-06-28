using Functional;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace Valigator.Text.Json.PropertyHandlers
{
	internal class OptionalNullableCollectionOfNullablePropertyHandler<TObject, TValue, TSource> : ValigatorJsonPropertyHandler<TObject>
	{
		private readonly Func<TObject, Data<Optional<Option<Option<TValue>[]>>>> _getValue;
		private readonly Action<TObject, Data<Optional<Option<Option<TValue>[]>>>> _setValue;

		public string PropertyName { get; }

		public override bool CanRead => _getValue != null;
		public override bool CanWrite => _setValue != null;

		public OptionalNullableCollectionOfNullablePropertyHandler(PropertyInfo property)
		{
			PropertyName = property.Name;
			_getValue = property.GetGetter<TObject, Optional<Option<Option<TValue>[]>>>();
			_setValue = property.GetSetter<TObject, Optional<Option<Option<TValue>[]>>>();
		}

		public override void ReadProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, TObject obj)
		{
			if (_getValue == null && _setValue == null)
				throw new NotSupportedException();

			var data = _getValue.Invoke(obj);

			if (reader.TokenType != JsonTokenType.Null)
			{
				var values = new List<Option<TSource>>();

				while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
				{
					if (reader.TokenType != JsonTokenType.Null)
					{
						var value = JsonSerializer.Deserialize<TSource>(ref reader, options);

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

		public override void WriteProperty(Utf8JsonWriter writer, JsonSerializerOptions options, TObject obj)
		{
			if (_getValue != null)
			{
				if (_getValue.Invoke(obj).Value.TryGetValue(out var value))
				{
					writer.WritePropertyName(PropertyName);

					if (value.TryGetValue(out var some))
					{
						writer.WriteStartArray();

						foreach (var option in some)
						{
							if (option.TryGetValue(out var item))
								JsonSerializer.Serialize(writer, item, options);
							else
								writer.WriteNullValue();
						}

						writer.WriteEndArray();
					}
					else
						writer.WriteNullValue();
				}
			}
			else
				throw new NotSupportedException();
		}
	}
}
