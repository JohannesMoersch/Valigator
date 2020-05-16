using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Tests.Common
{
	public static class ValidationErrorExtensions
	{
		public static ValidationError AddPathProperty(this ValidationError validationError, string property)
		{
			validationError.Path.AddProperty(property);

			return validationError;
		}

		public static ValidationError AddPathIndex(this ValidationError validationError, int index)
		{
			validationError.Path.AddIndex(index);

			return validationError;
		}
	}
}
