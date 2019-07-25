using Valigator.AspNetCore;

namespace Valigator
{
	internal static class ValidationHelpers
	{
		public static void ValidateType<TValue>(object attribute)
		{
			if (!(attribute is IValidateType<TValue>))
				throw new ValidateAttributeDoesNotSupportTypeException(attribute.GetType(), typeof(TValue));
		}
	}
}
