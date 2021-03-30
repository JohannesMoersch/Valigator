using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class AnalyzerDiagnosticDescriptors
	{
		public static DiagnosticDescriptor ModelDefinitionNotPartialClass { get; } = new DiagnosticDescriptor
		(
			id: "VL0001",
			title: "Model Definition Not Partial",
			messageFormat: "Model definition must be declared as partial.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelDefinitionPropertyHasSetter { get; } = new DiagnosticDescriptor
		(
			id: "VL0002",
			title: "Model Definition Property Has Setter",
			messageFormat: "Model definition property has a public setter.",
			category: "Generator",
			DiagnosticSeverity.Warning,
			isEnabledByDefault: true
		);
	}
}
