using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class GenerateModelDefaultsAttribute : Attribute
	{
		public PropertyAccessors DefaultPropertyAccessors { get; set; }

		public string? ModelNamespace { get; set; }

		public string? ParentClasses { get; set; }

		public string? ModelName { get; set; }

		public string? SourceCaptureRegex { get; set; }
	}
}
