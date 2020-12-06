using System;
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

		public ValueValidatorSet<string> One => ValueValidatorSet.Empty<string>().Length(10);
	}
}
