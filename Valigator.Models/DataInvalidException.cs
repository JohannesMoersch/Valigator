using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	public class DataInvalidException : Exception
	{
		public ValidationError[] ValidationErrors { get; }

		public DataInvalidException(ValidationError[] validationErrors) 
			=> ValidationErrors = validationErrors ?? throw new ArgumentNullException(nameof(validationErrors));
	}
}
