using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public interface IDataSource<TValue>
	{
		Data<TValue> Data { get; }

		Result<TValue, ValidationError> Validate(object model, bool isSet, TValue value);
	}
}
