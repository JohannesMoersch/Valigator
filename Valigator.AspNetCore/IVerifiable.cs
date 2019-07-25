using System;
using Functional;

namespace Valigator
{
	public interface IVerifiable
	{
		Result<object, ValidationError[]> Verify(Type type, object value);
		Result<object, ValidationError[]> Verify(Type type);
	}
}
