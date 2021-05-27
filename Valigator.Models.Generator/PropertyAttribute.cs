using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
	public class PropertyAttribute : Attribute
	{
		public bool GenerateSetterMethod { get; set; }
	}
}
