using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers.Extensions
{
	public static class ExpressionSyntaxExtensions
	{
		public static ITypeSymbol GetModelPropertyArgumentType(this ExpressionSyntax expressionSyntax, SemanticModel semanticModel, INamedTypeSymbol modelPropertyDataType)
			=> (semanticModel.GetSymbolInfo(expressionSyntax).Symbol as IMethodSymbol ?? semanticModel.GetSymbolInfo(expressionSyntax.Parent).Symbol as IMethodSymbol)
				?.ReturnType
				.AllInterfaces
				.FirstOrDefault(i => i.OriginalDefinition.Equals(modelPropertyDataType, SymbolEqualityComparer.Default))
				?.TypeArguments[1];
	}
}
