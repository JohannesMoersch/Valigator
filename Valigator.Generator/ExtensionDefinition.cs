using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Generator
{
	public class ExtensionDefinition
	{
		public ExtensionDefinition(string extensionName, string validatorName, string[] genericParameters, ParameterDefinition[] parameters, string validatorConstruction, ValueType valueType)
		{
			ExtensionName = extensionName ?? throw new ArgumentNullException(nameof(extensionName));
			_validatorName = validatorName ?? throw new ArgumentNullException(nameof(validatorName));
			GenericParameters = genericParameters ?? throw new ArgumentNullException(nameof(genericParameters));
			Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
			_validatorConstruction = validatorConstruction ?? throw new ArgumentNullException(nameof(validatorConstruction));
			ValueType = valueType;
		}

		private readonly string _validatorName;
		private readonly string _validatorConstruction;

		public string ExtensionName { get; }

		public string[] GenericParameters { get; }

		public ParameterDefinition[] Parameters { get; }

		public ValueType ValueType { get; }

		public string GetValidatorName(string valueTypeParameterName)
			=> _validatorName.Replace(Constants.ValueReplacementString, valueTypeParameterName);

		public string GetValidatorConstruction(string valueTypeParameterName)
			=> _validatorConstruction.Replace(Constants.ValueReplacementString, valueTypeParameterName);
	}
}
