﻿using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class SymbolExtensions
	{
		public static bool TryGetAttribute(this ISymbol symbol, INamedTypeSymbol attributeTypeSymbol, out AttributeData attributeData)
		{
			attributeData = symbol
				  .GetAttributes()
				  .FirstOrDefault(att => att.AttributeClass?.Equals(attributeTypeSymbol, SymbolEqualityComparer.Default) ?? false);

			return attributeData != null;
		}

		public static bool HasAttribute(this ISymbol symbol, INamedTypeSymbol attributeTypeSymbol)
			=> symbol.TryGetAttribute(attributeTypeSymbol, out _);
	}
}