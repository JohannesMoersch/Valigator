﻿using Microsoft.CodeAnalysis;
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

		public static DiagnosticDescriptor ModelDefinitionFieldIsPropertyType { get; } = new DiagnosticDescriptor
		(
			id: "VL0004",
			title: "Model Definition Field Is Property Type",
			messageFormat: "Initialized public field on model definition is of type \"Property<>\". Did you mean to create an expression bodied property instead of a field?",
			category: "Generator",
			DiagnosticSeverity.Warning,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelDefinitionModelIdentifierMatchFailed { get; } = new DiagnosticDescriptor
		(
			id: "VL0005",
			title: "Model Definition Model Identifier Match Failed",
			messageFormat: "Model definition {0} match on \"{1}\" using \"{2}\" failed.{3}",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelDefinitionModelIdentifierInvalid { get; } = new DiagnosticDescriptor
		(
			id: "VL0006",
			title: "Model Definition Model Identifier Invalid",
			messageFormat: "Model definition {0} identifier \"{1}\" is invalid.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelDefinitionParentNotPartialClass { get; } = new DiagnosticDescriptor
		(
			id: "VL0007",
			title: "Model Definition Parent Not Partial",
			messageFormat: "Model definition {0} not partial.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelDefinitionConstructorInaccessible { get; } = new DiagnosticDescriptor
		(
			id: "VL0008",
			title: "Model Definition Constructor Inaccessible",
			messageFormat: "Model definition cannot have a private or protected parameterless constructor.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelDefinitionManualBaseClass { get; } = new DiagnosticDescriptor
		(
			id: "VL0009",
			title: "Model Definition Has Manual Base Class",
			messageFormat: "Model definition cannot have a manually defined base class.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelDefinitionParentsGenerics { get; } = new DiagnosticDescriptor
		(
			id: "VL0010",
			title: "Model Definition Has Generic Parents",
			messageFormat: "Model definition {0} generic.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelDefinitionPropertyTypeMismatch { get; } = new DiagnosticDescriptor
		(
			id: "VL0011",
			title: "Model Definition Property Type Mismatch",
			messageFormat: "Model definition property type is incorrect.",
			category: "Generator",
			DiagnosticSeverity.Warning,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelTypeMismatch { get; } = new DiagnosticDescriptor
		(
			id: "VL0012",
			title: "Model Type Mismatch",
			messageFormat: "Manual implementation is not declared as a {0} as defined by the model definition.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelNameConflict { get; } = new DiagnosticDescriptor
		(
			id: "VL0013",
			title: "Model Name Conflict",
			messageFormat: "Another member is conflicting with generated model name \"{0}\".",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelNotPartial { get; } = new DiagnosticDescriptor
		(
			id: "VL0014",
			title: "Model Not Partial",
			messageFormat: "Model {0} is not partial.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelParentNotPartial { get; } = new DiagnosticDescriptor
		(
			id: "VL0015",
			title: "Model Parent Not Partial",
			messageFormat: "Model {0} not partial.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelAndModelParentNotPartial { get; } = new DiagnosticDescriptor
		(
			id: "VL0016",
			title: "Model And Model Parent Not Partial",
			messageFormat: "Model {0} and {1} are not partial.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelTypeParameterMismatch { get; } = new DiagnosticDescriptor
		(
			id: "VL0017",
			title: "Model Type Generic Parameter Mismatch",
			messageFormat: "Model type generic {0} not match model definition type generic {1}.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor ModelTypeParameterConstraintMismatch { get; } = new DiagnosticDescriptor
		(
			id: "VL0018",
			title: "Model Type Generic Parameter Constraints Mismatch",
			messageFormat: "Model type generic constraints do not match model definition type generic constraints.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public static DiagnosticDescriptor GenerateModelAttributePropertiesSet { get; } = new DiagnosticDescriptor
		(
			id: "VL0019",
			title: "GenerateModelAttribute Properties Set",
			messageFormat: "Setting GenerateModelAttribute properties outside of attribute usage does not work for Valigator model generator. Use GenerateModelDefaultsAttribute on derived attribute instead.",
			category: "Generator",
			DiagnosticSeverity.Warning,
			isEnabledByDefault: true
		);
	}
}
