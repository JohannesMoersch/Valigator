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
		[GenerateModel(GenerateSetterMethods = true)]
		public partial class RequiredValueModelDefinition
		{
			public Property<int> Value => Data.Value<int>().Required();
		}

		[Fact]
		public void SetWhenRequired()
			=> new RequiredValueModel()
				.Do(o => o.SetValue(5))
				.Value
				.Should()
				.Be(5);

		[Fact]
		public void UnsetWhenRequired()
			=> new RequiredValueModel()
				.Throws(default(DataInvalidException), o => o.Value);

		[GenerateModel(GenerateSetterMethods = true)]
		public partial class RequiredNullableValueModelDefinition
		{
			public Property<Option<int>> Value => Data.Value<int>(o => o.Nullable()).Required();
		}

		[Fact]
		public void SetSomeWhenNullableRequired()
			=> new RequiredNullableValueModel()
				.Do(o => o.SetValue(Option.Some(5)))
				.Value
				.AssertSome()
				.Should()
				.Be(5);

		[Fact]
		public void SetNoneWhenNullableRequired()
			=> new RequiredNullableValueModel()
				.Do(o => o.SetValue(Option.None<int>()))
				.Value
				.AssertNone();

		[Fact]
		public void UnsetWhenNullableRequired()
			=> new RequiredNullableValueModel()
				.Throws(default(DataInvalidException), o => o.Value);

		[GenerateModel(GenerateSetterMethods = true)]
		public partial class OptionalValueModelDefinition
		{
			public Property<Optional<int>> Value => Data.Value<int>().Optional();
		}

		[Fact]
		public void SetWhenOptional()
			=> new OptionalValueModel()
				.Do(o => o.SetValue(5))
				.Value
				.AssertSet()
				.Should()
				.Be(5);

		[Fact]
		public void UnsetWhenOptional()
			=> new OptionalValueModel()
				.Value
				.AssertUnset();

		[GenerateModel(GenerateSetterMethods = true)]
		public partial class OptionalNullableValueModelDefinition
		{
			public Property<Optional<Option<int>>> Value => Data.Value<int>(o => o.Nullable()).Optional();
		}

		[Fact]
		public void SetSomeWhenNullableOptional()
			=> new OptionalNullableValueModel()
				.Do(o => o.SetValue(Option.Some(5)))
				.Value
				.AssertSet()
				.AssertSome()
				.Should()
				.Be(5);

		[Fact]
		public void SetNoneWhenNullableOptional()
			=> new OptionalNullableValueModel()
				.Do(o => o.SetValue(Option.None<int>()))
				.Value
				.AssertSet()
				.AssertNone();

		[Fact]
		public void UnsetWhenNullableOptional()
			=> new OptionalNullableValueModel()
				.Value
				.AssertUnset();

		[GenerateModel(GenerateSetterMethods = true)]
		public partial class DefaultedValueModelDefinition
		{
			public Property<int> Value => Data.Value<int>().Defaulted(2);
		}

		[Fact]
		public void SetWhenDefaulted()
			=> new DefaultedValueModel()
				.Do(o => o.SetValue(5))
				.Value
				.Should()
				.Be(5);

		[Fact]
		public void UnsetWhenDefaulted()
			=> new DefaultedValueModel()
				.Value
				.Should()
				.Be(2);

		[GenerateModel(GenerateSetterMethods = true)]
		public partial class DefaultedNullableValueModelDefinition
		{
			public Property<Option<int>> Value => Data.Value<int>(o => o.Nullable()).Defaulted(Option.Some(2));
		}

		[Fact]
		public void SetSomeWhenNullableDefaulted()
			=> new DefaultedNullableValueModel()
				.Do(o => o.SetValue(Option.Some(5)))
				.Value
				.AssertSome()
				.Should()
				.Be(5);

		[Fact]
		public void SetNoneWhenNullableDefaulted()
			=> new DefaultedNullableValueModel()
				.Do(o => o.SetValue(Option.None<int>()))
				.Value
				.AssertNone();

		[Fact]
		public void UnsetWhenNullableDefaulted()
			=> new DefaultedNullableValueModel()
				.Value
				.AssertSome()
				.Should()
				.Be(2);
	}
}
