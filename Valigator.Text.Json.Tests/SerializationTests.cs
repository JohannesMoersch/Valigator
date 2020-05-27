using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using FluentAssertions;
using Functional;
using Valigator.Text.Json.Tests;
using Xunit;

namespace Valigator.Tests.Text.Json
{
	public class SerializationTests
	{

		public class Required
		{
			[Fact]
			public void WithValue()
				=> new TestClass<int>(
						Data
						.Required<int>()
						.Data
						.WithValue(10)
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":10}");
		}

		public class NullableRequired
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Option<int>>(
						Data
						.Required<int>()
						.Nullable()
						.Data
						.WithValue(10)
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":10}");

			[Fact]
			public void WithNull()
				=> new TestClass<Option<int>>(
						Data
						.Required<int>()
						.Nullable()
						.Data
						.WithNull()
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");
		}

		public class Optional
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Optional<int>>(
						Data
						.Optional<int>()
						.Data
						.WithValue(10)
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":10}");

			[Fact]
			public void WithUnSet()
				=> new TestClass<Optional<int>>(
						Data
						.Optional<int>()
						.Data
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");
		}

		public class NullableOptional
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Option<int>>(
						Data
						.Optional<int>()
						.Nullable()
						.Data
						.WithValue(10)
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":10}");

			[Fact]
			public void WithNull()
				=> new TestClass<Option<int>>(
						Data
						.Optional<int>()
						.Nullable()
						.Data
						.WithNull()
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");

			[Fact]
			public void WithUnSet()
				=> new TestClass<Option<int>>(
						Data
						.Optional<int>()
						.Nullable()
						.Data
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");
		}

		public class Defaulted
		{
			[Fact]
			public void WithValue()
				=> new TestClass<int>(
						Data
						.Defaulted(5)
						.Data
						.WithValue(10)
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":10}");

			[Fact]
			public void WithUnSet()
				=> new TestClass<int>(
						Data
						.Defaulted(5)
						.Data
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":5}");
		}

		public class NullableDefaulted
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Option<int>>(
						Data
						.Defaulted(5)
						.Nullable()
						.Data
						.WithValue(10)
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":10}");

			[Fact]
			public void WithNull()
				=> new TestClass<Option<int>>(
						Data
						.Defaulted(5)
						.Nullable()
						.Data
						.WithNull()
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");

			[Fact]
			public void WithUnSet()
				=> new TestClass<Option<int>>(
						Data
						.Defaulted(5)
						.Nullable()
						.Data
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":5}");
		}

		public class RequiredCollection
		{
			[Fact]
			public void WithValue()
				=> new TestClass<int[]>(
						Data
						.Collection<int>()
						.Required()
						.Data
						.WithValue(new[] { 1, 2, 3 })
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[1,2,3]}");
		}

		public class NullableRequiredCollection
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Option<int[]>>(
						Data
						.Collection<int>()
						.Required()
						.Nullable()
						.Data
						.WithValue(new[] { 1, 2, 3 })
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[1,2,3]}");

			[Fact]
			public void WithNull()
				=> new TestClass<Option<int[]>>(
						Data
						.Collection<int>()
						.Required()
						.Nullable()
						.Data
						.WithNull()
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");
		}

		public class OptionalCollection
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Option<int[]>>(
						Data
						.Collection<int>()
						.Optional()
						.Data
						.WithValue(new[] { 1, 2, 3 })
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[1,2,3]}");

			[Fact]
			public void WithUnSet()
				=> new TestClass<Option<int[]>>(
						Data
						.Collection<int>()
						.Optional()
						.Data
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");
		}

		public class NullableOptionalCollection
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Option<int[]>>(
						Data
						.Collection<int>()
						.Optional()
						.Nullable()
						.Data
						.WithValue(new[] { 1, 2, 3 })
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[1,2,3]}");

			[Fact]
			public void WithNull()
				=> new TestClass<Option<int[]>>(
						Data
						.Collection<int>()
						.Optional()
						.Nullable()
						.Data
						.WithNull()
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");

			[Fact]
			public void WithUnSet()
				=> new TestClass<Option<int[]>>(
						Data
						.Collection<int>()
						.Optional()
						.Nullable()
						.Data
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");
		}

		public class DefaultedCollection
		{
			[Fact]
			public void WithValue()
				=> new TestClass<int[]>(
						Data
						.Collection<int>()
						.Defaulted(new[] { 4, 5 })
						.Data
						.WithValue(new[] { 1, 2, 3 })
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[1,2,3]}");

			[Fact]
			public void WithUnSet()
				=> new TestClass<int[]>(
						Data
						.Collection<int>()
						.Defaulted(new[] { 4, 5 })
						.Data
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[4,5]}");
		}

		public class NullableDefaultedCollection
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Option<int[]>>(
						Data
						.Collection<int>()
						.Defaulted(new[] { 4, 5 })
						.Nullable()
						.Data
						.WithValue(new[] { 1, 2, 3 })
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[1,2,3]}");

			[Fact]
			public void WithNull()
				=> new TestClass<Option<int[]>>(
						Data
						.Collection<int>()
						.Defaulted(new[] { 4, 5 })
						.Nullable()
						.Data
						.WithNull()
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");

			[Fact]
			public void WithUnSet()
				=> new TestClass<Option<int[]>>(
						Data
						.Collection<int>()
						.Defaulted(new[] { 4, 5 })
						.Nullable()
						.Data
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[4,5]}");
		}

		public class RequiredNullableCollection
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Option<int>[]>(
						Data
						.Collection<int>(o => o.Nullable())
						.Required()
						.Data
						.WithValue(new int?[] { 1, null, 3 })
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[1,null,3]}");
		}

		public class NullableRequiredNullableCollection
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Option<Option<int>[]>>(
						Data
						.Collection<int>(o => o.Nullable())
						.Required()
						.Nullable()
						.Data
						.WithValue(new int?[] { 1, null, 3 })
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[1,null,3]}");

			[Fact]
			public void WithNull()
				=> new TestClass<Option<Option<int>[]>>(
						Data
						.Collection<int>(o => o.Nullable())
						.Required()
						.Nullable()
						.Data
						.WithNull()
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");
		}

		public class OptionalNullableCollection
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Option<Option<int>[]>>(
						Data
						.Collection<int>(o => o.Nullable())
						.Optional()
						.Data
						.WithValue(new int?[] { 1, null, 3 })
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[1,null,3]}");

			[Fact]
			public void WithUnSet()
				=> new TestClass<Option<Option<int>[]>>(
						Data
						.Collection<int>(o => o.Nullable())
						.Optional()
						.Data
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");
		}

		public class NullableOptionalNullableCollection
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Option<Option<int>[]>>(
						Data
						.Collection<int>(o => o.Nullable())
						.Optional()
						.Nullable()
						.Data
						.WithValue(new int?[] { 1, null, 3 })
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[1,null,3]}");

			[Fact]
			public void WithNull()
				=> new TestClass<Option<Option<int>[]>>(
						Data
						.Collection<int>(o => o.Nullable())
						.Optional()
						.Nullable()
						.Data
						.WithNull()
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");

			[Fact]
			public void WithUnSet()
				=> new TestClass<Option<Option<int>[]>>(
						Data
						.Collection<int>(o => o.Nullable())
						.Optional()
						.Nullable()
						.Data
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");
		}

		public class DefaultedNullableCollection
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Option<int>[]>(
						Data
						.Collection<int>(o => o.Nullable())
						.Defaulted(new int?[] { null, 5 })
						.Data
						.WithValue(new int?[] { 1, null, 3 })
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[1,null,3]}");

			[Fact]
			public void WithUnSet()
				=> new TestClass<Option<int>[]>(
						Data
						.Collection<int>(o => o.Nullable())
						.Defaulted(new int?[] { null, 5 })
						.Data
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[null,5]}");
		}

		public class NullableDefaultedNullableCollection
		{
			[Fact]
			public void WithValue()
				=> new TestClass<Option<Option<int>[]>>(
						Data
						.Collection<int>(o => o.Nullable())
						.Defaulted(new int?[] { null, 5 })
						.Nullable()
						.Data
						.WithValue(new int?[] { 1, null, 3 })
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[1,null,3]}");

			[Fact]
			public void WithNull()
				=> new TestClass<Option<Option<int>[]>>(
						Data
						.Collection<int>(o => o.Nullable())
						.Defaulted(new int?[] { null, 5 })
						.Nullable()
						.Data
						.WithNull()
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":null}");

			[Fact]
			public void WithUnSet()
				=> new TestClass<Option<Option<int>[]>>(
						Data
						.Collection<int>(o => o.Nullable())
						.Defaulted(new int?[] { null, 5 })
						.Nullable()
						.Data
					)
					.Serialize()
					.Should()
					.Be(@"{""Value"":[null,5]}");
		}

		[ValigatorModel]
		public class TestClass<TValue>
		{
			public Data<TValue> Value { get; }

			public TestClass(Data<TValue> value)
				=> Value = value.Verify();

			public string Serialize()
				=> JsonSerializer.Serialize(this, JsonTestSettings.SystemTextJsonSettings);
		}
	}
}
