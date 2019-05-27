using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation
{
	public static class DataExtensions
	{
		public static Data<Option<TValue>> WithValue<TValue>(this Data<Option<TValue>> data, TValue value)
			where TValue : class
			=> data.WithValue(Option.FromNullable(value));

		public static Data<Option<TValue>> WithValue<TValue>(this Data<Option<TValue>> data, TValue? value)
			where TValue : struct
			=> data.WithValue(Option.FromNullable(value));
	}
}
