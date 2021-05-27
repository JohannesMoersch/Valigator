using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator
{
	[GenerateModelDefaults(
		GenerateSetterMethods = false,
		ModelNamespace = "${2}",
		ModelNamespaceCaptureRegex = "((.*)[\\.])?([^\\.]+)",
		ModelParentClasses = "${3}",
		ModelParentClassesCaptureRegex = "(.+[\\.])?(([^\\.]+)\\+)?[^\\+]+",
		ModelName = "${2}",
		ModelNameCaptureRegex = "(.*[\\.\\+])?([^\\.\\+]+)Definition"
	)]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class GenerateModelAttribute : Attribute
	{
		public bool GenerateSetterMethods { get; set; }

		public string? ModelNamespace { get; set; }

		public string? ModelParentClasses { get; set; }

		public string? ModelName { get; set; }
		
		public string? ModelNamespaceCaptureRegex { get; set; }

		public string? ModelParentClassesCaptureRegex { get; set; }

		public string? ModelNameCaptureRegex { get; set; }

		public Type? ModelType { get; set; }
	}
}
