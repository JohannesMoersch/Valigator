using System;
using Valigator.Core.ValueDescriptors;

namespace Valigator
{
	public static class MappingError
	{
		public static ValidationError Create(string message, Type fromType, Type toType)
			=> new ValidationError(message, new MappingDescriptor(fromType, toType));
	}
}
