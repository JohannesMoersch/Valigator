using System;

namespace Valigator
{
	public class TypeMismatchException : Exception
	{
		public TypeMismatchException(Type typeOne, Type typeTwo)
		{
			TypeOne = typeOne;
			TypeTwo = typeTwo;
		}

		public Type TypeOne { get; }
		public Type TypeTwo { get; }
	}
}
