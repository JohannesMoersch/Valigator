using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	internal static class TypeSymbolExtensions
	{
		public static string GetFullContainingNamespace(this ITypeSymbol typeSymbol)
			=> typeSymbol.ContainingNamespace.GetFullContainingNamespace();

		private static string GetFullContainingNamespace(this INamespaceSymbol namespaceSymbol)
			=> namespaceSymbol.ContainingNamespace != null && !namespaceSymbol.ContainingNamespace.IsGlobalNamespace
				? $"{namespaceSymbol.ContainingNamespace.GetFullContainingNamespace()}.{namespaceSymbol.Name}"
				: namespaceSymbol.Name;
	}
}
