using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
	public class GeneratedFromAttribute : Attribute
	{
		public Type ModelDefinitionType { get; }

		public GeneratedFromAttribute(Type modelDefinitionType)
			=> ModelDefinitionType = modelDefinitionType;
	}
}
