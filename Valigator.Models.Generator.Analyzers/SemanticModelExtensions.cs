using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class SemanticModelExtensions
	{
		public static IEnumerable<INamespaceOrTypeSymbol> LookupNamespaceAndTypeSymbols(this SemanticModel semanticModel, string[] namespaceParts, string[] parentClasses)
		{
			INamespaceOrTypeSymbol parentSymbol = null;

			foreach (var ns in namespaceParts)
			{
				var childNamespace = semanticModel
					.LookupNamespacesAndTypes(0, parentSymbol, ns)
					.FirstOrDefault() as INamespaceSymbol;

				if (childNamespace == null)
					yield break;

				yield return childNamespace;

				parentSymbol = childNamespace;
			}

			foreach (var parentClass in parentClasses)
			{
				var childClass = semanticModel
					.LookupNamespacesAndTypes(0, parentSymbol, parentClass)
					.FirstOrDefault() as ITypeSymbol;

				if (childClass == null)
					yield break;

				yield return childClass;

				parentSymbol = childClass;
			}
		}
	}
}
