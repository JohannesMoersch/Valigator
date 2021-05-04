using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class AttributeDataExtensions
	{
		public static bool TryGetProperty<T>(this AttributeData attributeData, string propertyName, out T value)
		{
			foreach (var kvp in attributeData.NamedArguments)
			{
				if (kvp.Key == propertyName)
				{
					value = (T)kvp.Value.Value;
					return true;
				}
			}

			value = default;
			return false;
		}

		public static T GetGenerateModelPropertyValue<T>(this AttributeData attributeData, string propertyName, INamedTypeSymbol generateModelDefaultsAttributeType)
		{
			if (attributeData.TryGetProperty(propertyName, out T value))
				return value;

			var attributeClass = attributeData.AttributeClass;

			while (attributeClass != null)
			{
				var defaults = attributeData
					.AttributeClass
					.GetAttributes()
					.FirstOrDefault(att => att.AttributeClass.Equals(generateModelDefaultsAttributeType, SymbolEqualityComparer.Default));

				if (defaults != null && defaults.TryGetProperty(propertyName, out value))
					return value;

				attributeClass = attributeClass.BaseType;
			}

			return default;
		}
	}
}
