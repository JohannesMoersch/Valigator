using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.Json;
using Valigator.Core;
using Valigator.Newtonsoft.Json;
using Xunit;

namespace Valigator.Tests.Newtonsoft
{
	public class DeserializationTests
	{
		public class SmallClass
		{
			public int A { get; set; }
		}
		public class TestModel
		{
			public Data<int> Things { get; set; } = Data.Required<int>();

			public Data<Option<int>> Stuff { get; set; } = Data.Required<int>().Nullable();

			public Data<Option<SmallClass>[]> CollectionA { get; set	; } = Data.Collection<SmallClass>(o => o.Nullable()).Required();

			public Data<Option<Option<SmallClass>[]>> CollectionB { get; set; } = Data.Collection<SmallClass>(o => o.Nullable()).Required().Nullable();

			public Data<Option<Option<SmallClass>[]>> CollectionC { get; set; } = Data.Collection<SmallClass>(o => o.Nullable()).Required().Nullable();
		}

		[Fact]
		public void Stuff()
		{
			var model = JsonConvert.DeserializeObject<TestModel>("{\"Things\": 15, \"Stuff\": null, \"CollectionA\": [ { \"A\": 5 }, null ], \"CollectionB\": null, \"CollectionC\": [ { \"A\": 5 }, null ]}", new ValigatorConverter());

			Model.Verify(model);

			var json = JsonConvert.SerializeObject(model, new ValigatorConverter());
		}
	}
}
