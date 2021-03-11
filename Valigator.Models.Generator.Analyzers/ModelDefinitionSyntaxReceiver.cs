using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.SourceGeneration
{
	public sealed class ModelDefinitionSyntaxReceiver : ISyntaxReceiver
	{
		private List<ClassDeclarationSyntax> _candidates = new List<ClassDeclarationSyntax>();
		public IReadOnlyList<ClassDeclarationSyntax> Candidates => _candidates;

		public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
		{
			if (syntaxNode is ClassDeclarationSyntax classDeclarationSyntax)
			{
				var generateModelAttributes = classDeclarationSyntax
					.AttributeLists
					.SelectMany(list => list.Attributes);
					//.Where(att => att.Name.ToString() == nameof(GenerateModelAttribute) || att.Name.ToString() == nameof(GenerateModelAttribute).Substring(0, nameof(GenerateModelAttribute).Length - "Attribute".Length));

				if (generateModelAttributes.Any())
					_candidates.Add(classDeclarationSyntax);
			}
		}
	}
}
