using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class ExternalConstants
	{
		public const string GenerateModelAttribute_TypeName = "Valigator.GenerateModelAttribute";

		public const string GenerateModelDefaultsAttribute_TypeName = "Valigator.GenerateModelDefaultsAttribute";

		public const string PropertyAttribute_TypeName = "Valigator.PropertyAttribute";

		public const string ModelDefinition_Property_TypeName = "Valigator.Models.ModelDefinition`1+Property`1";

		public const string GenerateModelAttribute_DefaultPropertyAccessors_PropertyName = "DefaultPropertyAccessors";

		public const string GenerateModelAttribute_ModelNamespace_PropertyName = "ModelNamespace";

		public const string GenerateModelAttribute_ParentClasses_PropertyName = "ParentClasses";

		public const string GenerateModelAttribute_ModelName_PropertyName = "ModelName";

		public const string GenerateModelAttribute_SourceCaptureRegex_PropertyName = "SourceCaptureRegex";

		public const string GenerateModelAttribute_ModelType_PropertyName = "ModelType";

		public const string PropertyAttribute_Accessors_PropertyName = "Accessors";

		public enum PropertyAccessors
		{
			Get,
			GetAndSet
		}
	}
}
