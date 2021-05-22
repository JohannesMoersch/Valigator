using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class SemanticModelExtensions
	{
		public static INamespaceOrTypeSymbol[] LookupNamespaceAndTypeSymbols(this SemanticModel semanticModel, string[] namespaceParts, (string name, int genericCount)[] classes)
		{
			var symbols = InternalLookupNamespaceAndTypeSymbols(semanticModel, namespaceParts, classes).ToArray();

			return Enumerable
				.Range(0, namespaceParts.Length + classes.Length)
				.Select(i => i < symbols.Length ? symbols[i].OfType<INamespaceOrTypeSymbol>().FirstOrDefault() : null)
				.ToArray();
		}

		public static INamespaceOrTypeSymbol[][] LookupAllNamespaceAndTypeSymbols(this SemanticModel semanticModel, string[] namespaceParts, (string name, int genericCount)[] classes)
		{
			var symbols = InternalLookupNamespaceAndTypeSymbols(semanticModel, namespaceParts, classes).ToArray();

			return Enumerable
				.Range(0, namespaceParts.Length + classes.Length)
				.Select(i => i < symbols.Length ? symbols[i].OfType<INamespaceOrTypeSymbol>().ToArray() : Array.Empty<INamespaceOrTypeSymbol>())
				.ToArray();
		}

		private static IReadOnlyList<ISymbol[]> InternalLookupNamespaceAndTypeSymbols(SemanticModel semanticModel, string[] namespaceParts, (string name, int genericCount)[] classes)
		{
			IEnumerable<INamespaceOrTypeSymbol> parentSymbols = new INamespaceOrTypeSymbol[] { null };

			var symbols = new List<ISymbol[]>();

			foreach (var symbolName in namespaceParts.Select(p => (name: p, genericCount: (int?)null)).Concat(classes.Select(c => (c.name, genericCount: (int?)c.genericCount))))
			{
				var matches = parentSymbols
					.SelectMany(s => semanticModel.LookupSymbols(0, s, symbolName.name))
					.Where(s =>  symbolName.genericCount is int count ? s is INamedTypeSymbol type && type.TypeParameters.Length == count : true)
					.ToArray();

				if (!matches.Any())
					break;

				symbols.Add(matches);
				
				parentSymbols = matches.OfType<INamespaceOrTypeSymbol>();
			}

			return symbols;
		}
	}
}
