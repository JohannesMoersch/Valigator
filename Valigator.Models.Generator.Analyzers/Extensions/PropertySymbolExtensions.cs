using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Valigator.Models.Generator.Analyzers.Extensions
{
	public static class PropertySymbolExtensions
	{
		public static bool IsEligibleModelDefinitionProperty(this IPropertySymbol property, CancellationToken cancellationToken) 
			=> 
			!property.IsStatic &&
			property.DeclaredAccessibility == Accessibility.Public &&
			property.GetMethod?.DeclaredAccessibility == Accessibility.Public &&
			property.GetDeclarationSyntax(cancellationToken).Type.IsModelDefinitionProperty();

		public static bool IsModelDefinitionProperty(this IPropertySymbol property, CancellationToken cancellationToken)
			=> property.GetDeclarationSyntax(cancellationToken).Type.IsModelDefinitionProperty();

		public static PropertyDeclarationSyntax GetDeclarationSyntax(this IPropertySymbol property, CancellationToken cancellationToken)
			=> (PropertyDeclarationSyntax)property
				.DeclaringSyntaxReferences
				.First()
				.GetSyntax(cancellationToken);
	}
}
