using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator
{
	public class ValidationError : IEquatable<ValidationError>
	{
		public string Message { get; }

		public Path Path { get; } = new Path();

		public IValueDescriptor ValueDescriptor { get; }

		public ValidationError(string message, IValueDescriptor valueDescriptor)
		{
			Message = message;
			ValueDescriptor = valueDescriptor;
		}
		public override bool Equals(object obj) 
			=> Equals(obj as ValidationError);

		public bool Equals(ValidationError other) 
			=> other != null && Message == other.Message && EqualityComparer<Path>.Default.Equals(Path, other.Path) && EqualityComparer<IValueDescriptor>.Default.Equals(ValueDescriptor, other.ValueDescriptor);

		public override int GetHashCode()
		{
			var hashCode = 599436313;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Message);
			hashCode = hashCode * -1521134295 + EqualityComparer<Path>.Default.GetHashCode(Path);
			hashCode = hashCode * -1521134295 + EqualityComparer<IValueDescriptor>.Default.GetHashCode(ValueDescriptor);
			return hashCode;
		}

		public static ValidationError Create(string message)
			=> new ValidationError(message, null);
	}
}
