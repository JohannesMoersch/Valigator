using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class SymbolExtensions
	{
		public static bool IsDerivedFrom(this INamedTypeSymbol symbol, INamedTypeSymbol attributeTypeSymbol)
		{
			if (symbol.Equals(attributeTypeSymbol, SymbolEqualityComparer.Default))
				return true;

			if (symbol.BaseType != null)
				return symbol.BaseType.IsDerivedFrom(attributeTypeSymbol);

			return false;
		}

		public static bool TryGetAttribute(this ISymbol symbol, INamedTypeSymbol attributeTypeSymbol, out AttributeData attributeData)
		{
			attributeData = symbol
				  .GetAttributes()
				  .FirstOrDefault(att => att.AttributeClass?.IsDerivedFrom(attributeTypeSymbol) ?? false);

			return attributeData != null;
		}

		public static bool HasAttribute(this ISymbol symbol, INamedTypeSymbol attributeTypeSymbol)
			=> symbol.TryGetAttribute(attributeTypeSymbol, out _);
	}
}
