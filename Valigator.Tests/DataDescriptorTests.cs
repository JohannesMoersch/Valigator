using FakeItEasy;
using FluentAssertions;
using Functional;
using Valigator.Core;
using Valigator.Core.ValueDescriptors;
using Xunit;

namespace Valigator.Tests
{
	public class DataDescriptorTests
	{
		[Fact]
		public void RequiredNotNullable()
		{
			var data = Data.Required<int>().InRange(0);
			data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
			{
				new NotNullDescriptor(),
				new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
				new RequiredDescriptor()
			});
		}

		[Fact]
		public void RequiredNullable()
		{
			var data = Data.Required<int>().Nullable().InRange(0);
			data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
			{
				new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
				new RequiredDescriptor()
			});
		}

		[Fact]
		public void OptionalNotNullable()
		{
			var data = Data.Optional<int>().InRange(0);
			data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
			{
				new NotNullDescriptor(),
				new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false)
			});
		}

		[Fact]
		public void OptionalNullable()
		{
			var data = Data.Optional<int>().Nullable().InRange(0);
			data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
			{
				new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false)
			});
		}

		[Fact]
		public void DefaultedNotNullable()
		{
			var data = Data.Defaulted(1).InRange(0);
			data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
			{
				new NotNullDescriptor(),
				new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false)
			});
		}

		[Fact]
		public void DefaultNullableNotRequired()
		{
			var data = Data.Defaulted(1).Nullable().InRange(0);
			data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
			{
				new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false)
			});
		}
	}
}
