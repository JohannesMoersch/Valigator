using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Xunit;

namespace Valigator.Tests
{
	public class BaseClassTests
	{
		[Fact]
		public void VerificationIsSuccessful()
		{
			var testClass = new TestClass(1, 2, 3, 4, 5, 6, 7);

			Model
				.Verify(testClass)
				.AssertSuccess();

			testClass.Property.Value.Should().Be(1);
			testClass.BaseProperty.Value.Should().Be(2);
			testClass.InterfaceProperty.Value.Should().Be(4);
			(testClass as IExplicit).InterfaceProperty.Value.Should().Be(5);
			testClass.PrivateSetter.Value.Should().Be(6);
			testClass.GetProtectedPropertyValue().Should().Be(7);
		}

		private class MissingGetterOnRegularProperty
		{
			public Data<int> MissingGetter { set { } }
		}
		[Fact]
		public void ShouldFailMissingGetterOnRegularProperty() => Assert.Throws<MissingAccessorsException>(() => Model.Verify(new MissingGetterOnRegularProperty()));

		private class MissingSetterOnRegularProperty
		{
			public Data<int> MissingGetter { get; }
		}
		[Fact]
		public void ShouldFailMissingSetterOnRegularProperty() => Assert.Throws<MissingAccessorsException>(() => Model.Verify(new MissingSetterOnRegularProperty()));

		private class MissingGetterOnRegularPrivateProperty
		{
			public Data<int> MissingGetter { set { } }
		}
		[Fact]
		public void ShouldFailMissingGetterOnRegularPrivateProperty() => Assert.Throws<MissingAccessorsException>(() => Model.Verify(new MissingGetterOnRegularPrivateProperty()));

		private class MissingSetterOnRegularPriveProperty
		{
			public Data<int> MissingGetter { get; }
		}
		[Fact]
		public void ShouldFailMissingSetterOnRegularPrivateProperty() => Assert.Throws<MissingAccessorsException>(() => Model.Verify(new MissingSetterOnRegularPriveProperty()));

		public interface IInterface
		{
			Data<int> InterfaceProperty { get; }
		}

		public interface IExplicit
		{
			Data<int> InterfaceProperty { get; set; }
		}

		private class MultiplePropertiesOneValue : IInterface, IExplicit
		{
			public MultiplePropertiesOneValue(int value)
				=> InterfaceProperty = InterfaceProperty.WithValue(value);

			public Data<int> InterfaceProperty { get; set; } = Data.Required<int>();
			Data<int> IExplicit.InterfaceProperty { get => InterfaceProperty; set => InterfaceProperty = value; }
		}

		[Fact]
		public void ShouldSucceedWithMultiplePropertiesPointAtOneValue()
		{
			var model = new MultiplePropertiesOneValue(10);
			Model.Verify(model);
			model.InterfaceProperty.Value.Should().Be(10);
			(model as IExplicit).InterfaceProperty.Value.Should().Be(10);
		}

		public class BasestOfClasses
		{
			public BasestOfClasses(int hiddenProperty, int privateSetter, int protectedProperty)
			{
				HiddenProperty = HiddenProperty.WithValue(hiddenProperty);
				PrivateSetter = PrivateSetter.WithValue(privateSetter);
				ProtectedProperty = ProtectedProperty.WithValue(protectedProperty);
			}

			public virtual Data<int> HiddenProperty { get; private set; } = Data.Required<int>();
			public virtual Data<int> PrivateSetter { get; private set; } = Data.Required<int>();
			protected virtual Data<int> ProtectedProperty { get; private set; } = Data.Required<int>();

			public int GetProtectedPropertyValue()
				=> ProtectedProperty.Value;
		}

		public class BaseClass : BasestOfClasses, IInterface, IExplicit
		{
			public BaseClass(int baseProperty, int hiddenProperty, int interfaceProperty, int expicitInterfaceProperty, int privateSetter, int protectedProperty) 
				: base(hiddenProperty, privateSetter, protectedProperty)
			{
				BaseProperty = BaseProperty.WithValue(baseProperty);
				InterfaceProperty = InterfaceProperty.WithValue(interfaceProperty);
				(this as IExplicit).InterfaceProperty = (this as IExplicit).InterfaceProperty.WithValue(expicitInterfaceProperty);
			}

			public override Data<int> HiddenProperty { get => base.HiddenProperty; }
			public override Data<int> PrivateSetter { get => base.PrivateSetter; }

			public Data<int> BaseProperty { get; private set; } = Data.Required<int>();

			public Data<int> InterfaceProperty { get; private set; } = Data.Required<int>();
			Data<int> IExplicit.InterfaceProperty { get; set; } = Data.Required<int>();
		}

		public class TestClass : BaseClass
		{
			public TestClass(int property, int baseHiddenProperty, int hiddenProperty, int interfaceStuff, int expicitInterfaceStuff, int privateSetter, int protectedProperty) 
				: base(baseHiddenProperty, 999, interfaceStuff, expicitInterfaceStuff, privateSetter, protectedProperty)
			{
				Property = Property.WithValue(property);
				HiddenProperty = HiddenProperty.WithValue(hiddenProperty);
			}

			public Data<int> Property { get; private set; } = Data.Required<int>();
			public new Data<int> HiddenProperty { get; private set; } = Data.Required<int>();
		}
	}
}
