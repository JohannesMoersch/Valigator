using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Valigator.Text.Json
{
	internal static class ConverterCodeGenerator
	{
		public delegate void WriteDelegate<T>(Utf8JsonWriter writer, ref T model, JsonSerializerOptions options);

		public delegate void ReadDelegate<T>(ref Utf8JsonReader reader, ref T model, JsonSerializerOptions options);

		private static readonly MethodInfo IsSetMethod;
		private static readonly MethodInfo WritePropertyNameMethod;
		private static readonly MethodInfo SerializeMethod;

		private static readonly MethodInfo DeserializeMethod;
		private static readonly MethodInfo GetStringMethod;
		private static readonly MethodInfo ReadMethod;
		private static readonly MethodInfo ToLowerMethod;

		static ConverterCodeGenerator()
		{
			IsSetMethod = typeof(ConverterCodeGenerator)
				.GetMethods(BindingFlags.NonPublic | BindingFlags.Static)
				.First(m => m.Name == nameof(IsSet));

			WritePropertyNameMethod = typeof(Utf8JsonWriter)
				.GetMethods(BindingFlags.Public | BindingFlags.Instance)
				.First
				(
					m => m.Name == nameof(Utf8JsonWriter.WritePropertyName)
						&& !m.IsGenericMethod
						&& m.GetParameters().FirstOrDefault()?.ParameterType == typeof(string)
				);
			
			SerializeMethod = typeof(JsonSerializer)
				.GetMethods(BindingFlags.Public | BindingFlags.Static)
				.First(
					m => m.Name == nameof(JsonSerializer.Serialize) 
						&& m.IsGenericMethod 
						&& m.GetParameters()
							.Select(p => p.ParameterType)
							.SequenceEqual(new[] { typeof(Utf8JsonWriter), m.GetGenericArguments()[0], typeof(JsonSerializerOptions) })
				);

			DeserializeMethod = typeof(JsonSerializer)
				.GetMethods(BindingFlags.Public | BindingFlags.Static)
				.First
				(
					m => m.Name == nameof(JsonSerializer.Deserialize) 
						&& m.IsGenericMethod 
						&& m.GetParameters()
							.Select(p => p.ParameterType)
							.SequenceEqual(new[] { typeof(Utf8JsonReader).MakeByRefType(), typeof(JsonSerializerOptions) })
				);
			
			GetStringMethod = typeof(Utf8JsonReader)
				.GetMethods(BindingFlags.Public | BindingFlags.Instance)
				.First
				(
					m => m.Name == nameof(Utf8JsonReader.GetString)
						&& !m.IsGenericMethod
						&& m.GetParameters().Length == 0
				);
			
			ReadMethod = typeof(Utf8JsonReader)
				.GetMethods(BindingFlags.Public | BindingFlags.Instance)
				.First
				(
					m => m.Name == nameof(Utf8JsonReader.Read)
						&& !m.IsGenericMethod
						&& m.GetParameters().Length == 0
				);
			
			ToLowerMethod = typeof(String)
				.GetMethods(BindingFlags.Public | BindingFlags.Instance)
				.First
				(
					m => m.Name == nameof(String.ToLower)
						&& !m.IsGenericMethod
						&& m.GetParameters().Length == 0
				);
		}

		public static WriteDelegate<T> CreateWriteMethod<T>()
		{
			var writerParameterExpression = Expression.Parameter(typeof(Utf8JsonWriter), "writer");
			var modelParameterExpression = Expression.Parameter(typeof(T).MakeByRefType(), "model");
			var optionsParameterExpression = Expression.Parameter(typeof(JsonSerializerOptions), "options");

			var expressions = typeof(T)
				.GetProperties(BindingFlags.Public | BindingFlags.Instance)
				.Where(p => p.CanWrite)
				.Select(p => CreateSerializePropertyExpression<T>(p, modelParameterExpression, writerParameterExpression, optionsParameterExpression))
				.ToArray();

			return Expression.Lambda<WriteDelegate<T>>
				(
					Expression.Block(expressions),
					writerParameterExpression,
					modelParameterExpression,
					optionsParameterExpression
				)
				.Compile();
		}

		private static Expression CreateSerializePropertyExpression<T>(PropertyInfo property, ParameterExpression modelParameterExpression, ParameterExpression writerParameterExpression, ParameterExpression optionsParameterExpression)
		{
			var propertyVariableExpression = Expression.Variable(property.PropertyType, "value");

			var assignmentExpression = Expression.Assign(propertyVariableExpression, Expression.Property(modelParameterExpression, typeof(T), property.Name));

			var blockExpression = Expression
					.Block
					(
						Expression.Call(writerParameterExpression, WritePropertyNameMethod, Expression.Constant(property.Name, typeof(string))),
						Expression.Call(SerializeMethod.MakeGenericMethod(property.PropertyType), writerParameterExpression, propertyVariableExpression, optionsParameterExpression)
					);

			if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Optional<>))
			{
				return Expression
						.Block
						(
							new ParameterExpression[] { propertyVariableExpression },
							assignmentExpression,
							Expression.IfThen(Expression.Call(IsSetMethod.MakeGenericMethod(property.PropertyType.GetGenericArguments()[0]), propertyVariableExpression), blockExpression)
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

		private static bool IsSet<T>(Optional<T> optional)
			=> optional.TryGetValue(out _);

		public static ReadDelegate<T> CreateReadMethod<T>()
		{
			var readerParameterExpression = Expression.Parameter(typeof(Utf8JsonReader).MakeByRefType(), "reader");
			var modelParameterExpression = Expression.Parameter(typeof(T).MakeByRefType(), "model");
			var optionsParameterExpression = Expression.Parameter(typeof(JsonSerializerOptions), "options");

			var propertyNameVariableExpression = Expression.Variable(typeof(string), "propertyName");

			var breakLabel = Expression.Label();

			var usedNames = new HashSet<string>();

			var caseSensitiveSwitchCases = typeof(T)
				.GetProperties(BindingFlags.Public | BindingFlags.Instance)
				.Where(p => p.CanRead)
				.Select(p => CreateSwitchCaseForProperty(p, p.Name, readerParameterExpression, modelParameterExpression, optionsParameterExpression))
				.ToArray();

			var caseInsensitiveSwitchCases = typeof(T)
				.GetProperties(BindingFlags.Public | BindingFlags.Instance)
				.Where(p => p.CanRead && usedNames.Add(p.Name.ToLower()))
				.Select(p => CreateSwitchCaseForProperty(p, p.Name.ToLower(), readerParameterExpression, modelParameterExpression, optionsParameterExpression))
				.ToArray();

			var caseSensitiveSwitchExpression = Expression
				.Switch
				(
					typeof(void),
					propertyNameVariableExpression,
					Expression.Call(DeserializeMethod.MakeGenericMethod(typeof(object)), readerParameterExpression, optionsParameterExpression),
					null,
					caseSensitiveSwitchCases
				);

			var caseInsensitiveSwitchExpression = Expression
				.Switch
				(
					typeof(void),
					Expression.Call(propertyNameVariableExpression, ToLowerMethod),
					Expression.Call(DeserializeMethod.MakeGenericMethod(typeof(object)), readerParameterExpression, optionsParameterExpression),
					null,
					caseInsensitiveSwitchCases
				);

			var loopBodyExpression = Expression
				.Block
				(
					new[] { propertyNameVariableExpression },
					Expression
						.IfThen
						(
							Expression
								.OrElse
								(
									Expression.Not(Expression.Call(readerParameterExpression, ReadMethod)),
									Expression.NotEqual(Expression.Property(readerParameterExpression, nameof(Utf8JsonReader.TokenType)), Expression.Constant(JsonTokenType.PropertyName, typeof(JsonTokenType)))
								),
							Expression.Break(breakLabel)
						),
					Expression.Assign(propertyNameVariableExpression, Expression.Call(readerParameterExpression, GetStringMethod)),
					Expression.Call(readerParameterExpression, ReadMethod),
					Expression
						.IfThenElse
						(
							Expression.Equal(Expression.Property(optionsParameterExpression, nameof(JsonSerializerOptions.PropertyNameCaseInsensitive)), Expression.Constant(true, typeof(bool))),
							caseInsensitiveSwitchExpression,
							caseSensitiveSwitchExpression
						)

				);

			var loopExpression = Expression
				.Loop
				(
					loopBodyExpression,
					breakLabel
				);

			return Expression
				.Lambda<ReadDelegate<T>>
				(
					loopExpression,
					readerParameterExpression,
					modelParameterExpression,
					optionsParameterExpression
				)
				.Compile();
		}

		private static SwitchCase CreateSwitchCaseForProperty(PropertyInfo property, string propertyName, ParameterExpression readerParameterExpression, ParameterExpression modelParameterExpression, ParameterExpression optionsParameterExpression)
			=> Expression
				.SwitchCase
				(
					Expression
						.Block
						(
							Expression
								.Assign
								(
									Expression.Property(modelParameterExpression, property),
									Expression.Call(DeserializeMethod.MakeGenericMethod(property.PropertyType), readerParameterExpression, optionsParameterExpression)
								)
						),
						Expression.Constant(propertyName, typeof(string))
				);
	}
}
