using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class SemanticModelExtensions
	{
		public static INamespaceOrTypeSymbol[] LookupNamespaceAndTypeSymbols(this SemanticModel semanticModel, string[] namespaceParts, string[] classes)
		{
			var symbols = InternalLookupNamespaceAndTypeSymbols(semanticModel, namespaceParts, classes).ToArray();

			return Enumerable
				.Range(0, namespaceParts.Length + classes.Length)
				.Select(i => i < symbols.Length ? symbols[i] : null)
				.ToArray();
		}

		private static IEnumerable<INamespaceOrTypeSymbol> InternalLookupNamespaceAndTypeSymbols(SemanticModel semanticModel, string[] namespaceParts, string[] classes)
		{
			INamespaceOrTypeSymbol parentSymbol = null;

			foreach (var symbolName in namespaceParts.Concat(classes))
			{
				parentSymbol = semanticModel
					   .LookupNamespacesAndTypes(0, parentSymbol, symbolName)
					   .FirstOrDefault() as INamespaceOrTypeSymbol;

				if (parentSymbol == null)
					yield break;

				yield return parentSymbol;
			}
		}
	}
}
