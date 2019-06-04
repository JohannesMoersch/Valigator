using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Generator
{
	public class ExtensionDefinition
	{
		public ExtensionDefinition(ValueValidators identifier, string extensionName, string validatorName, string[] genericParameters, ParameterDefinition[] parameters, string validatorConstruction, ValueType valueType, string dataType = null)
		{
			Identifier = identifier;
			ExtensionName = extensionName ?? throw new ArgumentNullException(nameof(extensionName));
			_validatorName = validatorName ?? throw new ArgumentNullException(nameof(validatorName));
			GenericParameters = genericParameters ?? throw new ArgumentNullException(nameof(genericParameters));
			Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
			_validatorConstruction = validatorConstruction ?? throw new ArgumentNullException(nameof(validatorConstruction));
			ValueType = valueType;
			DataType = Option.FromNullable(dataType);
		}

		private readonly string _validatorName;
		private readonly string _validatorConstruction;

		public ValueValidators Identifier { get; }

		public string ExtensionName { get; }

		public string[] GenericParameters { get; }

		public ParameterDefinition[] Parameters { get; }

		public ValueType ValueType { get; }

		public Option<string> DataType { get; }

		public string GetValidatorName(string valueTypeParameterName)
			=> _validatorName.Replace(Data.ValueReplacementString, valueTypeParameterName);

		public string GetValidatorConstruction(string valueTypeParameterName)
			=> _validatorConstruction.Replace(Data.ValueReplacementString, valueTypeParameterName);
	}
}
