using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Models
{
	public class ValidatedModelErrorDictionary : ModelErrorDictionaryBase
	{
		public ValidatedModelErrorDictionary() { }

		public ValidatedModelErrorDictionary(IReadOnlyDictionary<string, ValidationError[]>? errors)
			: base(errors)
		{
		}
	}
}
