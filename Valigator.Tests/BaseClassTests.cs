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
		public void Test()
		{
			var testClass = new TestClass(1, 2, 3, 4, 5, 6);

			Model
				.Verify(testClass)
				.AssertSuccess();

			testClass.BaseStuff.Value.Should().Be(2);
			testClass.Stuff.Value.Should().Be(1);
		}

		private class MissingGetterOnRegularProperty
		{
			public Data<int> MissingGetter { set { throw new NotImplementedException(); } }
		}
		[Fact]
		public void ShouldFailMissingGetterOnRegularProperty() => Assert.Throws<MissingGettersOrSettersException>(() => Model.Verify(new MissingGetterOnRegularProperty()));

		private class MissingSetterOnRegularProperty
		{
			public Data<int> MissingGetter { get; }
		}
		[Fact]
		public void ShouldFailMissingSetterOnRegularProperty() => Assert.Throws<MissingGettersOrSettersException>(() => Model.Verify(new MissingSetterOnRegularProperty()));


		public interface IInterface
		{
			Data<int> InterfaceStuff { get; }
		}

		public interface IExplicit
		{
			Data<int> InterfaceStuff { get; set; }
		}

		public class BasestOfClasses
		{
			public BasestOfClasses(int hiddenStuff, int privateSetter)
			{
				HiddenStuff = HiddenStuff.WithValue(hiddenStuff);
				PrivateSetter = PrivateSetter.WithValue(privateSetter);
			}

			public virtual Data<int> HiddenStuff { get; private set; } = Data.Required<int>();
			public virtual Data<int> PrivateSetter { get; private set; } = Data.Required<int>();
		}

		public class BaseClass : BasestOfClasses, IInterface, IExplicit
		{
			public BaseClass(int baseStuff, int hiddenStuff, int interfaceStuff, int expicitInterfaceStuff, int privateSetter) : base(hiddenStuff, privateSetter)
			{
				BaseStuff = BaseStuff.WithValue(baseStuff);
				InterfaceStuff = InterfaceStuff.WithValue(interfaceStuff);
				(this as IExplicit).InterfaceStuff = (this as IExplicit).InterfaceStuff.WithValue(expicitInterfaceStuff);
			}

			public override Data<int> HiddenStuff { get => base.HiddenStuff; }
			public override Data<int> PrivateSetter { get => base.PrivateSetter; }

			public Data<int> BaseStuff { get; private set; } = Data.Required<int>();

			public Data<int> InterfaceStuff { get; private set; } = Data.Required<int>();
			Data<int> IExplicit.InterfaceStuff { get; set; } = Data.Required<int>();
		}

		public class TestClass : BaseClass
		{
			public TestClass(int stuff, int baseStuff, int hiddenStuff, int interfaceStuff, int expicitInterfaceStuff, int privateSetter) : base(baseStuff, 999, interfaceStuff, expicitInterfaceStuff, privateSetter)
			{
				Stuff = Stuff.WithValue(stuff);
				HiddenStuff = HiddenStuff.WithValue(hiddenStuff);
			}

			public Data<int> Stuff { get; private set; } = Data.Required<int>();
			public new Data<int> HiddenStuff { get; private set; } = Data.Required<int>();
		}
	}
}
