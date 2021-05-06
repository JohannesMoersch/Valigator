using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Valigator.Models.Generator.Analyzers
{
	public static class AttributeDataExtensions
	{
		public static bool TryGetProperty<T>(this AttributeData attributeData, string propertyName, out T value)
		{
			foreach (var kvp in attributeData.NamedArguments)
			{
				if (kvp.Key == propertyName)
				{
					value = (T)kvp.Value.Value;
					return true;
				}
			}

			value = default;
			return false;
		}

		public static T GetGenerateModelPropertyValue<T>(this AttributeData attributeData, string propertyName, INamedTypeSymbol generateModelDefaultsAttributeType)
		{
			if (attributeData.TryGetProperty(propertyName, out T value))
				return value;

			var attributeClass = attributeData.AttributeClass;

			while (attributeClass != null)
			{
				var defaults = attributeClass
					.GetAttributes()
					.FirstOrDefault(att => att.AttributeClass.Equals(generateModelDefaultsAttributeType, SymbolEqualityComparer.Default));

				if (defaults != null && defaults.TryGetProperty(propertyName, out value))
					return value;

				attributeClass = attributeClass.BaseType;
			}

			return default;
		}

		public static bool TryGetGeneratedModelNamespace(this AttributeData attributeData, string fullTypeName, INamedTypeSymbol generateModelDefaultsAttributeType, out string[] modelNamespace, out string captureRegex, out string errorMessage)
		{
			var success = TryApplyGenerateModelPropertyPattern
			(
				attributeData,
				fullTypeName,
				ExternalConstants.GenerateModelAttribute_ModelNamespace_PropertyName,
				ExternalConstants.GenerateModelAttribute_ModelNamespaceCaptureRegex_PropertyName,
				generateModelDefaultsAttributeType,
				out var modelNamespaceString,
				out captureRegex,
				out errorMessage
			);

			modelNamespace = success && !String.IsNullOrEmpty(modelNamespaceString) ? modelNamespaceString.Split('.') : Array.Empty<string>();
			return success;
		}

		public static bool TryGetGeneratedModelParentClasses(this AttributeData attributeData, string fullTypeName, INamedTypeSymbol generateModelDefaultsAttributeType, out string[] modelParentClasses, out string captureRegex, out string errorMessage)
		{
			var success = TryApplyGenerateModelPropertyPattern
			(
				attributeData,
				fullTypeName,
				ExternalConstants.GenerateModelAttribute_ModelParentClasses_PropertyName,
				ExternalConstants.GenerateModelAttribute_ModelParentClassesCaptureRegex_PropertyName,
				generateModelDefaultsAttributeType,
				out var modelParentClassesString,
				out captureRegex,
				out errorMessage
			);

			modelParentClasses = success && !String.IsNullOrEmpty(modelParentClassesString) ? modelParentClassesString.Split('+') : Array.Empty<string>();
			return success;
		}

		public static bool TryGetGeneratedModelName(this AttributeData attributeData, string fullTypeName, INamedTypeSymbol generateModelDefaultsAttributeType, out string modelName, out string captureRegex, out string errorMessage)
			=> TryApplyGenerateModelPropertyPattern
			(
				attributeData,
				fullTypeName,
				ExternalConstants.GenerateModelAttribute_ModelName_PropertyName,
				ExternalConstants.GenerateModelAttribute_ModelNameCaptureRegex_PropertyName,
				generateModelDefaultsAttributeType,
				out modelName,
				out captureRegex,
				out errorMessage
			);

		private static bool TryApplyGenerateModelPropertyPattern(this AttributeData attributeData, string fullTypeName, string patternPropertyName, string captureRegexPropertyName, INamedTypeSymbol generateModelDefaultsAttributeType, out string value, out string captureRegex, out string errorMessage)
		{
			captureRegex = attributeData.GetGenerateModelPropertyValue<string>(captureRegexPropertyName, generateModelDefaultsAttributeType).EnsureRegexMatchesFullInput();

			var pattern = attributeData.GetGenerateModelPropertyValue<string>(patternPropertyName, generateModelDefaultsAttributeType);

			var match = Regex.Match(fullTypeName, captureRegex);

			return match.TryApplyToPattern(pattern, out value, out errorMessage);
		}
	}
}
