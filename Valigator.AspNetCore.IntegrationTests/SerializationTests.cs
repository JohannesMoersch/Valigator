using System;
using System.Text.Json;
using System.Threading.Tasks;
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

		private TestModel CreateDefaultModel()
			=> new TestModel()
			{
				Required = 10,
				RequiredNullable = 15,
				SetOptional = 20,
				SetOptionalNullable = 25,
				UnsetOptional = null,
				UnsetOptionalNullable = null,
				Defaulted = 30,
				DefaultedNullable = 35
			};

		[Fact]
		public Task GetSuccessful()
			=> TestClient
				.Instance
				.BuildTest()
				.Get("Test")
				.Send()
				.IsOk()
				.AssertJsonBody(s => JsonSerializer
					.Deserialize<TestModel>(s)
					.Should()
					.Be(CreateDefaultModel())
				);

		[Fact]
		public Task PostSuccessful()
			=> TestClient
				.Instance
				.BuildTest()
				.Post("Test/Mutate")
				.WithJsonBody(JsonSerializer.Serialize(CreateDefaultModel()))
				.Send()
				.IsOk()
				.AssertJsonBody(s => JsonSerializer
					.Deserialize<TestModel>(s)
					.Should()
					.Be(CreateDefaultModel()
						with
						{
							Required = 15,
							Defaulted = 35
						}
					)
				);

		[Fact]
		public Task PostWithNullRequiredFails()
			=> TestClient
				.Instance
				.BuildTest()
				.Post("Test")
				.WithJsonBody("{}")
				.Send()
				.IsBadRequest();
	}
}
