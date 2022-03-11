using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Models
{
	public enum ModelPropertyState : byte
	{
		Unset = default,
		Set,
		CoerceFailed
	}
}
