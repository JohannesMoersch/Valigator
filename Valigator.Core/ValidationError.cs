using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator
{
	public class ValidationError
	{
		public string Message { get; }

		public Path Path { get; } = new Path();

		public IValueDescriptor ValueDescriptor { get; }

		public ValidationError(string message, IValueDescriptor valueDescriptor)
		{
			Message = message;
			ValueDescriptor = valueDescriptor;
		}

		public static ValidationError Create(string message)
			=> new ValidationError(message, null);
	}
}
