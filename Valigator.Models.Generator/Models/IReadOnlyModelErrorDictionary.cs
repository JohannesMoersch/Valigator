using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Models
{
	public interface IReadOnlyModelErrorDictionary : IReadOnlyDictionary<string, ValidationError[]>
	{
	}
}
