using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Valigator.Models.Generator.Tests
{
	public partial class DerivedGenerateModelAttributePathTests
	{
		public partial class ModelName
		{
			[GenerateModelDefaults(ModelName = "TestOne")]
			public class GenerateHardcodedDefaultNameWithSuccessfulDefaultMatchModelAttribute : GenerateModelAttribute { }
			[GenerateHardcodedDefaultNameWithSuccessfulDefaultMatchModel]
			public partial class HardcodedDefaultNameWithSuccessfulDefaultMatchModelDefinition { }
			[Fact]
			public void HardcodedDefaultNameWithSuccessfulDefaultMatch()
				=> typeof(TestOne)
					.Should()
					.HaveSameParentClassesAs(typeof(HardcodedDefaultNameWithSuccessfulDefaultMatchModelDefinition)).And
					.HaveSameNamespaceAs(typeof(HardcodedDefaultNameWithSuccessfulDefaultMatchModelDefinition));


			[GenerateModelDefaults(ModelNameCaptureRegex = "(.*[\\.\\+])?([^\\.\\+]+)FromOverriddenDefaultMatchModelDefinition")]
			public class GenerateDefaultModelNameFromOverriddenDefaultMatchModelAttribute : GenerateModelAttribute { }
			[GenerateDefaultModelNameFromOverriddenDefaultMatchModel]
			public partial class DefaultModelNameFromOverriddenDefaultMatchModelDefinition { }
			[Fact]
			public void DefaultModelNameFromOverriddenDefaultMatch()
				=> typeof(DefaultModelName)
					.Should()
					.HaveSameParentClassesAs(typeof(DefaultModelNameFromOverriddenDefaultMatchModelDefinition)).And
					.HaveSameNamespaceAs(typeof(DefaultModelNameFromOverriddenDefaultMatchModelDefinition));
		}

		public partial class ModelParentClasses
		{
			[GenerateModelDefaults(ModelParentClasses = "GeneratedTestClasses+TestOne")]
			public class GenerateHardcodedDefaultParentClassesWithSuccessfulDefaultMatchModelAttribute : GenerateModelAttribute { }
			[GenerateHardcodedDefaultParentClassesWithSuccessfulDefaultMatchModel]
			public partial class HardcodedDefaultParentClassesWithSuccessfulDefaultMatchModelDefinition { }
			[Fact]
			public void HardcodedDefaultParentClassesWithSuccessfulDefaultMatch()
				=> typeof(GeneratedTestClasses.TestOne.HardcodedDefaultParentClassesWithSuccessfulDefaultMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(GeneratedTestClasses), "TestOne").And
					.HaveSameNamespaceAs(typeof(HardcodedDefaultParentClassesWithSuccessfulDefaultMatchModelDefinition));

			[GenerateModelDefaults(ModelParentClassesCaptureRegex = "(.+[\\.])?(([^\\.]+)\\+)?ModelParentClasses\\+[^\\+]+")]
			public class GenerateDefaultModelParentClassesFromOverriddenDefaultMatchModelAttribute : GenerateModelAttribute { }
			[GenerateDefaultModelParentClassesFromOverriddenDefaultMatchModel]
			public partial class DefaultModelParentClassesFromOverriddenDefaultMatchModelDefinition { }
			[Fact]
			public void DefaultModelParentClassesFromOverriddenDefaultMatch()
				=> typeof(DefaultModelParentClassesFromOverriddenDefaultMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(DerivedGenerateModelAttributePathTests)).And
					.HaveSameNamespaceAs(typeof(DefaultModelParentClassesFromOverriddenDefaultMatchModelDefinition));
		}

		public partial class ModelNamespace
		{
			[GenerateModelDefaults(ModelNamespace = "Generated.TestOne")]
			public class GenerateHardcodedDefaultNamespaceWithSuccessfulDefaultMatchModelAttribute : GenerateModelAttribute { }
			[GenerateHardcodedDefaultNamespaceWithSuccessfulDefaultMatchModel]
			public partial class HardcodedDefaultNamespaceWithSuccessfulDefaultMatchModelDefinition { }
			[Fact]
			public void HardcodedDefaultNamespaceWithSuccessfulDefaultMatch()
				=> typeof(Generated.TestOne.DerivedGenerateModelAttributePathTests.ModelNamespace.HardcodedDefaultNamespaceWithSuccessfulDefaultMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(DerivedGenerateModelAttributePathTests), nameof(ModelNamespace)).And
					.HaveNamespaceOf("Generated.TestOne");

			[GenerateModelDefaults(ModelNamespaceCaptureRegex = "((.*)[\\.])?Tests\\.([^\\.]+)")]
			public class GenerateDefaultModelNamespaceFromOverriddenDefaultMatchModelAttribute : GenerateModelAttribute { }
			[GenerateDefaultModelNamespaceFromOverriddenDefaultMatchModel]
			public partial class DefaultModelNamespaceFromOverriddenDefaultMatchModelDefinition { }
			[Fact]
			public void DefaultModelNamespaceFromOverriddenDefaultMatch()
				=> typeof(Generator.DerivedGenerateModelAttributePathTests.ModelNamespace.DefaultModelNamespaceFromOverriddenDefaultMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(DerivedGenerateModelAttributePathTests), nameof(ModelNamespace)).And
					.HaveNamespaceOf("Valigator.Models.Generator");
		}
	}
}
