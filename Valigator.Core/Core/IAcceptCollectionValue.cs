using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public interface IAcceptCollectionValue<TDataValue, TValue>
	{
		Data<TDataValue> WithValue(Data<TDataValue> data, Option<Option<TValue>[]> value);
	}
}
