using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public interface IAcceptValue<TDataValue, TValue>
	{
		Data<TDataValue> WithValue(Data<TDataValue> data, Option<TValue> value);
	}
}
