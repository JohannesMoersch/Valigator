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
		public static PropertyDeclarationSyntax GetDeclarationSyntax(this IPropertySymbol property, CancellationToken cancellationToken)
			=> (PropertyDeclarationSyntax)property
				.DeclaringSyntaxReferences
				.First()
				.GetSyntax(cancellationToken);
	}
}
