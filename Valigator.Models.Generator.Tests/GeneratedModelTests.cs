using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Valigator.Models.Generator.Tests
{
	public partial class GeneratedModelTests
	{
		[GenerateModel]
		public partial class ValueModelDefinition 
		{

			public Property<Option<int>> RequiredNullableValue => Data.Value<int>(o => o.Nullable()).Required();

			public Property<Optional<int>> OptionalValue => Data.Value<int>().Optional();

			public Property<Optional<Option<int>>> OptionalNullableValue => Data.Value<int>(o => o.Nullable()).Optional();

			public Property<int> DefaultedValue => Data.Value<int>().Defaulted(5);

			public Property<Option<int>> DefaultedNullableValue => Data.Value<int>(o => o.Nullable()).Defaulted(Option.Some(5));
		}

		[GenerateModel(DefaultPropertyAccessors = PropertyAccessors.GetAndSet)]
		public partial class NotSetWhenRequiredModelDefinition
		{
			public Property<int> RequiredValue => Data.Value<int>().Required();
		}

		[Fact]
		public void SetWhenRequired()
			=> new NotSetWhenRequiredModel()
				.Do(o => o.RequiredValue = 5)
				.RequiredValue
				.Should()
				.Be(5);

		[Fact]
		public void UnsetWhenRequired()
			=> new NotSetWhenRequiredModel()
				.Throws(default(DataInvalidException), o => o.RequiredValue);
	}
}
