using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class ExternalConstants
	{
		public const string GenerateModelAttribute_TypeName = "Valigator.GenerateModelAttribute";

		public const string PropertyAttribute_TypeName = "Valigator.PropertyAttribute";

		public const string ModelDefinition_Property_TypeName = "Valigator.Models.ModelDefinition`1+Property`1";

		public const string GenerateModelAttribute_DefaultPropertyAccessors_PropertyName = "DefaultPropertyAccessors";

		public const string PropertyAttribute_Accessors_PropertyName = "Accessors";

		public const PropertyAccessors GenerateModelAttribute_DefaultPropertyAccessors_DefaultValue = PropertyAccessors.Get;

		public enum PropertyAccessors
		{
			Get,
			GetAndSet
		}
	}
}
