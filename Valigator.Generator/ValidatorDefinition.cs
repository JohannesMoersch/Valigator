using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Generator
{
	public class ValidatorDefinition
	{
		private readonly string _validatorName;

		public ValidatorDefinition(ValidatorGroups valueValidator, string validatorName, ValueType valueType, Option<string> dataType)
		{
			Identifier = valueValidator;
			_validatorName = validatorName ?? throw new ArgumentNullException(nameof(validatorName));
			ValueType = valueType;
			DataType = dataType;
		}

		public ValidatorGroups Identifier { get; }

		public ValueType ValueType { get; }

		public Option<string> DataType { get; }

		public string GetValidatorName(string valueTypeParameterName)
			=> _validatorName.Replace(Data.ValueReplacementString, valueTypeParameterName);
	}
}
