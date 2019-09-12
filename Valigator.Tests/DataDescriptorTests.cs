using System;
using FakeItEasy;
using FluentAssertions;
using Functional;
using Valigator.Core;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;
using Xunit;

namespace Valigator.Tests
{
	public class DataDescriptorTests
	{
		public class Collection
		{
			[Fact]
			public void RequiredNotNullable()
			{
				var data = Data.Collection<int>().Required();
				data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
				{
					new NotNullDescriptor(),
					new RequiredDescriptor()
				});
			}

			[Fact]
			public void RequiredNullable()
			{
				var data = Data.Collection<int>().Required().Nullable();
				data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
				{
					new RequiredDescriptor()
				});
			}

			[Fact]
			public void OptionalNotNullable()
			{
				var data = Data.Collection<int>().Optional();
				data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
				{
					new NotNullDescriptor(),
				});
			}

			[Fact]
			public void OptionalNullable()
			{
				var data = Data.Collection<int>().Optional().Nullable();
				data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
				{
					
				});
			}

			[Fact]
			public void DefaultedNotNullable()
			{
				var data = Data.Collection<int>().Defaulted();
				data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
				{
				new NotNullDescriptor(),
				});
			}

			[Fact]
			public void DefaultNullableNotRequired()
			{
				var data = Data.Collection<int>().Defaulted().Nullable();
				data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
				{
				});
			}

			public class Items
			{
				[Fact]
				public void CollectionRequiredNotNull_ItemsRequiredNotNull()
				{
					var data = Data.Collection<int>(v => v.InRange(0)).Required();
					data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new NotNullDescriptor(),
						new RequiredDescriptor(),
					});

					(data.Data.DataDescriptor.StateDescriptor as CollectionStateDescriptor).ItemDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
						new RequiredDescriptor(),
						new NotNullDescriptor()
					});
				}

				[Fact]
				public void CollectionRequiredNullable_ItemsRequiredNotNull()
				{
					var data = Data.Collection<int>(v => v.InRange(0)).Required().Nullable();
					data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RequiredDescriptor(),
					});

					(data.Data.DataDescriptor.StateDescriptor as CollectionStateDescriptor).ItemDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
						new RequiredDescriptor(),
						new NotNullDescriptor()
					});
				}

				[Fact]
				public void CollectionRequiredNotNull_ItemsRequiredNullable()
				{
					var data = Data.Collection<int>(v => v.Nullable().InRange(0)).Required();
					data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RequiredDescriptor(),
						new NotNullDescriptor(),
					});

					(data.Data.DataDescriptor.StateDescriptor as CollectionStateDescriptor).ItemDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
						new RequiredDescriptor()
					});
				}

				[Fact]
				public void CollectionRequiredNullable_ItemsRequiredNullable()
				{
					var data = Data.Collection<int>(v => v.Nullable().InRange(0)).Required().Nullable();
					data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RequiredDescriptor(),
					});

					(data.Data.DataDescriptor.StateDescriptor as CollectionStateDescriptor).ItemDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
						new RequiredDescriptor()
					});
				}

				[Fact]
				public void CollectionDefaultedNotNull_ItemsRequiredNotNull()
				{
					var data = Data.Collection<int>(v => v.InRange(0)).Defaulted();
					data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new NotNullDescriptor()
					});

					(data.Data.DataDescriptor.StateDescriptor as CollectionStateDescriptor).ItemDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
						new RequiredDescriptor(),
						new NotNullDescriptor()
					});
				}

				[Fact]
				public void CollectionDefaultedNullable_ItemsRequiredNotNull()
				{
					var data = Data.Collection<int>(v => v.InRange(0)).Defaulted().Nullable();
					data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
					});

					(data.Data.DataDescriptor.StateDescriptor as CollectionStateDescriptor).ItemDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
						new RequiredDescriptor(),
						new NotNullDescriptor()
					});
				}

				[Fact]
				public void CollectionDefaultedNotNull_ItemsRequiredNullable()
				{
					var data = Data.Collection<int>(v => v.Nullable().InRange(0)).Defaulted();
					data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new NotNullDescriptor(),
					});

					(data.Data.DataDescriptor.StateDescriptor as CollectionStateDescriptor).ItemDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
						new RequiredDescriptor()
					});
				}

				[Fact]
				public void CollectionDefaultedNullable_ItemsRequiredNullable()
				{
					var data = Data.Collection<int>(v => v.Nullable().InRange(0)).Defaulted().Nullable();
					data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
					});

					(data.Data.DataDescriptor.StateDescriptor as CollectionStateDescriptor).ItemDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
						new RequiredDescriptor()
					});
				}

				[Fact]
				public void CollectionOptionalNotNull_ItemsRequiredNotNull()
				{
					var data = Data.Collection<int>(v => v.InRange(0)).Optional();
					data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new NotNullDescriptor()
					});

					(data.Data.DataDescriptor.StateDescriptor as CollectionStateDescriptor).ItemDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
						new RequiredDescriptor(),
						new NotNullDescriptor()
					});
				}

				[Fact]
				public void CollectionOptionalNullable_ItemsRequiredNotNull()
				{
					var data = Data.Collection<int>(v => v.InRange(0)).Optional().Nullable();
					data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
					});

					(data.Data.DataDescriptor.StateDescriptor as CollectionStateDescriptor).ItemDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
						new RequiredDescriptor(),
						new NotNullDescriptor()
					});
				}

				[Fact]
				public void CollectionOptionalNotNull_ItemsRequiredNullable()
				{
					var data = Data.Collection<int>(v => v.Nullable().InRange(0)).Optional();
					data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new NotNullDescriptor(),
					});

					(data.Data.DataDescriptor.StateDescriptor as CollectionStateDescriptor).ItemDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
						new RequiredDescriptor()
					});
				}

				[Fact]
				public void CollectionOptionalNullable_ItemsRequiredNullable()
				{
					var data = Data.Collection<int>(v => v.Nullable().InRange(0)).Optional().Nullable();
					data.Data.DataDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
					});

					(data.Data.DataDescriptor.StateDescriptor as CollectionStateDescriptor).ItemDescriptor.ValueDescriptors.Should().BeEquivalentTo(new IValueDescriptor[]
					{
						new RangeDescriptor(Option.None<object>(), false, Option.Some<object>(0), false),
						new RequiredDescriptor()
					});
				}
			}
		}
		public class NonCollection
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
		public class MappedDescriptor
		{
			private DataDescriptor DataDescriptor
				=> Data
					.Required<int>()
					.MappedFrom<string>(Int32.Parse, o => o.InSet(new[] { "5", "10", "15" }))
					.Data
					.DataDescriptor;

			[Fact]
			public void HasCorrectSourceType()
				=> DataDescriptor
					.MappingDescriptor
					.AssertSome()
					.SourceType
					.Should()
					.Be(typeof(string));

			[Fact]
			public void HasCorrectPropertyType()
				=> DataDescriptor
					.PropertyType
					.Should()
					.Be(typeof(int));

			[Fact]
			public void HasCorrectSourceValueDescriptors()
				=> DataDescriptor
					.MappingDescriptor
					.AssertSome()
					.SourceValueDescriptors
					.Should()
					.BeEquivalentTo(new[] { new InSetDescriptor(new object[] { "5", "10", "15" }) });
		}
		public class NonMappedDescriptor
		{
			private DataDescriptor DataDescriptor
				=> Data
					.Required<int>()
					.Data
					.DataDescriptor;

			[Fact]
			public void HasCorrectPropertyType()
				=> DataDescriptor
					.PropertyType
					.Should()
					.Be(typeof(int));

			[Fact]
			public void HasNoMappingDescriptor()
				=> DataDescriptor
					.MappingDescriptor
					.AssertNone();
		}
	}
}
