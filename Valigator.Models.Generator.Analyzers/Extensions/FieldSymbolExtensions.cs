using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Valigator.Models.Generator.Analyzers.Extensions
{
	public static class FieldSymbolExtensions
	{
		public static VariableDeclaratorSyntax GetDeclarationSyntax(this IFieldSymbol field, CancellationToken cancellationToken)
			=> (VariableDeclaratorSyntax)field
				.DeclaringSyntaxReferences
				.First()
				.GetSyntax(cancellationToken);
	}
}
