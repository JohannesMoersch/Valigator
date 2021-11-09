using System;
using System.Text.Json;
using FluentAssertions;
using Interrogator.Http;
using Xunit;

namespace Valigator.AspNetCore.IntegrationTests
{
	public class SerializationTests
	{
		public record TestModel
		{
			public int Required { get; init; }

			public int? RequiredNullable { get; init; }

			public int? SetOptional { get; init; }

			public int? SetOptionalNullable { get; init; }

			public int? UnsetOptional { get; init; }

			public int? UnsetOptionalNullable { get; init; }

			public int Defaulted { get; init; }

			public int? DefaultedNullable { get; init; }
		}

		[Fact]
		public void GetSuccessful()
			=> TestClient
				.Instance
				.BuildTest()
				.Get("Test/Get")
				.Send()
				.IsOk()
				.AssertJsonBody(s => JsonSerializer
					.Deserialize<TestModel>(s)
					.Should()
					.Be(new TestModel()
						{
							Required = 10,
							RequiredNullable = 15,
							SetOptional = 20,
							SetOptionalNullable = 25,
							UnsetOptional = null,
							UnsetOptionalNullable = null,
							Defaulted = 30,
							DefaultedNullable = 35
						}
					)
				);
	}
}
