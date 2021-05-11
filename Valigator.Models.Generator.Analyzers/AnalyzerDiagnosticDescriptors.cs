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

		public static DiagnosticDescriptor ModelDefinitionPropertyDoesNotHaveGetter { get; } = new DiagnosticDescriptor
		(
			id: "VL0002",
			title: "Model Definition Property Missing Getter",
			messageFormat: "Model definition public property does not have a public getter.",
			category: "Generator",
			DiagnosticSeverity.Warning,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelDefinitionPropertyHasSetter { get; } = new DiagnosticDescriptor
		(
			id: "VL0003",
			title: "Model Definition Property Has Setter",
			messageFormat: "Model definition public property has a public setter.",
			category: "Generator",
			DiagnosticSeverity.Warning,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelDefinitionModelIdentifierMatchFailed { get; } = new DiagnosticDescriptor
		(
			id: "VL0004",
			title: "Model Definition Model Identifier Match Failed",
			messageFormat: "Model definition {0} match on \"{1}\" using \"{2}\" failed. {3}",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelDefinitionModelIdentifierInvalid { get; } = new DiagnosticDescriptor
		(
			id: "VL0005",
			title: "Model Definition Model Identifier Invalid",
			messageFormat: "Model definition {0} identifier \"{1}\" is invalid.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ParentClassNotPartialClass { get; } = new DiagnosticDescriptor
		(
			id: "VL0006",
			title: "Model Parent Class Not Partial",
			messageFormat: "Generated model parent {0} not partial.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);
	}
}
