using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Valigator.Tests.Common;
using Valigator.Text.Json;
using Valigator.Text.Json.Tests;
using Xunit;

namespace Valigator.Tests.Text.Json
{
	public class ModelTests
	{
		[ValigatorModel]
		public class TestClass : IEquatable<TestClass>
		{
			public TestClass() { }

			public TestClass(int value, int? nullableValue, int[] collectionOfValues, int?[] collectionOfNullableValues, int[] nullableCollectionOfValues, int?[] nullableCollectionOfNullableValues)
			{
				Value = Value.WithValue(value);
				NullableValue = NullableValue.WithValue(nullableValue);
				CollectionOfValues = CollectionOfValues.WithValue(collectionOfValues);
				CollectionOfNullableValues = CollectionOfNullableValues.WithValue(collectionOfNullableValues);
				NullableCollectionOfValues = NullableCollectionOfValues.WithValue(nullableCollectionOfValues);
				NullableCollectionOfNullableValues = NullableCollectionOfNullableValues.WithValue(nullableCollectionOfNullableValues);
			}

			public Data<int> Value { get; set; } = Data.Required<int>();

			public Data<Option<int>> NullableValue { get; set; } = Data.Required<int>().Nullable();

			public Data<int[]> CollectionOfValues { get; set; } = Data.Collection<int>().Required();

			public Data<Option<int>[]> CollectionOfNullableValues { get; set; } = Data.Collection<int>(i => i.Nullable()).Required();

			public Data<Option<int[]>> NullableCollectionOfValues { get; set; } = Data.Collection<int>().Required().Nullable();

			public Data<Option<Option<int>[]>> NullableCollectionOfNullableValues { get; set; } = Data.Collection<int>(i => i.Nullable()).Required().Nullable();

			public override bool Equals(object obj) 
				=> Equals(obj as TestClass);

			public bool Equals(TestClass other)
				=> other != null &&
					EqualityComparer<int>.Default.Equals(Value.Value, other.Value.Value) &&
					EqualityComparer<Option<int>>.Default.Equals(NullableValue.Value, other.NullableValue.Value) &&
					CollectionOfValues.Value.SequenceEqual(other.CollectionOfValues.Value) &&
					CollectionOfNullableValues.Value.SequenceEqual(other.CollectionOfNullableValues.Value) &&
					NullableCollectionOfValues.Value.Match(left => other.NullableCollectionOfValues.Value.Match(right => left.SequenceEqual(right), () => false), () => !other.NullableCollectionOfValues.Value.HasValue()) &&
					NullableCollectionOfNullableValues.Value.Match(left => other.NullableCollectionOfNullableValues.Value.Match(right => left.SequenceEqual(right), () => false), () => !other.NullableCollectionOfNullableValues.Value.HasValue());
			
			public override int GetHashCode() 
				=> HashCode
					.Combine
					(
						Value, 
						NullableValue, 
						CollectionOfValues, 
						CollectionOfNullableValues, 
						NullableCollectionOfValues, 
						NullableCollectionOfNullableValues
					);

			public static TestClass CreateWithAllValues()
				=> new TestClass
				(
					1,
					1,
					new int[] { 1, 2 },
					new int?[] { 1, 2 },
					new int[] { 1, 2 },
					new int?[] { 1, 2 }
				);

			public static TestClass CreateWithSomeValues()
				=> new TestClass
				(
					1,
					null,
					new int[] { 1, 2 },
					new int?[] { null, null },
					new int[] { 1, 2 },
					new int?[] { null, null }
				);

			public static TestClass CreateWithNoValues()
				=> new TestClass
				(
					1,
					null,
					new int[] { 1, 2 },
					new int?[] { null, null },
					null,
					null
				);
		}

		[Fact]
		public void DeserializingWithAllValues()
			=> JsonSerializer
				.Deserialize<TestClass>(@"
					{
						""Value"": 1,
						""NullableValue"": 1,
						""CollectionOfValues"": [1, 2],
						""CollectionOfNullableValues"": [1, 2],
						""NullableCollectionOfValues"": [1, 2],
						""NullableCollectionOfNullableValues"": [1, 2]
					}",
					JsonTestSettings.SystemTextJsonSettings
				)
				.Verify()
				.Should()
				.Be(TestClass.CreateWithAllValues().Verify());

		[Fact]
		public void DeserializingWithSomeValues()
			=> JsonSerializer
				.Deserialize<TestClass>(@"
					{
						""Value"": 1,
						""NullableValue"": null,
						""CollectionOfValues"": [1, 2],
						""CollectionOfNullableValues"": [null, null],
						""NullableCollectionOfValues"": [1, 2],
						""NullableCollectionOfNullableValues"": [null, null]
					}",
					JsonTestSettings.SystemTextJsonSettings
				)
				.Verify()
				.Should()
				.Be(TestClass.CreateWithSomeValues().Verify());

		[Fact]
		public void DeserializingWithNoValues()
			=> JsonSerializer
				.Deserialize<TestClass>(@"
					{
						""Value"": 1,
						""NullableValue"": null,
						""CollectionOfValues"": [1, 2],
						""CollectionOfNullableValues"": [null, null],
						""NullableCollectionOfValues"": null,
						""NullableCollectionOfNullableValues"": null
					}",
					JsonTestSettings.SystemTextJsonSettings
				)
				.Verify()
				.Should()
				.Be(TestClass.CreateWithNoValues().Verify());

		[Fact]
		public void SerializingWithAllValues()
			=> JsonSerializer
				.Serialize(TestClass.CreateWithAllValues().Verify(), JsonTestSettings.SystemTextJsonSettings)
				.Should()
				.Be(@"
					{
						""Value"": 1,
						""NullableValue"": 1,
						""CollectionOfValues"": [1, 2],
						""CollectionOfNullableValues"": [1, 2],
						""NullableCollectionOfValues"": [1, 2],
						""NullableCollectionOfNullableValues"": [1, 2]
					}"
					.RemoveWhiteSpace()
				);

		[Fact]
		public void SerializingWithSomeValues()
			=> JsonSerializer
				.Serialize(TestClass.CreateWithSomeValues().Verify(), JsonTestSettings.SystemTextJsonSettings)
				.Should()
				.Be(@"
					{
						""Value"": 1,
						""NullableValue"": null,
						""CollectionOfValues"": [1, 2],
						""CollectionOfNullableValues"": [null, null],
						""NullableCollectionOfValues"": [1, 2],
						""NullableCollectionOfNullableValues"": [null, null]
					}"
					.RemoveWhiteSpace()
				);

		[Fact]
		public void SerializingWithNoValues()
			=> JsonSerializer
				.Serialize(TestClass.CreateWithNoValues().Verify(), JsonTestSettings.SystemTextJsonSettings)
				.Should()
				.Be(@"
					{
						""Value"": 1,
						""NullableValue"": null,
						""CollectionOfValues"": [1, 2],
						""CollectionOfNullableValues"": [null, null],
						""NullableCollectionOfValues"": null,
						""NullableCollectionOfNullableValues"": null
					}"
					.RemoveWhiteSpace()
				);
	}
}
