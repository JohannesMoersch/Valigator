﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;
using Valigator.Models.Generator.Analyzers.Extensions;

namespace Valigator.Models.Generator.Analyzers
{
	[DiagnosticAnalyzer(LanguageNames.CSharp)]
	public class ModelDefinitionAnalyzer : DiagnosticAnalyzer
	{
		public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics 
			=> ImmutableArray
				.Create
				(
					AnalyzerDiagnosticDescriptors.ModelDefinitionNotPartialClass, 
					AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyDoesNotHaveGetter, 
					AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyHasSetter,
					AnalyzerDiagnosticDescriptors.ModelDefinitionFieldIsPropertyType,
					AnalyzerDiagnosticDescriptors.ModelDefinitionModelIdentifierMatchFailed,
					AnalyzerDiagnosticDescriptors.ModelDefinitionModelIdentifierInvalid,
					AnalyzerDiagnosticDescriptors.ModelDefinitionParentNotPartialClass,
					AnalyzerDiagnosticDescriptors.ModelDefinitionConstructorInaccessible,
					AnalyzerDiagnosticDescriptors.ModelDefinitionManualBaseClass,
					AnalyzerDiagnosticDescriptors.ModelDefinitionParentsGenerics,
					AnalyzerDiagnosticDescriptors.ModelNotClassOrStruct,
					AnalyzerDiagnosticDescriptors.ModelNotPartial,
					AnalyzerDiagnosticDescriptors.ModelParentNotPartial,
					AnalyzerDiagnosticDescriptors.ModelAndModelParentNotPartial,
					AnalyzerDiagnosticDescriptors.ModelTypeParameterMismatch,
					AnalyzerDiagnosticDescriptors.ModelTypeParameterConstraintMismatch,
					AnalyzerDiagnosticDescriptors.ModelDefinitionTypeMismatch
				);

		private CodeDomProvider CodeProvider { get; } = CodeDomProvider.CreateProvider("csharp");

		public override void Initialize(AnalysisContext context)
		{
			context.EnableConcurrentExecution();

			context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

			context
				.RegisterSyntaxNodeAction
				(
					context =>
					{
						GetTypes(context, out var generateModelAttributeType, out var generateModelDefaultsAttributeType, out var modelPropertyDataType);

						var classSyntax = (ClassDeclarationSyntax)context.Node;

						var typeSymbol = context
							.SemanticModel
							.GetDeclaredSymbol(classSyntax, context.CancellationToken);

						if (typeSymbol.TryGetAttribute(generateModelAttributeType, out var generateModelAttribute))
						{
							CheckForNotPartialClass(context, classSyntax, out var isPartial);

							CheckForManuallyDefinedBaseClass(context, classSyntax, out var hasManuallyDefinedBaseClass);

							CheckForInaccessibleParameterlessConstructor(context, typeSymbol, out var hasInaccessibleParameterlessConstructor);

							CheckForParentsNotPartialClass(context, classSyntax, typeSymbol);

							CheckForGenericParents(context, classSyntax, typeSymbol, out var hasGenericParents);

							CheckForModelOrParentsNotPartialClassOrModelNotClassOrStructOrModelTypeMismatch(context, classSyntax, typeSymbol, generateModelAttribute, generateModelDefaultsAttributeType, isPartial && !hasManuallyDefinedBaseClass && !hasInaccessibleParameterlessConstructor && !hasGenericParents);

							CheckForModelIdentifierIssues(context, classSyntax, typeSymbol, generateModelAttribute, generateModelDefaultsAttributeType);

							CheckForPropertyFields(context, typeSymbol, context.CancellationToken);

							foreach (var propertySymbol in GetPublicModelDefinitionProperties(typeSymbol, context.CancellationToken))
							{
								CheckForPropertyDoesNotHaveGetter(context, propertySymbol, context.CancellationToken);

								CheckForPropertyHasSetter(context, propertySymbol, context.CancellationToken);
							}
						}
					},
					SyntaxKind.ClassDeclaration
				);
		}

		private static void CheckForPropertyFields(SyntaxNodeAnalysisContext context, INamedTypeSymbol typeSymbol, CancellationToken cancellationToken)
		{
			foreach (var fieldSyntax in GetPublicFieldsOfPropertyType(typeSymbol, cancellationToken))
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionFieldIsPropertyType,
							Location.Create(fieldSyntax.SyntaxTree, fieldSyntax.Identifier.Span)
						)
					);
			}
		}

		private static IEnumerable<VariableDeclaratorSyntax> GetPublicFieldsOfPropertyType(INamedTypeSymbol typeSymbol, CancellationToken cancellationToken)
			=> typeSymbol
				.GetFields()
				.Where(field => !field.IsStatic)
				.Where(field => field.DeclaredAccessibility == Accessibility.Public)
				.Select(field => field.GetDeclarationSyntax(cancellationToken))
				.Where(field => field.Initializer != null)
				.Where(field => ((VariableDeclarationSyntax)field.Parent).Type.IsModelDefinitionProperty());

		private static void GetTypes(SyntaxNodeAnalysisContext context, out INamedTypeSymbol generateModelAttributeType, out INamedTypeSymbol generateModelDefaultsAttributeType, out INamedTypeSymbol modelPropertyDataType)
		{
			generateModelAttributeType = context.Compilation.GetTypeByMetadataName(ExternalConstants.GenerateModelAttribute_TypeName);
			generateModelDefaultsAttributeType = context.Compilation.GetTypeByMetadataName(ExternalConstants.GenerateModelDefaultsAttribute_TypeName);
			modelPropertyDataType = context.Compilation.GetTypeByMetadataName(ExternalConstants.IModelPropertyData_TypeName);
		}

		private static IEnumerable<IPropertySymbol> GetPublicModelDefinitionProperties(INamedTypeSymbol typeSymbol, CancellationToken cancellationToken)
			=> typeSymbol
				.GetProperties()
				.Where(property => property.IsEligibleModelDefinitionProperty(cancellationToken));

		private void CheckForNotPartialClass(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax, out bool isPartial)
		{
			isPartial = classSyntax.IsPartial();

			if (!isPartial)
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionNotPartialClass,
							Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span)
						)
					);
			}
		}

		private void CheckForManuallyDefinedBaseClass(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax, out bool hasManuallyDefinedBaseClass)
		{
			hasManuallyDefinedBaseClass = classSyntax.TryGetBaseTypeSyntax(context.SemanticModel, context.CancellationToken, out var baseTypeSyntax);

			if (hasManuallyDefinedBaseClass)
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionManualBaseClass,
							Location.Create(baseTypeSyntax.SyntaxTree, baseTypeSyntax.Span)
						)
					);
			}
		}

		private void CheckForInaccessibleParameterlessConstructor(SyntaxNodeAnalysisContext context, INamedTypeSymbol typeSymbol, out bool hasInaccessibleParameterlessConstructor)
		{
			hasInaccessibleParameterlessConstructor = typeSymbol.TryGetPrivateOrProtectedParameterlessConstructor(out var constructor);

			if (hasInaccessibleParameterlessConstructor)
			{
				var constructorSyntax = (ConstructorDeclarationSyntax)constructor
					.DeclaringSyntaxReferences
					.First()
					.GetSyntax(context.CancellationToken);

				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionConstructorInaccessible,
							Location.Create(constructorSyntax.SyntaxTree, constructorSyntax.Identifier.Span)
						)
					);
			}
		}

		private void CheckForParentsNotPartialClass(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax, INamedTypeSymbol typeSymbol)
		{
			var nonPartialParentClasses = (typeSymbol.ContainingType?.GetContainingTypeHierarchy() ?? Enumerable.Empty<ITypeSymbol>())
				.Where(t => t.GetDeclaringSyntaxReferences(context.CancellationToken).Any(s => !s.IsPartial()))
				.ToArray();

			if (nonPartialParentClasses.Any())
			{
				var messageParameter = nonPartialParentClasses.Length > 1
					? $"parents {nonPartialParentClasses.Select(t => $"\"{t.Name}\"").JoinListWithOxfordComma()} are"
					: $"parent \"{nonPartialParentClasses[0].Name}\" is";

				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionParentNotPartialClass,
							Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
							messageParameter
						)
					);
			}
		}

		private void CheckForGenericParents(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax, INamedTypeSymbol typeSymbol, out bool hasGenericParents)
		{
			var genericParentClasses = typeSymbol
				.GetGenericParents()
				.ToArray();

			hasGenericParents = genericParentClasses.Any();

			if (hasGenericParents)
			{
				var messageParameter = genericParentClasses.Length > 1
					? $"parents {genericParentClasses.Select(t => $"\"{t.Name}\"").JoinListWithOxfordComma()} are"
					: $"parent \"{genericParentClasses[0].Name}\" is";

				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionParentsGenerics,
							Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
							messageParameter
						)
					);
			}
		}

		private void CheckForModelOrParentsNotPartialClassOrModelNotClassOrStructOrModelTypeMismatch(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax, INamedTypeSymbol typeSymbol, AttributeData generateModelAttribute, INamedTypeSymbol generateModelDefaultsAttributeType, bool checkTypeConstraints)
		{
			var typeName = typeSymbol.GetFullNameWithNamespace("+", false);

			if (generateModelAttribute.TryGetGeneratedModelNamespace(typeName, generateModelDefaultsAttributeType, out var modelNamespace, out _, out _) && generateModelAttribute.TryGetGeneratedModelParentClasses(typeName, generateModelDefaultsAttributeType, out var modelParentClasses, out _, out _) && generateModelAttribute.TryGetGeneratedModelName(typeName, generateModelDefaultsAttributeType, out var modelName, out _, out _))
			{
				var types = context
					.SemanticModel
					.LookupAllNamespaceAndTypeSymbols(modelNamespace, modelParentClasses.Select(p => (p, 0)).Concat(new[] { (modelName, typeSymbol.TypeParameters.Length) }).ToArray())
					.ToArray();

				var modelTypes = types.Last().OfType<INamedTypeSymbol>().ToArray();

				var modelTypeMode = generateModelAttribute.GetGenerateModelPropertyValue(ExternalConstants.GenerateModelAttribute_Type_PropertyName, generateModelDefaultsAttributeType, ExternalConstants.ModelType.Unset);

				var expectedTypeKind = modelTypeMode == ExternalConstants.ModelType.Auto
					? modelTypes.Any(t => t.TypeKind == TypeKind.Class) || modelTypes.All(t => t.TypeKind != TypeKind.Struct)
						? TypeKind.Class
						: TypeKind.Struct
					: modelTypeMode == ExternalConstants.ModelType.Struct
						? TypeKind.Struct
						: TypeKind.Class;

				if (modelTypes.Any(t => t.TypeKind != expectedTypeKind))
				{
					context
						.ReportDiagnostic
						(
							Diagnostic.Create
							(
								AnalyzerDiagnosticDescriptors.ModelDefinitionTypeMismatch,
								Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
								expectedTypeKind == TypeKind.Class ? "class" : "struct"
							)
						);
				}

				if (modelTypes.Any(s => s.TypeKind != TypeKind.Class && s.TypeKind != TypeKind.Struct))
				{
					context
						.ReportDiagnostic
						(
							Diagnostic.Create
							(
								AnalyzerDiagnosticDescriptors.ModelNotClassOrStruct,
								Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span)
							)
						);
				}
				else
				{
					var modelDefinitionParentTypes = (typeSymbol.ContainingType?.GetContainingTypeHierarchy() ?? Enumerable.Empty<ITypeSymbol>())
						.Concat(Enumerable.Repeat<INamespaceOrTypeSymbol>(null, types.Length));

					var modelParentTypes = types
						.Select(s => s.FirstOrDefault())
						.Zip(modelDefinitionParentTypes, (s1, s2) => !SymbolEqualityComparer.Default.Equals(s1, s2) ? s1 : null)
						.ToArray();

					CheckForModelOrParentsNotPartialClass(context, classSyntax, modelParentTypes);

					CheckForModelTypeParameterMismatch(context, classSyntax, typeSymbol, modelParentTypes);

					if (checkTypeConstraints)
						CheckForModelTypeConstraintMismatch(context, classSyntax, typeSymbol, modelParentTypes);
				}
			}
		}

		private void CheckForModelTypeConstraintMismatch(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax, INamedTypeSymbol typeSymbol, INamespaceOrTypeSymbol[] types)
		{
			INamedTypeSymbol model = types.Last() as INamedTypeSymbol;

			if (model != null)
			{
				var mismatched = typeSymbol
					.TypeParameters
					.Zip(model.TypeParameters, (d, m) => (definition: d, model: m))
					.Any(s => !s.definition.IsEquivalent(s.model));

				if (mismatched)
				{
					context
						.ReportDiagnostic
						(
							Diagnostic.Create
							(
								AnalyzerDiagnosticDescriptors.ModelTypeParameterConstraintMismatch,
								Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span)
							)
						);
				}
			}
		}

		private void CheckForModelTypeParameterMismatch(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax, INamedTypeSymbol typeSymbol, INamespaceOrTypeSymbol[] types)
		{
			INamedTypeSymbol model = types.Last() as INamedTypeSymbol;

			if (model != null)
			{
				var start = model.TypeParameters.Length == 1
					? "parameter"
					: "parameters";

				var middle = model.TypeParameters.Length == 1
					? "does"
					: "do";

				var modelTypeParameters = model
					.TypeParameters
					.Select(t => t.Name)
					.JoinList(", ");

				var definitionTypeParameters = typeSymbol
					.TypeParameters
					.Select(t => t.Name)
					.JoinList(", ");

				if (modelTypeParameters != definitionTypeParameters)
				{
					context
						.ReportDiagnostic
						(
							Diagnostic.Create
							(
								AnalyzerDiagnosticDescriptors.ModelTypeParameterMismatch,
								Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
								$"{start} \"<{modelTypeParameters}>\" {middle}",
								$"{start} \"<{definitionTypeParameters}>\""
							)
						);
				}
			}
		}

		private void CheckForModelOrParentsNotPartialClass(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax, INamespaceOrTypeSymbol[] types)
		{
			INamedTypeSymbol model = types.Last() as INamedTypeSymbol;

			var nonPartialModel = model?.GetDeclaringSyntaxReferences(context.CancellationToken).Any(s => !s.IsPartial()) ?? false
						? model
						: null;

			var nonPartialParentClasses = types
				.Take(types.Length - 1)
				.OfType<ITypeSymbol>()
				.Where(c => c.GetDeclaringSyntaxReferences(context.CancellationToken).Any(s => !s.IsPartial()))
				.ToArray();

			var modelMessage = nonPartialModel != null
					? $"\"{nonPartialModel.Name}\""
					: null;

			var parentClassesMessage = nonPartialParentClasses.Any()
					? nonPartialParentClasses.Length > 1
						? $"parents {nonPartialParentClasses.Select(t => $"\"{t.Name}\"").JoinListWithOxfordComma()}"
						: $"parent \"{nonPartialParentClasses[0].Name}\""
					: null;

			if (nonPartialModel != null || nonPartialParentClasses.Any())
			{
				if (!nonPartialParentClasses.Any())
				{
					context
						.ReportDiagnostic
						(
							Diagnostic.Create
							(
								AnalyzerDiagnosticDescriptors.ModelNotPartial,
								Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
								modelMessage
							)
						);
				}
				else if (nonPartialModel == null)
				{
					context
						.ReportDiagnostic
						(
							Diagnostic.Create
							(
								AnalyzerDiagnosticDescriptors.ModelParentNotPartial,
								Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
								$"{parentClassesMessage} {(nonPartialParentClasses.Length > 1 ? "are" : "is")}"
							)
						);
				}
				else
				{
					context
						.ReportDiagnostic
						(
							Diagnostic.Create
							(
								AnalyzerDiagnosticDescriptors.ModelAndModelParentNotPartial,
								Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
								modelMessage,
								parentClassesMessage
							)
						);
				}
			}
		}

		private void CheckForPropertyDoesNotHaveGetter(SyntaxNodeAnalysisContext context, IPropertySymbol propertySymbol, CancellationToken cancellationToken)
		{
			var propertySyntax = propertySymbol.GetDeclarationSyntax(cancellationToken);

			if (propertySyntax.ExpressionBody == null && (!propertySyntax.TryGetGetAccessor(out var getAccessor) || getAccessor.IsPrivate()))
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyDoesNotHaveGetter,
							Location.Create(propertySyntax.SyntaxTree, getAccessor?.Modifiers.First(modifier => modifier.IsKind(SyntaxKind.PrivateKeyword)).Span ?? propertySyntax.Identifier.Span)
						)
					);
			}
		}

		private void CheckForPropertyHasSetter(SyntaxNodeAnalysisContext context, IPropertySymbol propertySymbol, CancellationToken cancellationToken)
		{
			var propertySyntax = propertySymbol.GetDeclarationSyntax(cancellationToken);

			if (propertySyntax.TryGetSetAccessor(out var setAccessor) && !setAccessor.IsPrivate())
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyHasSetter,
							Location.Create(propertySyntax.SyntaxTree, setAccessor.Keyword.Span)
						)
					);
			}
		}

		private void CheckForModelIdentifierIssues(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax, INamedTypeSymbol typeSymbol, AttributeData generateModelAttribute, INamedTypeSymbol generateModelDefaultsAttributeType)
		{
			var fullTypeName = typeSymbol.GetFullNameWithNamespace("+", false);

			var modelNamespaceSuccess = generateModelAttribute
				.TryGetGeneratedModelNamespace
				(
					fullTypeName,
					generateModelDefaultsAttributeType,
					out var modelNamespace,
					out var modelNamespaceCaptureRegex,
					out var modelNamespaceErrorMessage
				);

			if (!modelNamespaceSuccess)
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionModelIdentifierMatchFailed,
							Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
							"model namespace",
							fullTypeName,
							modelNamespaceCaptureRegex,
							!String.IsNullOrEmpty(modelNamespaceErrorMessage) ? $" {modelNamespaceErrorMessage}" : String.Empty
						)
					);
			}
			else
				VerifyModelIdentifiers(context, classSyntax, modelNamespace, "model namespace");

			var modelParentClassesSuccess = generateModelAttribute
				.TryGetGeneratedModelParentClasses
				(
					fullTypeName,
					generateModelDefaultsAttributeType,
					out var modelParentClasses,
					out var modelParentClassesCaptureRegex,
					out var modelParentClassesErrorMessage
				);

			if (!modelParentClassesSuccess)
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionModelIdentifierMatchFailed,
							Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
							"model parent classes",
							fullTypeName,
							modelParentClassesCaptureRegex,
							!String.IsNullOrEmpty(modelParentClassesErrorMessage) ? $" {modelParentClassesErrorMessage}" : String.Empty
						)
					);
			}
			else
				VerifyModelIdentifiers(context, classSyntax, modelParentClasses, "model parent class");

			var modelNameSuccess = generateModelAttribute
				.TryGetGeneratedModelName
				(
					fullTypeName,
					generateModelDefaultsAttributeType,
					out var modelName,
					out var modelNameCaptureRegex,
					out var modelNameErrorMessage
				);
			
			if (!modelNameSuccess)
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionModelIdentifierMatchFailed,
							Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
							"model name",
							fullTypeName,
							modelNameCaptureRegex,
							!String.IsNullOrEmpty(modelNameErrorMessage) ? $" {modelNameErrorMessage}" : String.Empty
						)
					);
			}
			else
				VerifyModelIdentifiers(context, classSyntax, new[] { modelName }, "model name");
		}

		private void VerifyModelIdentifiers(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax, string[] identifiers, string identifierType)
		{
			foreach (var invalid in identifiers.Where(s => !CodeProvider.IsValidIdentifier(s)))
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionModelIdentifierInvalid,
							Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
							identifierType,
							invalid
						)
					);
			}
		}
	}
}
