using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class PropertyDeclarationSyntaxExtensions
	{
		public static bool IsPublic(this PropertyDeclarationSyntax property)
			=> property
				.Modifiers
				.Any(modifier => modifier.IsKind(SyntaxKind.PublicKeyword));

		public static bool TryGetGetAccessor(this PropertyDeclarationSyntax property, out AccessorDeclarationSyntax getAccessor)
		{
			getAccessor = property.AccessorList?.Accessors.FirstOrDefault(accessor => accessor.IsKind(SyntaxKind.GetKeyword));

			return getAccessor != null;
		}

		public static bool TryGetSetAccessor(this PropertyDeclarationSyntax property, out AccessorDeclarationSyntax setAccessor)
		{
			setAccessor = property.AccessorList?.Accessors.FirstOrDefault(accessor => accessor.IsKind(SyntaxKind.SetKeyword));

			return setAccessor != null;
		}

		public static bool IsModelDefinitionProperty(this TypeSyntax type)
		{
			if (type.IsPropertyNameSyntax())
				return true;

			if (type is QualifiedNameSyntax propertyNameSyntax && propertyNameSyntax.Right.IsPropertyNameSyntax())
			{
				if (propertyNameSyntax.Left.IsModelDefinitionNameSyntax())
					return true;

				if (propertyNameSyntax.Left is QualifiedNameSyntax modelNameSyntax && modelNameSyntax.Right.IsModelDefinitionNameSyntax())
				{
					if (modelNameSyntax.Left.IsNamespaceSyntax("Models"))
						return true;

					if (modelNameSyntax.Left is QualifiedNameSyntax namespaceSyntax && namespaceSyntax.Right.IsNamespaceSyntax("Models"))
					{
						if (namespaceSyntax.Left.IsNamespaceSyntax("Valigator"))
							return true;
					}
				}
			}

			return false;
		}

		private static bool IsPropertyNameSyntax(this TypeSyntax type)
			=> type is GenericNameSyntax genericName && genericName.Identifier.Text == "Property" && genericName.TypeArgumentList.Arguments.Count == 1;

		private static bool IsModelDefinitionNameSyntax(this TypeSyntax type)
			=> type is GenericNameSyntax genericName && genericName.Identifier.Text == "ModelDefinition" && genericName.TypeArgumentList.Arguments.Count == 1;

		private static bool IsNamespaceSyntax(this TypeSyntax type, string ns)
			=> type is IdentifierNameSyntax identifierName && identifierName.Identifier.Text == ns;
	}
}
