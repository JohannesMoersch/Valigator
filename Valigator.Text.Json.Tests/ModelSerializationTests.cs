using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Valigator.Text.Json.Tests
{
	public partial class ModelSerializationTests
	{
		[GenerateModel(Type = ModelType.Struct)]
		public partial class TestModelDefinition
		{
			public Property<int> Required => Data.Value<int>().Required();

			public Property<Option<int>> RequiredNullable => Data.Value<int>(o => o.Nullable()).Required();

			public Property<Optional<int>> SetOptional => Data.Value<int>().Optional();

			public Property<Optional<Option<int>>> SetOptionalNullable => Data.Value<int>(o => o.Nullable()).Optional();

			public Property<Optional<int>> UnsetOptional => Data.Value<int>().Optional();

			public Property<Optional<Option<int>>> UnsetOptionalNullable => Data.Value<int>(o => o.Nullable()).Optional();

			public Property<int> Defaulted => Data.Value<int>().Defaulted(5);

			public Property<Option<int>> DefaultedNullable => Data.Value<int>(o => o.Nullable()).Defaulted(Option.Some(5));
		}

		private TestModel CreatePopulatedTestModel()
			=> new TestModel
			(
				required: 10,
				requiredNullable: Option.Some(15),
				setOptional: Optional.Set(20),
				setOptionalNullable: Optional.Set(Option.Some(25)),
				unsetOptional: Optional.Unset<int>(),
				unsetOptionalNullable: Optional.Unset<Option<int>>(),
				defaulted: 30,
				defaultedNullable: Option.Some(35)
			);

		private string PopulatedTestModelString => JsonHelper
			.Format
			(@"
				{
					""Required"": 10,
					""RequiredNullable"": 15,
					""SetOptional"": 20,
					""SetOptionalNullable"": 25,
					""Defaulted"": 30,
					""DefaultedNullable"": 35
				}"
			);

		[Fact]
		public void PopulatedModelSerializesToStringSuccessfully()
			=> JsonHelper
				.Serialize(CreatePopulatedTestModel())
				.Should()
				.Be(PopulatedTestModelString);

		[Fact]
		public void PopulatedModelDeserializesFromStringSuccessfully()
			=> JsonHelper
				.Deserialize<TestModel>(PopulatedTestModelString)
				.Should()
				.Be(CreatePopulatedTestModel());

		[Fact]
		public void PopulatedModelDeserializesFromLowercaseStringWhenCaseInsensitiveSuccessfully()
			=> JsonHelper
				.Deserialize<TestModel>(PopulatedTestModelString.ToLower(), false)
				.Should()
				.Be(CreatePopulatedTestModel());

		[Fact]
		public void PopulatedModelFailsToDeserializesFromLowercaseStringWhenCaseSensitive()
			=> JsonHelper
				.Deserialize<TestModel>(PopulatedTestModelString.ToLower())
				.Throws(default(DataInvalidException), o => o.Required);

		[Fact]
		public void PopulatedModelSerializesAndDeserializesSuccessfully()
			=> JsonHelper
				.CloneViaSerialization(CreatePopulatedTestModel())
				.Should()
				.Be(CreatePopulatedTestModel());

		public TestModel CreateUnpopulatedTestModel()
			=> new TestModel
			(
				required: 10,
				requiredNullable: Option.None<int>(),
				setOptional: Optional.Set(20),
				setOptionalNullable: Optional.Set(Option.None<int>()),
				unsetOptional: Optional.Unset<int>(),
				unsetOptionalNullable: Optional.Unset<Option<int>>(),
				defaulted: 30,
				defaultedNullable: Option.None<int>()
			);

		[Fact]
		public void UnpopulatedModelSerializesAndDeserializesSuccessfuly()
			=> JsonHelper
				.CloneViaSerialization(CreateUnpopulatedTestModel())
				.Should()
				.Be(CreateUnpopulatedTestModel());

		public class WhenDeserializingEmptyObject
		{
			[Fact]
			public void RequiredShouldThrowException()
				=> JsonHelper
					.Deserialize<TestModel>("{}")
					.Throws(default(DataInvalidException), o => o.Required);

			[Fact]
			public void RequiredNullableThrowException()
				=> JsonHelper
					.Deserialize<TestModel>("{}")
					.Throws(default(DataInvalidException), o => o.RequiredNullable);

			[Fact]
			public void OptionalShouldBeUnset()
				=> JsonHelper
					.Deserialize<TestModel>("{}")
					.UnsetOptional
					.AssertUnset();

			[Fact]
			public void OptionalNullableShouldUnset()
				=> JsonHelper
					.Deserialize<TestModel>("{}")
					.UnsetOptionalNullable
					.AssertUnset();

			[Fact]
			public void DefaultedShouldBeDefault()
				=> JsonHelper
					.Deserialize<TestModel>("{}")
					.Defaulted
					.Should()
					.Be(5);

			[Fact]
			public void DefaultedNullableShouldBeDefault()
				=> JsonHelper
					.Deserialize<TestModel>("{}")
					.DefaultedNullable
					.AssertSome()
					.Should()
					.Be(5);

		}
	}
}
