using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.ValueDescriptors;

namespace Valigator
{
	public class MappingError : ValidationError
	{
		protected MappingError(string message) : base(message, null)
		{
		}

		public new static MappingError Create(string message)
			=> new MappingError(message);
	}

	public class ValidationError
	{
		// TODO: nathan create smart constructors
		// todo: mapping error type
		// todo: map with default or error, result<T, mappingError>, default

		public string Message { get; }

		public Path Path { get; } = new Path();

		public IValueDescriptor ValueDescriptor { get; }

		//tODO: Nathan should this be internal, if it is, that is a breaking change
		public ValidationError(string message, IValueDescriptor valueDescriptor)
		{
			Message = message;
			ValueDescriptor = valueDescriptor;
		}

		public static ValidationError Create(string message)
			=> new ValidationError(message, null);
	}
}
