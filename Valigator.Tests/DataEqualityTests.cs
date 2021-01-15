using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xunit;

namespace Valigator.Tests
{
	public class DataEqualityTests
	{
		[Fact]
		public void RecordEqualsItself()
		{
			var guid = Guid.NewGuid();
			var uniqueGuids = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };
			var item1 = TestRecord.CreateTestRecord(guid, uniqueGuids, new string[] { "1", "2", "3" });
			item1.Equals(item1).Should().BeTrue();
			item1.ID.Equals(item1.ID).Should().BeTrue();
			item1.UniqueGuid.Equals(item1.UniqueGuid).Should().BeTrue();
			item1.ArrayOfUniqueGuid.Equals(item1.ArrayOfUniqueGuid).Should().BeTrue();
			item1.UniqueName.Equals(item1.UniqueName).Should().BeTrue();
		}

		[Fact]
		public void RecordsEqual()
		{
			var guid = Guid.NewGuid();
			var uniqueGuids = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

			var item1 = TestRecord.CreateTestRecord(guid, uniqueGuids, new string[] { "1", "2", "3" });
			var item2 = TestRecord.CreateTestRecord(guid, uniqueGuids, new string[] { "1", "2", "3" });

			item1.Equals(item2).Should().BeTrue();
			(item1 == item2).Should().BeTrue();
			item1.Should().Be(item2);
			(item1 != item2).Should().BeFalse();
		}

		[Fact]
		public void RecordsDoNotEqual()
		{
			var guid = Guid.NewGuid();
			var uniqueGuids = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

			var item1 = TestRecord.CreateTestRecord(guid, uniqueGuids, new string[] { "1", "2", "3" });
			var item2 = TestRecord.CreateTestRecord(Guid.NewGuid(), uniqueGuids, new string[] { "1", "2", "3" });

			(item1.Equals(item2)).Should().BeFalse();
			(item1 == item2).Should().BeFalse();
			(item1 != item2).Should().BeTrue();
		}

		[Fact]
		public void IEnumerablesOtherThanArrayEqual()
		{
			var test = new ReadOnlyCollection<string>(new List<string>() { "123", "234", "456" });
			var collection = TestIEnumerableRecord.CreateTestIEnumerableRecord(test);
			var collection2 = TestIEnumerableRecord.CreateTestIEnumerableRecord(test);
			(collection == collection2).Should().BeTrue();
			(collection.ReadOnlyCollection == collection2.ReadOnlyCollection).Should().BeTrue();
			(collection != collection2).Should().BeFalse();
			(collection.ReadOnlyCollection != collection2.ReadOnlyCollection).Should().BeFalse();

		}

		[Fact]
		public void IEnumerablesOtherThanArrayDoNotEqual()
		{
			var collection = TestIEnumerableRecord.CreateTestIEnumerableRecord(new ReadOnlyCollection<string>(new List<string>() { "123", "234", "456" }));
			var collection2 = TestIEnumerableRecord.CreateTestIEnumerableRecord(new ReadOnlyCollection<string>(new List<string>() {"234", "456", "123" }));
			(collection == collection2).Should().BeFalse();
			(collection.ReadOnlyCollection == collection2.ReadOnlyCollection).Should().BeFalse();
			(collection != collection2).Should().BeTrue();
			(collection.ReadOnlyCollection != collection2.ReadOnlyCollection).Should().BeTrue();
		}


		[Fact]
		public void RemoveDescriptors()
		{
			var guid = Guid.NewGuid();
			var uniqueGuids = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

			var item1 = TestRecord.CreateTestRecord(guid, uniqueGuids, new string[] { "1", "2", "3" });

			item1.UniqueName.Equals(item1.UniqueNameWithDifferentDataDescriptors).Should().BeFalse();
		}

		[Fact]
		public void CompareDataStringArrayEquality()
		{
			var guid = Guid.NewGuid();
			var uniqueGuids = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

			var item1 = TestRecord.CreateTestRecord(guid, uniqueGuids, new string[] { "1", "2", "3" });
			var item2 = TestRecord.CreateTestRecord(guid, uniqueGuids, new string[] { "1", "2", "3" });

			item1.ArrayOfString.Equals(item2.ArrayOfString).Should().BeTrue();
		}

		[Fact]
		public void CompareDataArrayHashCode()
		{
			var guid = Guid.NewGuid();
			var uniqueGuids = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

			var item1 = TestRecord.CreateTestRecord(guid, uniqueGuids, new string[] { "1", "2", "3" });
			var item2 = TestRecord.CreateTestRecord(guid, uniqueGuids, new string[] { "1", "2", "3" });

			item1.ArrayOfUniqueGuid.GetHashCode().Equals(item2.ArrayOfUniqueGuid.GetHashCode()).Should().BeTrue();
		}

		[Fact]
		public void CompareRecordHashCode()
		{
			var guid = Guid.NewGuid();
			var uniqueGuids = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

			var item1 = TestRecord.CreateTestRecord(guid, uniqueGuids, new string[] { "1", "2", "3" });
			var item2 = TestRecord.CreateTestRecord(guid, uniqueGuids, new string[] { "1", "2", "3" });

			item1.GetHashCode().Equals(item2.GetHashCode()).Should().BeTrue();
		}

		[Fact]
		public void CompareDifferentHashCode()
		{
			var uniqueGuids = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

			var item1 = TestRecord.CreateTestRecord(Guid.NewGuid(), uniqueGuids, new string[] { "1", "2", "3" });
			var item2 = TestRecord.CreateTestRecord(Guid.NewGuid(), uniqueGuids, new string[] { "1", "2", "3" });

			item1.UniqueGuid.Equals(item2.UniqueGuid).Should().BeFalse();
		}

		[Fact]
		public void IEnumerablesDifferentNumberOfElements()
		{
			var collection = TestIEnumerableRecord.CreateTestIEnumerableRecord(new ReadOnlyCollection<string>(new List<string>() { "123", "234", "456", "456" }));
			var collection2 = TestIEnumerableRecord.CreateTestIEnumerableRecord(new ReadOnlyCollection<string>(new List<string>() { "123", "234", "456" }));
			(collection == collection2).Should().BeFalse();
			(collection.ReadOnlyCollection == collection2.ReadOnlyCollection).Should().BeFalse();
			(collection != collection2).Should().BeTrue();
			(collection.ReadOnlyCollection != collection2.ReadOnlyCollection).Should().BeTrue();
		}



		public record TestRecord
		{


			public static TestRecord CreateTestRecord(Guid liiGuid, Guid[] uniqueGuids, string[] stringArray)
			{
				return new TestRecord(1, PrimitiveLikeTypeHelpers.CreateNew(liiGuid), "***", uniqueGuids.Select(guid => PrimitiveLikeTypeHelpers.CreateNew(guid)).ToArray(), stringArray);
			}

			private TestRecord(int id, PrimitiveLikeType lineItemID, string taxName, PrimitiveLikeType[] uniquePrimitives, string[] stringArray)
			{
				ID = ID.WithValue(id).Verify();
				UniqueGuid = UniqueGuid.WithUncheckedValue(lineItemID).Verify();
				UniqueName = UniqueName.WithValue(taxName).Verify();
				UniqueNameWithDifferentDataDescriptors = UniqueNameWithDifferentDataDescriptors.WithValue(taxName).Verify();
				ArrayOfUniqueGuid = ArrayOfUniqueGuid.WithValue(uniquePrimitives).Verify();
				ArrayOfString = ArrayOfString.WithValue(stringArray).Verify();
			}

			public Data<int> ID { get; private set; } = Data.Required<int>();

			public Data<PrimitiveLikeType> UniqueGuid { get; private set; } = PrimitiveLikeType.Valigator.Required;

			public Data<string> UniqueName { get; private set; } = Data.Required<string>().Length(minimumLength: 1, maximumLength: 255);

			public Data<string> UniqueNameWithDifferentDataDescriptors { get; private set; } = Data.Required<string>().Length(minimumLength: 3, maximumLength: 255);

			public Data<PrimitiveLikeType[]> ArrayOfUniqueGuid = Data.Collection<PrimitiveLikeType>().Required().ItemCount(minimumItems: 1, maximumItems: 4);

			public Data<string[]> ArrayOfString = Data.Collection<string>().Required().ItemCount(minimumItems: 1, maximumItems: 3);
		}

		public record TestIEnumerableRecord
		{

			public Data<ReadOnlyCollection<string>> ReadOnlyCollection = Data.Required<ReadOnlyCollection<string>>();

			public static TestIEnumerableRecord CreateTestIEnumerableRecord(ReadOnlyCollection<string> readOnlyCollection) 
				=> new TestIEnumerableRecord(readOnlyCollection);

			private TestIEnumerableRecord(ReadOnlyCollection<string> readOnlyCollection) 
				=> ReadOnlyCollection = ReadOnlyCollection.WithValue(readOnlyCollection).Verify();
		}
		public readonly struct PrimitiveLikeType : IEquatable<PrimitiveLikeType>
		{
			private readonly Option<Guid> _value;
			internal readonly Guid Value => _value.Match(s => s, () => throw new ValueTypeNotInitializedException(typeof(PrimitiveLikeType)));

			internal PrimitiveLikeType(Guid value)
				=> _value = Option.Some(value);

			public override readonly bool Equals(object obj)
				=> obj is PrimitiveLikeType productSku && Equals(productSku);

			public override readonly int GetHashCode()
				=> _value.GetHashCode();

			public readonly bool Equals(PrimitiveLikeType other)
				=> _value == other._value;

			public static bool operator ==(PrimitiveLikeType identifier1, PrimitiveLikeType identifier2)
				=> identifier1.Equals(identifier2);

			public static bool operator !=(PrimitiveLikeType identifier1, PrimitiveLikeType identifier2)
				=> !(identifier1 == identifier2);

			public override string ToString()
				=> $"{Value}";

			public static class Valigator
			{
				private static readonly Data<Guid> _data = Data.Required<Guid>().NotEmpty();

				public static Data<PrimitiveLikeType> Required { get; } 
					= Data.Required<PrimitiveLikeType>().MappedFrom<Guid>(CreateLineItemIdentifier, _ => _data);

				public static Data<Option<PrimitiveLikeType>> Optional { get; } = Data.Optional<PrimitiveLikeType>().MappedFrom<Guid>(CreateLineItemIdentifier, _ => _data);

				public static Data<Option<PrimitiveLikeType[]>> OptionalCollection { get; }
					= Data.Collection<PrimitiveLikeType>().Optional().MappedFrom<Guid>(CreateLineItemIdentifier, _ => _data);

				public static Data<PrimitiveLikeType[]> RequiredCollection { get; }
					= Data.Collection<PrimitiveLikeType>().Required().MappedFrom<Guid>(CreateLineItemIdentifier, _ => _data);

				private static PrimitiveLikeType CreateLineItemIdentifier(Guid guid)
					=> new(guid);
			}

		}
		public class ValueTypeNotInitializedException : Exception
		{
			public ValueTypeNotInitializedException(Type type) : base($"Value type '{type.Name}' not initialized.") { }
		}
		private static class PrimitiveLikeTypeHelpers
		{
			public static PrimitiveLikeType CreateNew()
				=> new(Guid.NewGuid());

			public static PrimitiveLikeType CreateNew(Guid guid)
				=> new(guid);
		}
	}
}
