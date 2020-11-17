using Newtonsoft.Json;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Valigator.Newtonsoft.Json
{
	internal abstract class ValigatorJsonPropertyHandler<TObject>
	{
		public abstract bool CanRead { get; }

		public abstract bool CanWrite { get; }

		public abstract void ReadProperty(JsonReader reader, JsonSerializer serializer, TObject obj);

		public abstract void WriteProperty(JsonWriter writer, JsonSerializer serializer, TObject obj);

		public static ValigatorJsonPropertyHandler<TObject> Create(PropertyInfo property)
		{
			var propertyHandlerType = property.PropertyType.IsValigatorDataType() ? typeof(ValigatorJsonPropertyHandler<,>) : typeof(NonValigatorDataJsonPropertyHandler<,>);

			var propertyType = property.PropertyType.IsValigatorDataType() ? property.PropertyType.GetGenericArguments()[0] : property.PropertyType;

			var handlerType = propertyHandlerType.MakeGenericType(typeof(TObject), propertyType);

			var createMethod = handlerType.GetMethod(nameof(ValigatorJsonPropertyHandler<TObject, bool>.Create), BindingFlags.Public | BindingFlags.Static, Type.DefaultBinder, new[] { typeof(PropertyInfo) }, null);

			return (ValigatorJsonPropertyHandler<TObject>)createMethod.Invoke(null, new[] { property });
		}

		internal static Func<TObject, TValue> CreateGetter<TValue>(PropertyInfo property)
		{
			var objParameter = Expression.Parameter(typeof(TObject), "obj");
			var propertyParameter = Expression.Constant(property);

			var getValueMethod = property.GetType().GetMethod(nameof(PropertyInfo.GetValue), new[] { typeof(object) });
			var getterExpression = Expression.Convert(Expression.Call(propertyParameter, getValueMethod, objParameter), property.PropertyType);
			var getter = property.CanRead ? Expression.Lambda<Func<TObject, TValue>>(getterExpression, objParameter).Compile() : null;

			return getter;
		}

		internal static Action<TObject, TValue> CreateSetter<TValue>(PropertyInfo property)
		{
			var objParameter = Expression.Parameter(typeof(TObject), "obj");
			var propertyParameter = Expression.Constant(property);

			var valueParameter = Expression.Parameter(typeof(TValue), "value");
			var setValueMethod = property.GetType().GetMethod(nameof(PropertyInfo.SetValue), new[] { typeof(object), typeof(object) });
			var setProperty = Expression.Call(propertyParameter, setValueMethod, objParameter, Expression.Convert(valueParameter, typeof(object)));
			var setter = property.CanWrite ? Expression.Lambda<Action<TObject, TValue>>(setProperty, objParameter, valueParameter).Compile() : null;

			return setter;
		}
	}

	internal class NonValigatorDataJsonPropertyHandler<TObject, TValue> : ValigatorJsonPropertyHandler<TObject>
	{
		private readonly Func<TObject, TValue> _getValue;
		private readonly Action<TObject, TValue> _setValue;

		public override bool CanRead => _getValue != null;
		public override bool CanWrite => _setValue != null;

		public NonValigatorDataJsonPropertyHandler(Func<TObject, TValue> getValue, Action<TObject, TValue> setValue)
		{
			_getValue = getValue;
			_setValue = setValue;
		}

		public override void ReadProperty(JsonReader reader, JsonSerializer serializer, TObject obj)
		{
			if (_setValue != null)
				_setValue(obj, serializer.Deserialize<TValue>(reader));
			else
				throw new NotSupportedException();
		}

		public override void WriteProperty(JsonWriter writer, JsonSerializer serializer, TObject obj)
		{
			if (_getValue != null)
				serializer.Serialize(writer, _getValue(obj), typeof(TValue));
			else
				throw new NotSupportedException();
		}

		public new static NonValigatorDataJsonPropertyHandler<TObject, TValue> Create(PropertyInfo property)
		{
			if (property.GetCustomAttribute<JsonIgnoreAttribute>() != null)
				return new NonValigatorDataJsonPropertyHandler<TObject, TValue>(null, null);


			var getter = CreateGetter<TValue>(property);
			var setter = CreateSetter<TValue>(property);

			return new NonValigatorDataJsonPropertyHandler<TObject, TValue>(getter, setter);
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

		public new static ValigatorJsonPropertyHandler<TObject, TDataValue> Create(PropertyInfo property)
		{
			if (property.GetCustomAttribute<JsonIgnoreAttribute>() != null)
				return new ValigatorJsonPropertyHandler<TObject, TDataValue>(null, null);

			var getter = CreateGetter<Data<TDataValue>>(property);
			var setter = CreateSetter<Data<TDataValue>>(property);

			return new ValigatorJsonPropertyHandler<TObject, TDataValue>(getter, setter);
		}
	}
}
