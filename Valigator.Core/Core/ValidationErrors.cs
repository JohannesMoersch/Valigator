using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public static class ValidationErrors
	{
		public static ValidationError NotNull()
			=> new ValidationError("Value cannot be null", new NotNullDescriptor());
	}
}
