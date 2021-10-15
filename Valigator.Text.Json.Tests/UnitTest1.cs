using Functional;
using System;
using System.Collections.Generic;
using System.Text.Json;
using Valigator.Core;
using Xunit;

namespace Valigator.Text.Json.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			var settings = new JsonSerializerOptions();

			settings.Converters.Add(new OptionConverterFactory());

			var result1 = JsonSerializer.Serialize(new { A = Option.Some(1), B = Option.None<int>() }, settings);

			var result2 = JsonSerializer.Deserialize(result1, new { A = Option.Some(1), B = Option.None<int>() }.GetType(), settings);
		}
	}
}
