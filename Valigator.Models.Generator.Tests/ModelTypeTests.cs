using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Valigator.Models.Generator.Tests
{
	public partial class ModelTypeTests
	{
		public partial struct ValueTypeParent 
		{
			[GenerateModel]
			public partial class ModelDefinition { }
		}

		[Fact]
		public void HasValueTypeParent()
			   => typeof(ValueTypeParent.Model)
				   .Should()
				   .HaveParentClassesOfType(ObjectType.Reference, ObjectType.Value);

		public partial interface InterfaceTypeParent
		{
			[GenerateModel]
			public partial class ModelDefinition { }
		}

		[Fact]
		public void HasInterfaceTypeParent()
			   => typeof(InterfaceTypeParent.Model)
				   .Should()
				   .HaveParentClassesOfType(ObjectType.Reference, ObjectType.Interface);

		public partial class ReferenceTypeParent
		{
			[GenerateModel]
			public partial class ModelDefinition { }
		}

		[Fact]
		public void HasReferenceTypeParent()
			   => typeof(ReferenceTypeParent.Model)
				   .Should()
				   .HaveParentClassesOfType(ObjectType.Reference, ObjectType.Reference);

		[GenerateModel]
		public partial class ValueTypeModelDefinition 
		{
			public Property<int> Value => Data.Value<int>().Required();
		}

		public partial struct ValueTypeModel { }

		[Fact]
		public void IsValueType()
			   => typeof(ValueTypeModel)
				   .Should()
				   .Match(t => t.GetObjectType() == ObjectType.Value);

		[GenerateModel]
		public partial class ReferenceTypeModelDefinition
		{
			public Property<int> Value => Data.Value<int>().Required();
		}

		public partial class ReferenceTypeModel { }

		[Fact]
		public void IsReferenceType()
			   => typeof(ReferenceTypeModel)
				   .Should()
				   .Match(t => t.GetObjectType() == ObjectType.Reference);
	}
}
