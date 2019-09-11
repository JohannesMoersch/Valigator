using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using Functional;
using Newtonsoft.Json;
using Valigator.Core;
using Valigator.Core.ValueDescriptors;
using Valigator.Newtonsoft.Json;
using Xunit;

namespace Valigator.Tests.Newtonsoft
{
	public class DeserializationTests
	{
		public class Required
		{
			public class TestClass
			{
				public Data<int> Value { get; set; } = Data.Required<int>();
			}

			public class TestGuidClass
			{
				public Data<Guid> Value { get; set; } = Data.Required<Guid>();
			}

			[Fact]
			public void WithImproperlyFormedGuid()
				=> Deserialize<TestGuidClass>(@"{""Value"":""118ae9cc-3b7e-42""}")
						.Value
						.Verify()
						.TryGetValue()
						.AssertFailure()
						.First()
						.ValueDescriptor
						.Should()
						.BeOfType<MappingDescriptor>();

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":10}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.Should()
					.Be(10);

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull() });

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.Required() });
		}

		public class NullableRequired
		{
			public class TestClass
			{
				public Data<Option<int>> Value { get; set; } = Data.Required<int>().Nullable();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":10}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.Be(10);

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.Required() });
		}

		public class Optional
		{
			public class TestClass
			{
				public Data<Option<int>> Value { get; set; } = Data.Optional<int>();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":10}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.Be(10);

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull() });

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();
		}

		public class NullableOptional
		{
			public class TestClass
			{
				public Data<Option<int>> Value { get; set; } = Data.Optional<int>().Nullable();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":10}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.Be(10);

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();
		}

		public class Defaulted
		{
			public class TestClass
			{
				public Data<int> Value { get; set; } = Data.Defaulted<int>(5);
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":10}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.Should()
					.Be(10);

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull() });

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.Should()
					.Be(5);
		}

		public class NullableDefaulted
		{
			public class TestClass
			{
				public Data<Option<int>> Value { get; set; } = Data.Defaulted<int>(5).Nullable();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":10}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.Be(10);

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.Be(5);
		}

		public class RequiredCollection
		{
			public class TestClass
			{
				public Data<int[]> Value { get; set; } = Data.Collection<int>().Required();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":[1,2,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.Should()
					.BeEquivalentTo(new[] { 1, 2, 3 });

			[Fact]
			public void WithValueAndNull()
				=> Deserialize<TestClass>(@"{""Value"":[1,null,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull().AddPathIndex(1) });

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull() });

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.Required() });
		}

		public class NullableRequiredCollection
		{
			public class TestClass
			{
				public Data<Option<int[]>> Value { get; set; } = Data.Collection<int>().Required().Nullable();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":[1,2,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentTo(new[] { 1, 2, 3 });

			[Fact]
			public void WithValueAndNull()
				=> Deserialize<TestClass>(@"{""Value"":[1,null,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull().AddPathIndex(1) });

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.Required() });
		}

		public class OptionalCollection
		{
			public class TestClass
			{
				public Data<Option<int[]>> Value { get; set; } = Data.Collection<int>().Optional();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":[1,2,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentTo(new[] { 1, 2, 3 });

			[Fact]
			public void WithValueAndNull()
				=> Deserialize<TestClass>(@"{""Value"":[1,null,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull().AddPathIndex(1) });

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull() });

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();
		}

		public class NullableOptionalCollection
		{
			public class TestClass
			{
				public Data<Option<int[]>> Value { get; set; } = Data.Collection<int>().Optional().Nullable();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":[1,2,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentTo(new[] { 1, 2, 3 });

			[Fact]
			public void WithValueAndNull()
				=> Deserialize<TestClass>(@"{""Value"":[1,null,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull().AddPathIndex(1) });

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();
		}

		public class DefaultedCollection
		{
			public class TestClass
			{
				public Data<int[]> Value { get; set; } = Data.Collection<int>().Defaulted(new[] { 4, 5 });
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":[1,2,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.Should()
					.BeEquivalentTo(new[] { 1, 2, 3 });

			[Fact]
			public void WithValueAndNull()
				=> Deserialize<TestClass>(@"{""Value"":[1,null,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull().AddPathIndex(1) });

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull() });

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.Should()
					.BeEquivalentTo(new[] { 4, 5 });
		}

		public class NullableDefaultedCollection
		{
			public class TestClass
			{
				public Data<Option<int[]>> Value { get; set; } = Data.Collection<int>().Defaulted(new[] { 4, 5 }).Nullable();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":[1,2,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentTo(new[] { 1, 2, 3 });

			[Fact]
			public void WithValueAndNull()
				=> Deserialize<TestClass>(@"{""Value"":[1,null,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull().AddPathIndex(1) });

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentTo(new[] { 4, 5 });
		}

		public class RequiredNullableCollection
		{
			public class TestClass
			{
				public Data<Option<int>[]> Value { get; set; } = Data.Collection<int>(o => o.Nullable()).Required();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":[1,2,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.Should()
					.BeEquivalentToNullables(new int?[] { 1, 2, 3 });

			[Fact]
			public void WithValueAndNull()
				=> Deserialize<TestClass>(@"{""Value"":[1,null,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.Should()
					.BeEquivalentToNullables(new int?[] { 1, null, 3 });

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull() });

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.Required() });
		}

		public class NullableRequiredNullableCollection
		{
			public class TestClass
			{
				public Data<Option<Option<int>[]>> Value { get; set; } = Data.Collection<int>(o => o.Nullable()).Required().Nullable();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":[1,2,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentToNullables(new int?[] { 1, 2, 3 });

			[Fact]
			public void WithValueAndNull()
				=> Deserialize<TestClass>(@"{""Value"":[1,null,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentToNullables(new int?[] { 1, null, 3 });

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.Required() });
		}

		public class OptionalNullableCollection
		{
			public class TestClass
			{
				public Data<Option<Option<int>[]>> Value { get; set; } = Data.Collection<int>(o => o.Nullable()).Optional();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":[1,2,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentToNullables(new int?[] { 1, 2, 3 });

			[Fact]
			public void WithValueAndNull()
				=> Deserialize<TestClass>(@"{""Value"":[1,null,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentToNullables(new int?[] { 1, null, 3 });

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull() });

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();
		}

		public class NullableOptionalNullableCollection
		{
			public class TestClass
			{
				public Data<Option<Option<int>[]>> Value { get; set; } = Data.Collection<int>(o => o.Nullable()).Optional().Nullable();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":[1,2,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentToNullables(new int?[] { 1, 2, 3 });

			[Fact]
			public void WithValueAndNull()
				=> Deserialize<TestClass>(@"{""Value"":[1,null,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentToNullables(new int?[] { 1, null, 3 });

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();
		}

		public class DefaultedNullableCollection
		{
			public class TestClass
			{
				public Data<Option<int>[]> Value { get; set; } = Data.Collection<int>(o => o.Nullable()).Defaulted(new int?[] { null, 5 });
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":[1,2,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.Should()
					.BeEquivalentToNullables(new int?[] { 1, 2, 3 });

			[Fact]
			public void WithValueAndNull()
				=> Deserialize<TestClass>(@"{""Value"":[1,null,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.Should()
					.BeEquivalentToNullables(new int?[] { 1, null, 3 });

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.NotNull() });

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.Should()
					.BeEquivalentToNullables(new int?[] { null, 5 });
		}

		public class NullableDefaultedNullableCollection
		{
			public class TestClass
			{
				public Data<Option<Option<int>[]>> Value { get; set; } = Data.Collection<int>(o => o.Nullable()).Defaulted(new int?[] { null, 5 }).Nullable();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":[1,2,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentToNullables(new int?[] { 1, 2, 3 });

			[Fact]
			public void WithValueAndNull()
				=> Deserialize<TestClass>(@"{""Value"":[1,null,3]}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentToNullables(new int?[] { 1, null, 3 });

			[Fact]
			public void WithNull()
				=> Deserialize<TestClass>(@"{""Value"":null}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();

			[Fact]
			public void WithUnSet()
				=> Deserialize<TestClass>(@"{}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.BeEquivalentToNullables(new int?[] { null, 5 });
		}

		private static T Deserialize<T>(string json)
			=> JsonConvert.DeserializeObject<T>(json, new ValigatorConverter());
	}
}
