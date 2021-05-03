using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class GenerateModelAttribute : Attribute
	{
		public PropertyAccessors DefaultPropertyAccessors { get; set; } = PropertyAccessors.Get;

		public string ModelName { get; set; } = "$0";

		public string ModelSourceCaptureRegex { get; set; } = "(.*)Definition";

		public Type ModelType { get; set; }
	}
}
