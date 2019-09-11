using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator
{
	public class BindResult
	{
		public static BindResult Create<TValue>(Data<TValue> data)
			=> BindResult<TValue>.Create(data);
	}

	internal class BindResult<TValue> : BindResult
	{
		public Data<TValue> Data { get; }

		private BindResult(Data<TValue> data)
			=> Data = data;

		public new static BindResult<TDataValue> Create<TDataValue>(Data<TDataValue> data)
			=> new BindResult<TDataValue>(data);
	}
}
