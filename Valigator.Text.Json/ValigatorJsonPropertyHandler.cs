using Functional;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Valigator.Text.Json.PropertyHandlers;

namespace Valigator.Text.Json
{
	internal abstract class ValigatorJsonPropertyHandler<TObject>
	{
		public abstract bool CanRead { get; }

		public abstract bool CanWrite { get; }

		public abstract void ReadProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, TObject obj);

		public abstract void WriteProperty(Utf8JsonWriter writer, JsonSerializerOptions options, TObject obj);

		public static ValigatorJsonPropertyHandler<TObject> Create(PropertyInfo property)
		{
			if (!property.PropertyType.IsConstructedGenericType || property.PropertyType.GetGenericTypeDefinition() != typeof(Data<>))
				throw new ArgumentException("Property must be a Data type.", nameof(property));

			var type = property.PropertyType.GenericTypeArguments[0];

			bool isOptional;
			if (isOptional = IsOptional(type))
				type = type.GenericTypeArguments[0];

			bool isNullable;
			if (isNullable = IsNullable(type))
				type = type.GenericTypeArguments[0];

			if (IsCollection(type))
			{
				type = type.GetElementType();

				bool isItemNullable;
				if (isItemNullable = IsNullable(type))
					type = type.GenericTypeArguments[0];

				return (isOptional, isNullable, isItemNullable) switch
				{
					(false, false, false) => throw new NotSupportedException(),
					(false, false, true) => throw new NotSupportedException(),
					(false, true, false) => throw new NotSupportedException(),
					(false, true, true) => throw new NotSupportedException(),
					(true, false, false) => CreatePropertyHandler(property, type, typeof(OptionalCollectionPropertyHandler<,>)),
					(true, false, true) => CreatePropertyHandler(property, type, typeof(OptionalCollectionOfNullablePropertyHandler<,>)),
					(true, true, false) => CreatePropertyHandler(property, type, typeof(OptionalNullableCollectionPropertyHandler<,>)),
					(true, true, true) => CreatePropertyHandler(property, type, typeof(OptionalNullableCollectionOfNullablePropertyHandler<,>))
				};
			}

			if (isOptional)
			{
				if (isNullable)
					return CreatePropertyHandler(property, type, typeof(OptionalNullablePropertyHandler<,>));
				else
					return CreatePropertyHandler(property, type, typeof(OptionalPropertyHandler<,>));
			}
			else if (isNullable)
				return CreatePropertyHandler(property, type, typeof(NullablePropertyHandler<,>));
			else
				return CreatePropertyHandler(property, type, typeof(PropertyHandler<,>));
		}

		private static bool IsOptional(Type type)
			=> type.IsConstructedGenericType && type.GetGenericTypeDefinition() == typeof(Optional<>);

		private static bool IsNullable(Type type)
			=> type.IsConstructedGenericType && type.GetGenericTypeDefinition() == typeof(Option<>);

		private static bool IsCollection(Type type)
			=> type.IsArray && type.HasElementType;

		private static ValigatorJsonPropertyHandler<TObject> CreatePropertyHandler(PropertyInfo property, Type valueType, Type propertyHandlerType)
			=> (ValigatorJsonPropertyHandler<TObject>)Activator.CreateInstance(propertyHandlerType.MakeGenericType(typeof(TObject), valueType), property); 
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

		public override void ReadProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, TObject obj)
		{
			if (_getValue != null && _setValue != null)
				_setValue.Invoke(obj, ValigatorJsonReader.ReadValue(ref reader, options, _getValue.Invoke(obj)));
			else
				throw new NotSupportedException();
		}

		public override void WriteProperty(Utf8JsonWriter writer, JsonSerializerOptions options, TObject obj)
		{
			if (_getValue != null)
				ValigatorJsonWriter.WriteValue(writer, options, _getValue.Invoke(obj));
			else
				throw new NotSupportedException();
		}

		public new static ValigatorJsonPropertyHandler<TObject, TDataValue> Create(PropertyInfo property)
		{
			if (property.GetCustomAttribute<JsonIgnoreAttribute>() != null)
				return new ValigatorJsonPropertyHandler<TObject, TDataValue>(null, null);

			var objParameter = Expression.Parameter(typeof(TObject), "obj");
			var propertyExpression = Expression.Property(objParameter, property);

			var valueParameter = Expression.Parameter(typeof(Data<TDataValue>), "value");

			var getter = property.CanRead ? Expression.Lambda<Func<TObject, Data<TDataValue>>>(propertyExpression, objParameter).Compile() : null;
			var setter = property.CanWrite ? Expression.Lambda<Action<TObject, Data<TDataValue>>>(Expression.Assign(propertyExpression, valueParameter), objParameter, valueParameter).Compile() : null;

			return new ValigatorJsonPropertyHandler<TObject, TDataValue>(getter, setter);
		}
	}
}
