using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class TypeDeclarationSyntaxExtensions
	{
		public static bool IsPartial(this TypeDeclarationSyntax typeDeclaration)
			=> typeDeclaration
				.Modifiers
				.Any(o => o.IsKind(SyntaxKind.PartialKeyword));

		public static ClassDeclarationSyntax ToClassDeclarationSyntax(this TypeDeclarationSyntax typeSyntax)
			=> SyntaxFactory
				.ClassDeclaration
				(
					typeSyntax.AttributeLists,
					typeSyntax.Modifiers,
					SyntaxFactory.Token(SyntaxKind.ClassKeyword),
					typeSyntax.Identifier, 
					typeSyntax.TypeParameterList, 
					typeSyntax.BaseList,
					typeSyntax.ConstraintClauses,
					typeSyntax.OpenBraceToken,
					typeSyntax.Members,
					typeSyntax.CloseBraceToken,
					typeSyntax.SemicolonToken
				);

		public static StructDeclarationSyntax ToStructDeclarationSyntax(this TypeDeclarationSyntax typeSyntax)
			=> SyntaxFactory
				.StructDeclaration
				(
					typeSyntax.AttributeLists,
					typeSyntax.Modifiers,
					SyntaxFactory.Token(SyntaxKind.StructKeyword),
					typeSyntax.Identifier,
					typeSyntax.TypeParameterList,
					typeSyntax.BaseList,
					typeSyntax.ConstraintClauses,
					typeSyntax.OpenBraceToken,
					typeSyntax.Members,
					typeSyntax.CloseBraceToken,
					typeSyntax.SemicolonToken
				);
	}
}
