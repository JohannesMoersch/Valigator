using Newtonsoft.Json;
using System;
using System.Linq.Expressions;
using System.Reflection;
using Valigator.Core;

namespace Valigator.Newtonsoft.Json
{
	internal abstract class ValigatorJsonPropertyHandler<TObject>
	{
		public abstract bool CanRead { get; }

		public abstract bool CanWrite { get; }

		public abstract void ReadProperty(JsonReader reader, JsonSerializer serializer, TObject obj);

		public abstract void WriteProperty(JsonWriter writer, JsonSerializer serializer, TObject obj);

		public static ValigatorJsonPropertyHandler<TObject> Create(PropertyInfo property, TObject obj)
		{
			var handlerType = typeof(ValigatorJsonPropertyHandler<,>).MakeGenericType(typeof(TObject), property.PropertyType.GetGenericArguments()[0]);

			var createMethod = handlerType.GetMethod(nameof(ValigatorJsonPropertyHandler<TObject, bool>.Create), BindingFlags.Public | BindingFlags.Static, Type.DefaultBinder, new[] { typeof(PropertyInfo), typeof(TObject) }, null);

			return (ValigatorJsonPropertyHandler<TObject>)createMethod.Invoke(null, new object[] { property, obj });
		}
	}

	internal class ValigatorJsonPropertyHandler<TObject, TDataValue> : ValigatorJsonPropertyHandler<TObject>
	{
		private readonly Func<TObject, Data<TDataValue>> _getValue;
		private readonly Action<TObject, Data<TDataValue>> _setValue;

		public override bool CanRead => _getValue != null;
		public override bool CanWrite => _setValue != null;

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

		public new static ValigatorJsonPropertyHandler<TObject, TDataValue> Create(PropertyInfo property, TObject obj)
		{
			if (property.GetCustomAttribute<JsonIgnoreAttribute>() != null)
				return new ValigatorJsonPropertyHandler<TObject, TDataValue>(null, null);

			var objParameter = Expression.Parameter(typeof(TObject), "obj");
			var propertyExpression = ValigatorModelBaseHelpers.CreateDataExpression(objParameter, property, obj);

			var valueParameter = Expression.Parameter(typeof(Data<TDataValue>), "value");

			var getter = property.CanRead ? Expression.Lambda<Func<TObject, Data<TDataValue>>>(propertyExpression, objParameter).Compile() : null;
			var setter = property.CanWrite ? Expression.Lambda<Action<TObject, Data<TDataValue>>>(Expression.Assign(propertyExpression, valueParameter), objParameter, valueParameter).Compile() : null;

			return new ValigatorJsonPropertyHandler<TObject, TDataValue>(getter, setter);
		}
	}
}
