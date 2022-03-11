using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Models
{
	public class CoercedModelErrorDictionary : ModelErrorDictionaryBase
	{
		public CoercedModelErrorDictionary() { }

		public CoercedModelErrorDictionary(IReadOnlyDictionary<string, ValidationError[]>? errors)
			: base(errors)
		{
		}

		public ValidatedModelErrorDictionary ToValidatedModelErrorDictionary()
			=> new ValidatedModelErrorDictionary(_errors);
	}
}
