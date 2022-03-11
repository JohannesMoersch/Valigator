using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Core
{
	public class CoercionValidationError : ValidationError
	{
		public CoercionValidationError(string message) 
			: base(message)
		{
		}
	}
}
