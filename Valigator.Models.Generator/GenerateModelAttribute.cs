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
	}
}
