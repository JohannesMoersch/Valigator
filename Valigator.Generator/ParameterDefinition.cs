using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Generator
{
	public class ParameterDefinition
	{
		public ParameterDefinition(string typeName, string name, Option<string> defaultValue = default)
		{
			_typeName = typeName ?? throw new ArgumentNullException(nameof(typeName));
			Name = name ?? throw new ArgumentNullException(nameof(name));
			DefaultValue = defaultValue;
		}

		private readonly string _typeName;

		public string Name { get; }

		public Option<string> DefaultValue { get; }

		public string GetTypeName(string valueTypeParameterName)
			=> _typeName.Replace(Data.ValueReplacementString, valueTypeParameterName);
	}
}
