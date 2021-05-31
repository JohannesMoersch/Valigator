using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Valigator.Models.Generator.Analyzers
{
	public static class SyntaxNodeExtensions
	{
		public static bool TryGetPropertyAndExpressionForPropertyAssignment(this SyntaxNode syntaxNode, SemanticModel semanticModel, CancellationToken cancellationToken, out IPropertySymbol propertySymbol, out ExpressionSyntax expressionSyntax)
		{
			if (syntaxNode is ArrowExpressionClauseSyntax arrowExpression)
			{
				expressionSyntax = arrowExpression.Expression;

				var propertyDeclarationSyntax = arrowExpression
					.Ancestors()
					.OfType<PropertyDeclarationSyntax>()
					.FirstOrDefault();

				propertySymbol = semanticModel.GetDeclaredSymbol(propertyDeclarationSyntax, cancellationToken);

				return true;
			}
			else if (syntaxNode is EqualsValueClauseSyntax equalsValue)
			{
				expressionSyntax = equalsValue.Value;

				var propertyDeclarationSyntax = equalsValue
					.Ancestors()
					.OfType<PropertyDeclarationSyntax>()
					.FirstOrDefault();

				propertySymbol = semanticModel.GetDeclaredSymbol(propertyDeclarationSyntax, cancellationToken);

				return true;
			}
			else if (syntaxNode is AssignmentExpressionSyntax assignmentExpression)
			{
				expressionSyntax = assignmentExpression.Right;

				propertySymbol = semanticModel
					.GetSymbolInfo(assignmentExpression.Left, cancellationToken)
					.Symbol as IPropertySymbol;

				return true;
			}
		
			propertySymbol = null;
			expressionSyntax = null;

			return false;
		}
	}
}
