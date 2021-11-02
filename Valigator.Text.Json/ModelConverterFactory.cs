using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Valigator
{
	public class ModelConverterFactory : JsonConverterFactory
	{
		public override bool CanConvert(Type typeToConvert)
			=> typeof(IModel).IsAssignableFrom(typeToConvert);

#pragma warning disable CS8602, CS8603 // Dereference of a possibly null reference. Possible null reference return.
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
			=> typeof(ModelConverter<>)
				.MakeGenericType(typeToConvert)
				.GetConstructor(Type.EmptyTypes)
				.Invoke(null) as JsonConverter;
#pragma warning restore CS8602, CS8603 // Dereference of a possibly null reference. Possible null reference return.

		private class ModelConverter<T> : JsonConverter<T>
		{
			private delegate void WriteDelegate(Utf8JsonWriter writer, ref T model, JsonSerializerOptions options);

			private static WriteDelegate _writeMethod;

			static ModelConverter()
			{
				_writeMethod = CreateWriteMethod();
			}

			private static WriteDelegate CreateWriteMethod()
			{
				var writePropertyNameMethod = typeof(Utf8JsonWriter).GetMethods().First(m => m.Name == nameof(Utf8JsonWriter.WritePropertyName) && m.GetParameters()[0].ParameterType == typeof(string));
				var serializeMethod = typeof(JsonSerializer).GetMethods().First(m => m.Name == nameof(JsonSerializer.Serialize) && m.IsGenericMethod && m.GetParameters().Length == 3);
				var isSetMethod = typeof(ModelConverter<T>).GetMethods(BindingFlags.NonPublic | BindingFlags.Static).First(m => m.Name == nameof(IsSet));

				var writerParameterExpression = Expression.Parameter(typeof(Utf8JsonWriter), "writer");
				var modelParameterExpression = Expression.Parameter(typeof(T).MakeByRefType(), "model");
				var optionsParameterExpression = Expression.Parameter(typeof(JsonSerializerOptions), "options");

				var expressions = typeof(T)
					.GetProperties(BindingFlags.Public | BindingFlags.Instance)
					.Where(p => p.CanWrite)
					.Select(p =>
						{
							var propertyVariableExpression = Expression.Variable(p.PropertyType, "value");

							var assignmentExpression = Expression.Assign(propertyVariableExpression, Expression.Property(modelParameterExpression, typeof(T), p.Name));

							var blockExpression = Expression
								.Block
								(
									Expression.Call(writerParameterExpression, writePropertyNameMethod, Expression.Constant(p.Name, typeof(string))),
									Expression.Call(serializeMethod.MakeGenericMethod(p.PropertyType), writerParameterExpression, propertyVariableExpression, optionsParameterExpression)
								);

							if (p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(Optional<>))
							{
								return Expression
									.Block
									(
										new ParameterExpression[] { propertyVariableExpression },
										assignmentExpression,
										Expression.IfThen(Expression.Call(isSetMethod.MakeGenericMethod(p.PropertyType.GetGenericArguments()[0]), propertyVariableExpression), blockExpression)
									);
							}
							else
							{
								return Expression
									.Block
									(
										new ParameterExpression[] { propertyVariableExpression },
										new Expression[] { assignmentExpression }
											.Concat(blockExpression.Expressions)
									);
							}
						}
					)
					.ToArray();

				return Expression.Lambda<WriteDelegate>
					(
						Expression.Block(expressions), 
						writerParameterExpression, 
						modelParameterExpression, 
						optionsParameterExpression
					)
					.Compile();
			}

			private static bool IsSet<U>(Optional<U> optional)
				=> optional.TryGetValue(out _);

			public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
			{
				return default;
			}

			public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
			{
				writer.WriteStartObject();

				_writeMethod.Invoke(writer, ref value, options);

				writer.WriteEndObject();
			}
		}
	}
}
