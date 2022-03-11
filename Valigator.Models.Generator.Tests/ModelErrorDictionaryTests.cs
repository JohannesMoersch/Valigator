using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Valigator.Models.Generator.Tests
{
	public class ModelErrorDictionaryTests
	{
		private static readonly ValidationError[] ErrorsOne = new[] { Errors.One, Errors.Two };
		private static readonly ValidationError[] ErrorsTwo = new[] { Errors.Three };

		[Fact]
		public void AddWhenEmptyIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);

			dictionary["One"]
				.Should()
				.BeEquivalentTo(ErrorsOne);
		}

		[Fact]
		public void AddWhenNotEmptyIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);
			dictionary.Add("Two", ErrorsTwo);

			dictionary["Two"]
				.Should()
				.BeEquivalentTo(ErrorsTwo);
		}

		[Fact]
		public void AddDuplicateThrowsException()
			=> Assert
				.Throws<ArgumentException>
				(
					() =>
					{
						var dictionary = new ModelErrorDictionaryBase();

						dictionary.Add("One", ErrorsOne);
						dictionary.Add("One", ErrorsTwo);
					}
				);

		[Fact]
		public void AddNullValueThrowsException()
			=> Assert
				.Throws<ArgumentNullException>
				(
					() =>
					{
						var dictionary = new ModelErrorDictionaryBase();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
						dictionary.Add("One", null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
					}
				);

		[Fact]
		public void RemoveExistingItemIsSuccessfulAndReturnsTrue()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);
			dictionary.Add("Two", ErrorsTwo);

			dictionary
				.Remove("Two")
				.Should()
				.BeTrue();

			dictionary
				.ContainsKey("Two")
				.Should()
				.BeFalse();
		}

		[Fact]
		public void RemoveLastExistingItemIsSuccessfulAndReturnsTrue()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);

			dictionary
				.Remove("One")
				.Should()
				.BeTrue();

			dictionary
				.ContainsKey("One")
				.Should()
				.BeFalse();
		}

		[Fact]
		public void RemoveMissingItemReturnsFalse()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);

			dictionary
				.Remove("Two")
				.Should()
				.BeFalse();
		}

		[Fact]
		public void RemoveWhenEmptyReturnsFalse()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary
				.Remove("One")
				.Should()
				.BeFalse();
		}

		[Fact]
		public void SetNewItemWhenEmptyIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary["One"] = ErrorsOne;

			dictionary["One"]
				.Should()
				.BeEquivalentTo(ErrorsOne);
		}

		[Fact]
		public void SetNewItemWhenNotEmptyIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);

			dictionary["Two"] = ErrorsTwo;

			dictionary["Two"]
				.Should()
				.BeEquivalentTo(ErrorsTwo);
		}

		[Fact]
		public void SetExistingItemIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);

			dictionary["One"] = ErrorsTwo;

			dictionary["One"]
				.Should()
				.BeEquivalentTo(ErrorsTwo);
		}

		[Fact]
		public void SetToNullThrowsException()
			=> Assert
				.Throws<ArgumentNullException>
				(
					() =>
					{
						var dictionary = new ModelErrorDictionaryBase();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
						dictionary["One"] = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
					}
				);

		[Fact]
		public void ClearWhenEmptyIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Clear();

			dictionary
				.Count
				.Should()
				.Be(0);
		}

		[Fact]
		public void ClearWhenNotEmptyIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);
			dictionary.Add("Two", ErrorsTwo);

			dictionary.Clear();

			dictionary
				.Count
				.Should()
				.Be(0);
		}

		[Fact]
		public void TryGetValueForExistingItemIsSuccessfulReturnsTrue()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);

			dictionary
				.TryGetValue("One", out var value)
				.Should()
				.BeTrue();

			value
				.Should()
				.BeEquivalentTo(ErrorsOne);
		}

		[Fact]
		public void TryGetValueForMissingItemReturnsFalse()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);

			dictionary
				.TryGetValue("Two", out _)
				.Should()
				.BeFalse();
		}

		[Fact]
		public void TryGetValueWhenEmptyReturnsFalse()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary
				.TryGetValue("One", out _)
				.Should()
				.BeFalse();
		}

		[Fact]
		public void CountWhenEmptyIsZero()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary
				.Count
				.Should()
				.Be(0);
		}

		[Fact]
		public void CountWhenNotEmptyIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);
			dictionary.Add("Two", ErrorsTwo);

			dictionary
				.Count
				.Should()
				.Be(2);
		}

		[Fact]
		public void KeysWhenEmptyIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary
				.Keys
				.Should()
				.BeEmpty();
		}

		[Fact]
		public void KeysWhenNotEmptyIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);
			dictionary.Add("Two", ErrorsTwo);

			dictionary
				.Keys
				.Should()
				.BeEquivalentTo("One", "Two");
		}

		[Fact]
		public void ValuesWhenEmptyIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary
				.Values
				.Should()
				.BeEmpty();
		}

		[Fact]
		public void ValuesWhenNotEmptyIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);
			dictionary.Add("Two", ErrorsTwo);

			dictionary
				.Values
				.Should()
				.BeEquivalentTo(ErrorsOne, ErrorsTwo);
		}

		[Fact]
		public void ContainsKeyWhenEmptyReturnFalse()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary
				.ContainsKey("One")
				.Should()
				.BeFalse();
		}

		[Fact]
		public void ContainsKeyForExistingItemReturnsTrue()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);

			dictionary
				.ContainsKey("One")
				.Should()
				.BeTrue();
		}

		[Fact]
		public void ContainsKeyForMissingItemReturnsFalse()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);

			dictionary
				.ContainsKey("Two")
				.Should()
				.BeFalse();
		}

		[Fact]
		public void GetEnumeratorWhenEmptyIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();


			dictionary
				.Should()
				.BeEmpty();
		}

		[Fact]
		public void GetEnumeratorWhenNotEmptyIsSuccessful()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);
			dictionary.Add("Two", ErrorsTwo);

			dictionary
				.Should()
				.BeEquivalentTo(new KeyValuePair<string, ValidationError[]>("One", ErrorsOne), new KeyValuePair<string, ValidationError[]>("Two", ErrorsTwo));
		}

		[Fact]
		public void EditingCloneDoesNotModifyOriginal()
		{
			var dictionary = new ModelErrorDictionaryBase();

			dictionary.Add("One", ErrorsOne);

			var clone = dictionary.ToReadOnly().Clone();

			clone.Add("Two", ErrorsTwo);

			dictionary
				.Should()
				.NotBeEquivalentTo(clone);
		}
	}
}
