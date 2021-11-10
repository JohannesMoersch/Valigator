using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator
{
	public enum ModelType
	{
		/// <summary>
		/// Unset tells the generator to use the parent classes attribute value.
		/// </summary>
		Unset = -1,
		/// <summary>
		/// Auto will default to class unless the model has already been manually define as a partial struct.
		/// </summary>
		Auto = 0,
		Class = 1,
		Struct = 2
	}
}
