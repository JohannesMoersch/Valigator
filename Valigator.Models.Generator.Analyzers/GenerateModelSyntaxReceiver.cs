using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Models.Generator.Analyzers
{
	public sealed class GenerateModelSyntaxReceiver : ISyntaxReceiver
	{
		private List<ClassDeclarationSyntax> _candidates = new List<ClassDeclarationSyntax>();
		public IReadOnlyList<ClassDeclarationSyntax> Candidates => _candidates;

		public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
		{
			if (syntaxNode is ClassDeclarationSyntax classDeclarationSyntax)
			{
				var generateModelAttributes = classDeclarationSyntax
					.AttributeLists
					.SelectMany(list => list.Attributes)
					.Where(att => att.Name.ToString() == "GenerateModel" || att.Name.ToString() == "GenerateModelAttribute");

				if (generateModelAttributes.Any())
					_candidates.Add(classDeclarationSyntax);
			}
		}
	}
}
