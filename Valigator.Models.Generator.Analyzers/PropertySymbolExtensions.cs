using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class PropertySymbolExtensions
	{
		public static PropertyDeclarationSyntax GetDeclarationSyntax(this IPropertySymbol property)
			=> (PropertyDeclarationSyntax)property
				.DeclaringSyntaxReferences
				.First()
				.GetSyntax();
	}
}
