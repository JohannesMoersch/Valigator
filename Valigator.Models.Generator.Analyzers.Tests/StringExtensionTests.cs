using FluentAssertions;
using System;
using Xunit;

namespace Valigator.Models.Generator.Analyzers.Tests
{
	public class StringExtensionTests
	{
		public class EnsureRegexMatchesFullInput
		{
			[Fact]
			public void HasNoStartOrEndSymbol()
				=> "test"
					.EnsureRegexMatchesFullInput()
					.Should()
					.Be("^test$");

			[Fact]
			public void HasStartSymbolOnly()
				=> "^test"
					.EnsureRegexMatchesFullInput()
					.Should()
					.Be("^test$");

			[Fact]
			public void HasEndSymbolOnly()
				=> "test$"
					.EnsureRegexMatchesFullInput()
					.Should()
					.Be("^test$");

			[Fact]
			public void HasStartAndEndSymbol()
				=> "^test$"
					.EnsureRegexMatchesFullInput()
					.Should()
					.Be("^test$");
		}

		public class JoinListWithOxfordComma
		{
			[Fact]
			public void EmptyList()
				=> Array
					.Empty<string>()
					.JoinListWithOxfordComma()
					.Should()
					.Be(String.Empty);

			[Fact]
			public void OneItemList()
				=> new[] { "one" }
					.JoinListWithOxfordComma()
					.Should()
					.Be("one");

			[Fact]
			public void TwoItemList()
				=> new[] { "one", "two" }
					.JoinListWithOxfordComma()
					.Should()
					.Be("one and two");

			[Fact]
			public void ThreeItemList()
				=> new[] { "one", "two", "three" }
					.JoinListWithOxfordComma()
					.Should()
					.Be("one, two, and three");

			[Fact]
			public void FourItemList()
				=> new[] { "one", "two", "three", "four" }
					.JoinListWithOxfordComma()
					.Should()
					.Be("one, two, three, and four");
		}
	}
}
