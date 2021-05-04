using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator
{
	[GenerateModelDefaults(
		DefaultPropertyAccessors = PropertyAccessors.Get,
		ModelNamespace = "${2}",
		ModelParentClasses = "${5}",
		ModelName = "${7}",
		SourceCaptureRegex = "^((([^\\.\\+]+\\.)*[^\\.\\+]+)\\.)?((([^\\.\\+]+\\+)*[^\\.\\+]+)\\+)?([^\\.\\+]+)Definition$"
	)]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class GenerateModelAttribute : Attribute
	{
		public PropertyAccessors DefaultPropertyAccessors { get; set; }

		public string? ModelNamespace { get; set; }

		public string? ModelParentClasses { get; set; }

		public string? ModelName { get; set; }
		
		public string? SourceCaptureRegex { get; set; }

		public Type? ModelType { get; set; }
	}
}
