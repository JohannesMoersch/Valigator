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

		public const string IModelPropertyData_TypeName = "Valigator.Core.IModelPropertyData`2";

		public const string GenerateModelAttribute_DefaultPropertyAccessors_PropertyName = "DefaultPropertyAccessors";

		public const string GenerateModelAttribute_ModelNamespace_PropertyName = "ModelNamespace";

		public const string GenerateModelAttribute_ModelParentClasses_PropertyName = "ModelParentClasses";

		public const string GenerateModelAttribute_ModelName_PropertyName = "ModelName";

		public const string GenerateModelAttribute_ModelNamespaceCaptureRegex_PropertyName = "ModelNamespaceCaptureRegex";

		public const string GenerateModelAttribute_ModelParentClassesCaptureRegex_PropertyName = "ModelParentClassesCaptureRegex";

		public const string GenerateModelAttribute_ModelNameCaptureRegex_PropertyName = "ModelNameCaptureRegex";

		public const string GenerateModelAttribute_ModelType_PropertyName = "ModelType";

		public const string PropertyAttribute_GenerateSetterMethod_PropertyName = "GenerateSetterMethod";

		public const string PropertyAttribute_Accessors_PropertyName = "Accessors";

		public enum PropertyAccessors
		{
			Get,
			GetAndSet
		}
	}
}
