using System;
using System.Collections.Generic;
using Valigator.Validators;
using Valigator.Core;
using Xunit;
using Valigator.ModelValidationData;

namespace Valigator.Models.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{

		}

		public partial class TestModel
		{
			public class Definition : ModelDefinition<TestModel>
			{
				public RequiredCollectionModelValidationData<TestModel, int> One => Data.Collection<int>().Required();

				public RequiredValueModelValidationData<TestModel, string> Two => Data.Value<string>().Required();

				public RequiredNullableValueModelValidationData<TestModel, string> Three => Data.Value<string>(o => o.Nullable()).Required().Length(5);

				public object Four => Data.Collection<int>(o => o.ItemsNullable().Nullable()).Required();

				public object Five => Data.Dictionary<string>(o => o.ItemsNullable()).Required().Not(o => o.Count(10)).ForEachValue(o => o.Length(5));
			}
		}
	}
}
