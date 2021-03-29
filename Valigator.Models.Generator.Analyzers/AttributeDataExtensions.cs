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
	}
}
