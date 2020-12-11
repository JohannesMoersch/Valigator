using Functional;
using System;
using System.Collections.Generic;
using Valigator.Core;
using Xunit;

namespace Valigator.Validators.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
		}

		public ValidationData<string> One => new ValidationData<string>().Length(10).Not(o => o.Length(10));

		public ValidationData<IReadOnlyList<string>> Two => new ValidationData<IReadOnlyList<string>>().ForEach(o => o.Length(10)).ForEach(o => o.Not(x => x.Length(10)));

		public ValidationData<IReadOnlyList<Option<string>>> Three => new ValidationData<IReadOnlyList<Option<string>>>().ForEach(o => o.Length(10)).ForEach(o => o.Not(x => x.Length(10)));

		public ValidationData<IReadOnlyDictionary<string, int>> Four => new ValidationData<IReadOnlyDictionary<string, int>>()
	}
}
