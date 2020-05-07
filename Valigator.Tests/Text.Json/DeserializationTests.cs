using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using FluentAssertions;
using Functional;
using Valigator.Core;
using Valigator.Core.ValueDescriptors;
using Xunit;

namespace Valigator.Tests.Text.Json
{
	public class DeserializationTests
	{
		public class Required
		{
			[ValigatorConverter]
			public class TestClass
			{
				public Data<int> Value { get; set; } = Data.Required<int>();
			}

			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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
			[ValigatorConverter]
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

			[ValigatorConverter]
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
			=> JsonSerializer.Deserialize<T>(json);
	}
}
