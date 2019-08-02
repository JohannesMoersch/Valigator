using System;

namespace Valigator
{
	public class TypeMismatchException : Exception
	{
		public TypeMismatchException(Type type1, Type type2)
		{
			Type1 = type1;
			Type2 = type2;
		}

		public Type Type1 { get; }
		public Type Type2 { get; }
	}
}
