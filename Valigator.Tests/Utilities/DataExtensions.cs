using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core;

namespace Valigator.Tests
{
	public static class DataExtensions
	{
		public static Data<TDataValue> WithOptionValue<TDataValue, TValue>(this Data<TDataValue> data, Option<TValue> value)
			=> (data.DataContainer as IAcceptValue<TDataValue, TValue>)
				.WithValue(data, value);
	}
}
