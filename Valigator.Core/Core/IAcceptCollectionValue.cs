using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public interface IAcceptCollectionValue<TDataValue> : IAcceptValue<TDataValue>
	{
	}

	public interface IAcceptCollectionValue<TDataValue, TValue> : IAcceptCollectionValue<TDataValue>, IAcceptValue<TDataValue, Option<TValue>[]>
	{
	}
}
