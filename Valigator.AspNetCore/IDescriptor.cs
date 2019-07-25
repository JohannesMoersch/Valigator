using System;
using Valigator.Core;

namespace Valigator
{
	public interface IDescriptor
	{
		DataDescriptor GetDescriptor(Type type);
	}
}
