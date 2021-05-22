using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Valigator.Models.Generator.Analyzers
{
	public static class ClassDeclarationSyntaxExtensions
	{
		public static bool TryGetBaseTypeSyntax(this ClassDeclarationSyntax classDeclarationSyntax, SemanticModel semanticModel, CancellationToken cancellationToken, out BaseTypeSyntax baseTypeSyntax)
		{
			if (classDeclarationSyntax.BaseList != null && classDeclarationSyntax.BaseList.Types.Where(t => t.Type is PredefinedTypeSyntax || (semanticModel.GetTypeInfo(t.Type, cancellationToken).Type is INamedTypeSymbol type && type.TypeKind == TypeKind.Class)).TryGetFirst(out baseTypeSyntax))
				return true;

			baseTypeSyntax = null;
			return false;
		}

	}
}
