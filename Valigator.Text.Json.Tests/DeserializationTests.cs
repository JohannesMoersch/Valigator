using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using FluentAssertions;
using Functional;
using Valigator.Core;
using Valigator.Core.ValueDescriptors;
using Valigator.Tests.Common;
using Valigator.Text.Json.Tests;
using Xunit;

namespace Valigator.Tests.Text.Json
{
	public class DeserializationTests
	{
		public class Required
		{
			[ValigatorModel]
			public class TestClass
			{
				public Data<int> Value { get; set; } = Data.Required<int>();
			}

			[ValigatorModel]
			public class TestGuidClass
			{
				public Data<Guid> Value { get; set; } = Data.Required<Guid>();
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
					.AssertFailure()
					.Should()
					.BeEquivalentTo(new[] { ValidationErrors.Required() });
		}

		public class NullableRequired
		{
			[ValigatorModel]
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
			[ValigatorModel]
			public class TestClass
			{
				public Data<Optional<int>> Value { get; set; } = Data.Optional<int>();
			}

			[Fact]
			public void WithValue()
				=> Deserialize<TestClass>(@"{""Value"":10}")
					.Value
					.Verify()
					.TryGetValue()
					.AssertSuccess()
					.AssertSet()
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
					.AssertUnset();
		}

		public class NullableOptional
		{
			[ValigatorModel]
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
			[ValigatorModel]
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
			[ValigatorModel]
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
			[ValigatorModel]
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
			[ValigatorModel]
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
			[ValigatorModel]
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
			[ValigatorModel]
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
			[ValigatorModel]
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
			[ValigatorModel]
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
			[ValigatorModel]
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
			[ValigatorModel]
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
			[ValigatorModel]
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
			[ValigatorModel]
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
			[ValigatorModel]
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

			[ValigatorModel]
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
			=> JsonSerializer.Deserialize<T>(json, JsonTestSettings.SystemTextJsonSettings);
	}
}
