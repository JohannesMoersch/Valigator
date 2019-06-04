using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core;

namespace Valigator.Generator
{
	public class SourceDefinition
	{
		private SourceDefinition(string sourceName, bool isNullable, ValueType valueType)
		{
			_sourceName = sourceName ?? throw new ArgumentNullException(nameof(sourceName));
			IsNullable = isNullable;
			ValueType = valueType;
		}

		private string _sourceName;

		public bool IsNullable { get; }

		public ValueType ValueType { get; }

		public string GetSourceName(string valueTypeParameterName)
			=> _sourceName.Replace(Constants.ValueReplacementString, valueTypeParameterName);

		public static SourceDefinition Create(Type stateValidatorType)
		{
			if (stateValidatorType.IsConstructedGenericType)
				throw new ArgumentException("Type should be a generic type definition.", nameof(stateValidatorType));

			var stateValidator = stateValidatorType
				.GetInterfaces()
				.FirstOrDefault(i => i.IsConstructedGenericType && i.GetGenericTypeDefinition() == typeof(IStateValidator<>));

			if (stateValidator == null)
				throw new ArgumentException($"Type should implement {typeof(IStateValidator<>).Name}.", nameof(stateValidatorType));

			var valueType = stateValidator.GetGenericArguments()[0];

			if (valueType.IsConstructedGenericType && valueType.GetGenericTypeDefinition() == typeof(Option<>))
				return new SourceDefinition(GetName(stateValidatorType), true, GetValueType(valueType.GetGenericArguments()[0]));

			return new SourceDefinition(GetName(stateValidatorType), false, GetValueType(valueType));
		}

		private static string GetName(Type stateValidatorType)
			=> new string(stateValidatorType.Name.TakeWhile(c => c != '`').ToArray()) + $"<{Constants.ValueReplacementString}>";

		private static ValueType GetValueType(Type valueType)
			=> valueType.IsArray ? ValueType.Array : ValueType.Value;
	}
}
