using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public interface IAcceptCollectionValue<TDataValue, TValue> : IAcceptValue<TDataValue, Option<TValue>[]>
	{
	}
}
