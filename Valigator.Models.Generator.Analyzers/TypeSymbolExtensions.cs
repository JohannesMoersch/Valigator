using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator
{
	internal static class TypeSymbolExtensions
	{
		public static bool HasAttribute(this ITypeSymbol typeSymbol, INamedTypeSymbol attributeTypeSymbol)
			=> typeSymbol
				.GetAttributes()
				.Any(att => att.AttributeClass?.Equals(attributeTypeSymbol, SymbolEqualityComparer.Default) ?? false);

		public static string GetFullContainingNamespace(this ITypeSymbol typeSymbol)
			=> typeSymbol.ContainingNamespace.GetFullContainingNamespace();

		private static string GetFullContainingNamespace(this INamespaceSymbol namespaceSymbol)
			=> namespaceSymbol.ContainingNamespace != null && !namespaceSymbol.ContainingNamespace.IsGlobalNamespace
				? $"{namespaceSymbol.ContainingNamespace.GetFullContainingNamespace()}.{namespaceSymbol.Name}"
				: namespaceSymbol.Name;
	}
}
