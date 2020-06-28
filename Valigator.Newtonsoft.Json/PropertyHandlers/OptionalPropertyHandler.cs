using Functional;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Valigator.Newtonsoft.Json.PropertyHandlers
{
	internal class OptionalPropertyHandler<TObject, TValue, TSource> : ValigatorJsonPropertyHandler<TObject>
	{
		private readonly Func<TObject, Data<Optional<TValue>>> _getValue;
		private readonly Action<TObject, Data<Optional<TValue>>> _setValue;

		public string PropertyName { get; }

		public override bool CanRead => _getValue != null;
		public override bool CanWrite => _setValue != null;

		public OptionalPropertyHandler(PropertyInfo property)
		{
			PropertyName = property.Name;
			_getValue = property.GetGetter<TObject, Optional<TValue>>();
			_setValue = property.GetSetter<TObject, Optional<TValue>>();
		}

		public override void ReadProperty(JsonReader reader, JsonSerializer serializer, TObject obj)
		{
			if (_getValue == null && _setValue == null)
				throw new NotSupportedException();

			var data = _getValue.Invoke(obj);

			if (reader.TokenType != JsonToken.Null && serializer.Deserialize<TSource>(reader) is TSource value)
				data = data.WithMappedValue(value);
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

					serializer.Serialize(writer, value);
				}
			}
			else
				throw new NotSupportedException();
		}
	}
}
