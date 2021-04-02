using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class AccessorDeclarationSyntaxExtensions
	{
		public static bool IsPrivate(this AccessorDeclarationSyntax accessor)
			=> accessor
				.Modifiers
				.Any(modifier => modifier.Text == "private");
	}
}
