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
		public static bool IsEligibleModelDefinitionProperty(this IPropertySymbol property, INamedTypeSymbol modelDefinitionPropertyType, CancellationToken cancellationToken)
		{
			var propertySyntax = property.GetDeclarationSyntax(cancellationToken);

			return
				!property.IsStatic &&
				property.DeclaredAccessibility == Accessibility.Public &&
				property.GetMethod?.DeclaredAccessibility == Accessibility.Public &&
				propertySyntax.Type.IsModelDefinitionProperty();
		}

		public static PropertyDeclarationSyntax GetDeclarationSyntax(this IPropertySymbol property, CancellationToken cancellationToken)
			=> (PropertyDeclarationSyntax)property
				.DeclaringSyntaxReferences
				.First()
				.GetSyntax(cancellationToken);
	}
}
