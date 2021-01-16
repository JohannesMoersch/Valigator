using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Xunit;

namespace Valigator.Models.Tests
{
	public class DataTests
	{
		[Fact]
		public void Dummy()
			=> Data
				.Value<int>()
				.Required()
				.ToData()
				.WithValue(Optional.Unset<Option<int>>())
				.TryGetValue()
				.AssertFailure();
				
	}
}
