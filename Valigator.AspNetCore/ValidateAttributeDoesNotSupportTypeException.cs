using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.AspNetCore
{
	public class ValidateAttributeDoesNotSupportTypeException : Exception
	{
		public ValidateAttributeDoesNotSupportTypeException(Type attributeType, Type valueType)
			: base($"{attributeType.Name} does not implement IValidateType<{valueType.Name}>.")
		{
		}
	}
}
