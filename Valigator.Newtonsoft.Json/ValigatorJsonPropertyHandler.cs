using Newtonsoft.Json;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Valigator.Newtonsoft.Json
{
	internal abstract class ValigatorJsonPropertyHandler<TObject>
	{
		public abstract void ReadProperty(JsonReader reader, JsonSerializer serializer, TObject obj);

		public abstract void WriteProperty(JsonWriter writer, JsonSerializer serializer, TObject obj);

		public static ValigatorJsonPropertyHandler<TObject> Create(PropertyInfo property)
		{
			var handlerType = typeof(ValigatorJsonPropertyHandler<,>).MakeGenericType(typeof(TObject), property.PropertyType.GetGenericArguments()[0]);

			var createMethod = handlerType.GetMethod(nameof(ValigatorJsonPropertyHandler<TObject, bool>.Create), BindingFlags.Public | BindingFlags.Static, Type.DefaultBinder, new[] { typeof(PropertyInfo) }, null);

			return (ValigatorJsonPropertyHandler<TObject>)createMethod.Invoke(null, new[] { property });
		}
	}

	internal class ValigatorJsonPropertyHandler<TObject, TDataValue> : ValigatorJsonPropertyHandler<TObject>
	{
		private readonly Func<TObject, Data<TDataValue>> _getValue;
		private readonly Action<TObject, Data<TDataValue>> _setValue;

		public ValigatorJsonPropertyHandler(Func<TObject, Data<TDataValue>> getValue, Action<TObject, Data<TDataValue>> setValue)
		{
			_getValue = getValue;
			_setValue = setValue;
		}

		public override void ReadProperty(JsonReader reader, JsonSerializer serializer, TObject obj)
		{
			if (_getValue != null && _setValue != null)
				_setValue.Invoke(obj, ValigatorJsonReader.ReadValue(reader, serializer, _getValue.Invoke(obj)));
			else
				throw new NotSupportedException();
		}

		public override void WriteProperty(JsonWriter writer, JsonSerializer serializer, TObject obj)
		{
			if (_getValue != null)
				ValigatorJsonWriter.WriteValue(writer, serializer, _getValue.Invoke(obj));
			else
				throw new NotSupportedException();
		}

		public new static ValigatorJsonPropertyHandler<TObject, TDataValue> Create(PropertyInfo property)
		{
			var objParameter = Expression.Parameter(typeof(TObject), "obj");
			var propertyExpression = Expression.Property(objParameter, property);

			var valueParameter = Expression.Parameter(typeof(Data<TDataValue>), "value");

			var getter = property.CanRead ? Expression.Lambda<Func<TObject, Data<TDataValue>>>(propertyExpression, objParameter).Compile() : null;
			var setter = property.CanWrite ? Expression.Lambda<Action<TObject, Data<TDataValue>>>(Expression.Assign(propertyExpression, valueParameter), objParameter, valueParameter).Compile() : null;

			return new ValigatorJsonPropertyHandler<TObject, TDataValue>(getter, setter);
		}
	}
}
