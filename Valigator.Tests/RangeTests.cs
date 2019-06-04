using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Tests
{
	public class RangeTests
	{
		public void Stuff()
		{
			Data<Option<int>> a = Data.Required<int>().Nullable().GreaterThan(10);
		}
	}
}
