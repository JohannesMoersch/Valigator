using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Functional;
using Valigator;
using Valigator.Tests.Common;
using Xunit;

namespace Valigator.Tests
{
	public class DataTests
	{
		[Fact]
		public void ValueNotInitialized()
			=> Assert.Throws<DataNotInitializedException>(() => default(Data<int>).Value);

		[Fact]
		public void WithValueNotInitialized()
			=> Assert.Throws<DataNotInitializedException>(() => default(Data<int>).WithValue(5));

		[Fact]
		public void VerifyNotInitialized()
			=> Assert.Throws<DataNotInitializedException>(() => default(Data<int>).Verify(new object()));

		[Fact]
		public void ValueNotSetNotVerified()
			=> Assert.Throws<DataNotVerifiedException>(() => Data.Required<int>().Data.Value);

		[Fact]
		public void ValueSetNotVerified()
			=> Assert.Throws<DataNotVerifiedException>(() => Data.Required<int>().Data.WithValue(5).Value);

		[Fact]
		public void ValueSetAndVerified()
			=> Data.Required<int>().Data.WithValue(5).Verify(new object()).TryGetValue().AssertSuccess().Should().Be(5);

		[Fact]
		public void ValueAlreadySet()
			=> Assert.Throws<DataAlreadySetException>(() => Data.Required<int>().Data.WithValue(5).WithValue(5));

		[Fact]
		public void ValueAlreadyVerified()
			=> Assert.Throws<DataAlreadyVerifiedException>(() => Data.Required<int>().Data.WithValue(5).Verify(new object()).Verify(new object()));

		[Fact]
		public void ValueNotInitializedGetDataDescriptor()
			=> Assert.Throws<DataNotInitializedException>(() => default(Data<int>).DataDescriptor);

		[Fact]
		public void ValueNotSetGetDataDescriptor()
			=> Data.Required<int>().Data.DataDescriptor.Should().NotBeNull();

		[Fact]
		public void ValueSetGetDataDescriptor()
			=> Data.Required<int>().Data.WithValue(5).DataDescriptor.Should().NotBeNull();

		[Fact]
		public void ValueSetAndVerifiedGetDataDescriptor()
			=> Data.Required<int>().Data.WithValue(5).Verify(new object()).DataDescriptor.Should().NotBeNull();

		[Fact]
		public void ShouldFailWhenSettingViaUnchecked()
		{
			var sut = new TestClass();
			sut.Value = sut.Value.WithMappedValue("0123456789ABC");

			var result = Model.Verify(sut);
			result.AssertFailure();
		}

		private class TestClass
		{
			public Data<Holder> Value { get; set; } = Holder.Valigator.Required;
		}
		
		private struct Holder : IEquatable<Holder>
		{
			public const int Length = 12;
			private readonly string _value;
			public string Value => _value ?? throw new Exception("Value not initialized");

			private Holder(string value)
				=> _value = value;

			public override bool Equals(object obj)
				=> obj is Holder ProductSku && Equals(ProductSku);

			public bool Equals(Holder other)
				=> _value == other._value;

			public override int GetHashCode()
				 => unchecked(-1939223833 + EqualityComparer<string>.Default.GetHashCode(_value));

			public static bool operator ==(Holder identifier1, Holder identifier2)
				=> identifier1.Equals(identifier2);

			public static bool operator !=(Holder identifier1, Holder identifier2)
				=> !(identifier1 == identifier2);

			public override string ToString()
				=> $"{nameof(Holder)}:{Value}";

			public static Result<Holder, string> Create(string holder)
			=> Result
				.Create
				(
					!String.IsNullOrWhiteSpace(holder) && holder.Length == Length,
					() => new Holder(holder),
					() => $"{nameof(Holder)}s must be exactly {Length} characters in length."
				);

			public static class Valigator
			{
				private static readonly Data<string> _data = Data.Required<string>().Length(Length, Length);

				public static Data<Holder> Required
					=> Data.Required<Holder>().MappedFrom<string>(CreateTestClass);

				private static Result<Holder, ValidationError[]> CreateTestClass(string str)
					=> _data.WithValue(str).Verify().TryGetValue().Select(x => new Holder(x));
			}
		}
	}
}
