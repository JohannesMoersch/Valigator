using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Valigator.Models.Generator.Tests
{
	public partial class GenericModelTests
	{
		public class TestClass { }
		public interface TestInterface { }

		[GenerateModel]
		public partial class SystemTypeConstraintModelDefinition<T, U, V, W>
			where T : class
			where U : struct
			where V : unmanaged
			where W : notnull
		{ 
		}

		[Fact]
		public void SystemTypeConstaints()
			=> typeof(SystemTypeConstraintModel<,,,>)
				.Should()
				.HaveGenericTypeParameter(0, type => type.HaveReferenceTypeConstraint()).And
				.HaveGenericTypeParameter(1, type => type
					.HaveNotNullableValueTypeConstraint().And
					.HaveDefaultConstructorConstraint()
				).And
				.HaveGenericTypeParameter(2, type => type
					.HaveNotNullableValueTypeConstraint().And
					.HaveDefaultConstructorConstraint()
				).And
				.HaveGenericTypeParameter(3);
		
		[GenerateModel]
		public partial class NewContraintModelDefinition<T>
			where T : new()
		{
		}

		[Fact]
		public void NewContraints()
			=> typeof(NewContraintModel<>)
				.Should()
				.HaveGenericTypeParameter(0, type => type.HaveDefaultConstructorConstraint());

		[GenerateModel]
		public partial class TypeConstraintModelDefinition<T, U, V>
			where T : TestClass
			where U : TestInterface
			where V : T, U
		{
		}

		[Fact]
		public void TypeConstraints()
			=> typeof(TypeConstraintModel<,,>)
				.Should()
				.HaveGenericTypeParameter(0, t => t.HaveDerivesFromConstraint(typeof(TestClass))).And
				.HaveGenericTypeParameter(1, t => t.HaveDerivesFromConstraint(typeof(TestInterface))).And
				.HaveGenericTypeParameter(2, t => t.HaveDerivesFromConstraint(typeof(TypeConstraintModel<,,>).GetGenericArguments()[0], typeof(TypeConstraintModel<,,>).GetGenericArguments()[1]));

		[GenerateModel]
		public partial class NullableTypeConstraintModelDefinition<T, U, V, W>
			where T : class?
			where U : TestClass?
			where V : TestInterface?
			where W : U?, V?
		{
		}

		[Fact]
		public void NullableTypeConstraints()
			=> typeof(NullableTypeConstraintModelDefinition<,,,>)
				.Should()
				.HaveGenericTypeParameter(0, t => t.HaveReferenceTypeConstraint()).And
				.HaveGenericTypeParameter(1, t => t.HaveDerivesFromConstraint(typeof(TestClass))).And
				.HaveGenericTypeParameter(2, t => t.HaveDerivesFromConstraint(typeof(TestInterface))).And
				.HaveGenericTypeParameter(3, t => t.HaveDerivesFromConstraint(typeof(NullableTypeConstraintModelDefinition<,,,>).GetGenericArguments()[1], typeof(NullableTypeConstraintModelDefinition<,,,>).GetGenericArguments()[2]));
		
		[GenerateModel]
		public partial class CombinationConstraintModelDefinition<T>
			where T : class, TestInterface, new()
		{
		}

		[Fact]
		public void CombinationConstraints()
			=> typeof(CombinationConstraintModelDefinition<>)
				.Should()
				.HaveGenericTypeParameter
				(
					0, 
					t => t
						.HaveReferenceTypeConstraint().And
						.HaveDerivesFromConstraint(typeof(TestInterface)).And
						.HaveDefaultConstructorConstraint()
				);
	}
}
