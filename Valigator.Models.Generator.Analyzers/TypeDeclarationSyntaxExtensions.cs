using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator
{
	public static class TypeDeclarationSyntaxExtensions
	{
		public static bool IsPartial(this TypeDeclarationSyntax typeDeclaration)
			=> typeDeclaration
				.Modifiers
				.Any(o => o.Text == "partial");
	}
}
