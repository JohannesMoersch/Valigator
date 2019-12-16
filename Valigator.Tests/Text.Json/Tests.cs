using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Valigator.Text.Json;
using Xunit;

namespace Valigator.Tests.Text.Json
{
	public class Tests
	{
		[ValigatorConverter]
		public class TestClass
		{
			public Data<int> One { get; private set; } = Data.Required<int>();
			public Data<Option<int>[]> Two { get; private set; } = Data.Collection<int>(o => o.Nullable()).Required();
		}

		[Fact]
		public void Test()
		{
			var obj = JsonSerializer.Deserialize<TestClass>(@"{""Zero"":0,""One"":5,""Two"":[1,null,5]}");
		}
	}
}
