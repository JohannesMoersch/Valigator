using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public interface IAcceptValue<TDataValue>
	{
		Type ValueType { get; }

		Data<TDataValue> WithNull(Data<TDataValue> data);
	}

	public interface IAcceptValue<TDataValue, TValue> : IAcceptValue<TDataValue>
	{
		Data<TDataValue> WithValue(Data<TDataValue> data, Option<TValue> value);
	}
}
