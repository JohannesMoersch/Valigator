using Functional;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Valigator.Core;
using Valigator.Newtonsoft.Json.PropertyHandlers;

namespace Valigator.Newtonsoft.Json
{
	internal abstract class ValigatorJsonPropertyHandler<TObject>
	{
		public abstract bool CanRead { get; }

		public abstract bool CanWrite { get; }

		public abstract void ReadProperty(JsonReader reader, JsonSerializer serializer, TObject obj);

		public abstract void WriteProperty(JsonWriter writer, JsonSerializer options, TObject obj);

		public static ValigatorJsonPropertyHandler<TObject> Create(TObject obj, PropertyInfo property)
		{
			if (!property.PropertyType.IsConstructedGenericType || property.PropertyType.GetGenericTypeDefinition() != typeof(Data<>))
				throw new ArgumentException("Property must be a Data type.", nameof(property));

			var data = property.GetValue(obj, null) as IData;

			var sourceType = data
				.DataContainer
				.GetType()
				.GetInterfaces()
				.First(i => i.IsConstructedGenericType && i.GetGenericTypeDefinition() == typeof(IAcceptValue<,>))
				.GetGenericArguments()[1];

			var type = property.PropertyType.GenericTypeArguments[0];

			bool isOptional;
			if (isOptional = IsOptional(type))
				type = type.GenericTypeArguments[0];

			bool isNullable;
			if (isNullable = IsNullable(type))
				type = type.GenericTypeArguments[0];

			if (IsCollection(type))
			{
				sourceType = sourceType
					.GetElementType()
					.GetGenericArguments()[0];

				type = type.GetElementType();

				bool isItemNullable;
				if (isItemNullable = IsNullable(type))
					type = type.GenericTypeArguments[0];

				return (isOptional, isNullable, isItemNullable) switch
				{
					(false, false, false) => CreatePropertyHandler(property, type, sourceType, typeof(CollectionPropertyHandler<,,>)),
					(false, false, true) => CreatePropertyHandler(property, type, sourceType, typeof(CollectionOfNullablePropertyHandler<,,>)),
					(false, true, false) => CreatePropertyHandler(property, type, sourceType, typeof(NullableCollectionPropertyHandler<,,>)),
					(false, true, true) => CreatePropertyHandler(property, type, sourceType, typeof(NullableCollectionOfNullablePropertyHandler<,,>)),
					(true, false, false) => CreatePropertyHandler(property, type, sourceType, typeof(OptionalCollectionPropertyHandler<,,>)),
					(true, false, true) => CreatePropertyHandler(property, type, sourceType, typeof(OptionalCollectionOfNullablePropertyHandler<,,>)),
					(true, true, false) => CreatePropertyHandler(property, type, sourceType, typeof(OptionalNullableCollectionPropertyHandler<,,>)),
					(true, true, true) => CreatePropertyHandler(property, type, sourceType, typeof(OptionalNullableCollectionOfNullablePropertyHandler<,,>))
				};
			}

			if (isOptional)
			{
				if (isNullable)
					return CreatePropertyHandler(property, type, sourceType, typeof(OptionalNullablePropertyHandler<,,>));
				else
					return CreatePropertyHandler(property, type, sourceType, typeof(OptionalPropertyHandler<,,>));
			}
			else if (isNullable)
				return CreatePropertyHandler(property, type, sourceType, typeof(NullablePropertyHandler<,,>));
			else
				return CreatePropertyHandler(property, type, sourceType, typeof(PropertyHandler<,,>));
		}

		private static bool IsOptional(Type type)
			=> type.IsConstructedGenericType && type.GetGenericTypeDefinition() == typeof(Optional<>);

		private static bool IsNullable(Type type)
			=> type.IsConstructedGenericType && type.GetGenericTypeDefinition() == typeof(Option<>);

		private static bool IsCollection(Type type)
			=> type.IsArray && type.HasElementType;

		private static ValigatorJsonPropertyHandler<TObject> CreatePropertyHandler(PropertyInfo property, Type valueType, Type sourceType, Type propertyHandlerType)
			=> (ValigatorJsonPropertyHandler<TObject>)Activator.CreateInstance(propertyHandlerType.MakeGenericType(typeof(TObject), valueType, sourceType), property);
	}
}
