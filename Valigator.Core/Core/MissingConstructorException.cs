using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public class MissingConstructorException : Exception
	{
		public MissingConstructorException(Type type)
			: base($"The type \"{type.FullName}\" is missing a default constructor.")
		{
			Type = type;
		}

		public Type Type { get; }
	}
}
