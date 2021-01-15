using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	public class ValidationError : IEquatable<ValidationError?>
	{
		private readonly string _message;

		public ValidationError(string message) 
			=> _message = message;
		public override int GetHashCode()
			=> 1196080149 + EqualityComparer<string>.Default.GetHashCode(_message);

		public override bool Equals(object? obj) 
			=> Equals(obj as ValidationError);

		public bool Equals(ValidationError? other) 
			=> other != null && _message == other._message;
		
		public override string ToString()
			=> _message;
	}
}
