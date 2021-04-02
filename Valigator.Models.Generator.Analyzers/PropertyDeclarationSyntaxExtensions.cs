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
				.Any(modifier => modifier.Text == "public");

		public static bool TryGetGetAccessor(this PropertyDeclarationSyntax property, out AccessorDeclarationSyntax getAccessor)
		{
			getAccessor = property.AccessorList?.Accessors.FirstOrDefault(accessor => accessor.Keyword.Text == "get");

			return getAccessor != null;
		}

		public static bool TryGetSetAccessor(this PropertyDeclarationSyntax property, out AccessorDeclarationSyntax setAccessor)
		{
			setAccessor = property.AccessorList?.Accessors.FirstOrDefault(accessor => accessor.Keyword.Text == "set");

			return setAccessor != null;
		}
	}
}
