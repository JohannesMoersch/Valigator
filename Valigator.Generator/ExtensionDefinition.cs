using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Generator
{
	public class ExtensionDefinition
	{
		public ExtensionDefinition(ValidatorDefinition validator, string extensionName, ParameterDefinition[] parameters, string dataType = null)
		{
			Validator = validator;
			ExtensionName = extensionName ?? throw new ArgumentNullException(nameof(extensionName));
			Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
			DataType = Option.FromNullable(dataType);

			if (DataType.Match(value => Validator.DataType.Match(newValue => newValue != value, () => false), () => Validator.DataType.Match(_ => true, () => false)))
				throw new ArgumentException("Datatype of validator is incompatible with datatype of extension.");
		}

		public ValidatorDefinition Validator { get; }

		public string ExtensionName { get; }

		public ParameterDefinition[] Parameters { get; }

		public Option<string> DataType { get; }
	}
}
