using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class AttributeDataExtensions
	{
		public static T GetProperty<T>(this AttributeData attributeData, string propertyName)
			=> (T)attributeData
				.NamedArguments
				.First(prop => prop.Key == propertyName)
				.Value
				.Value;
	}
}
