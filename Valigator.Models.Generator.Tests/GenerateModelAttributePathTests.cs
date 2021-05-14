using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Valigator.Models.Generator.Tests
{
	public partial class GenerateModelAttributePathTests
	{
		public partial class ModelName
		{
			[GenerateModel(ModelName = "TestOne", ModelNameCaptureRegex = "MatchThatFails")]
			public partial class HardcodedNameWithFailedOverriddenMatchModelDefinition { }
			[Fact]
			public void HardcodedNameWithFailedOverriddenMatch()
				=> typeof(TestOne)
					.Should()
					.HaveSameParentClassesAs(typeof(HardcodedNameWithFailedOverriddenMatchModelDefinition)).And
					.HaveSameNamespaceAs(typeof(HardcodedNameWithFailedOverriddenMatchModelDefinition));

			[GenerateModel(ModelName = "TestTwo")]
			public partial class HardcodedNameWithSuccessfulDefaultMatchModelDefinition { }
			[Fact]
			public void HardcodedNameWithSuccessfulDefaultMatch()
				=> typeof(TestTwo)
					.Should()
					.HaveSameParentClassesAs(typeof(HardcodedNameWithSuccessfulDefaultMatchModelDefinition)).And
					.HaveSameNamespaceAs(typeof(HardcodedNameWithSuccessfulDefaultMatchModelDefinition));

			[GenerateModel(ModelName = "Test${2}")]
			public partial class CustomModelNameFromDefaultMatchModelDefinition { }
			[Fact]
			public void CustomModelNameFromDefaultMatch()
				=> typeof(TestCustomModelNameFromDefaultMatchModel)
					.Should()
					.HaveSameParentClassesAs(typeof(CustomModelNameFromDefaultMatchModelDefinition)).And
					.HaveSameNamespaceAs(typeof(CustomModelNameFromDefaultMatchModelDefinition));

			[GenerateModel]
			public partial class DefaultModelNameFromDefaultMatchModelDefinition { }
			[Fact]
			public void DefaultModelNameFromDefaultMatch()
				=> typeof(DefaultModelNameFromDefaultMatchModel)
					.Should()
					.HaveSameParentClassesAs(typeof(DefaultModelNameFromDefaultMatchModelDefinition)).And
					.HaveSameNamespaceAs(typeof(DefaultModelNameFromDefaultMatchModelDefinition));

			[GenerateModel(ModelNameCaptureRegex = "(.*[\\.\\+])?([^\\.\\+]+)FromOverriddenMatchModelDefinition")]
			public partial class DefaultModelNameFromOverriddenMatchModelDefinition { }
			[Fact]
			public void DefaultModelNameFromOverriddenMatch()
				=> typeof(DefaultModelName)
					.Should()
					.HaveSameParentClassesAs(typeof(DefaultModelNameFromOverriddenMatchModelDefinition)).And
					.HaveSameNamespaceAs(typeof(DefaultModelNameFromOverriddenMatchModelDefinition));
		}

		public partial class ModelParentClasses
		{
			[GenerateModel(ModelParentClasses = "GeneratedTestClasses", ModelParentClassesCaptureRegex = "MatchThatFails")]
			public partial class HardcodedSingleParentClassesWithSuccessfulDefaultMatchModelDefinition { }
			[Fact]
			public void HardcodedSingleParentClassesWithSuccessfulDefaultMatch()
				=> typeof(GeneratedTestClasses.HardcodedSingleParentClassesWithSuccessfulDefaultMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(GeneratedTestClasses)).And
					.HaveSameNamespaceAs(typeof(HardcodedSingleParentClassesWithSuccessfulDefaultMatchModelDefinition));

			[GenerateModel(ModelParentClasses = "GeneratedTestClasses+TestOne", ModelParentClassesCaptureRegex = "MatchThatFails")]
			public partial class HardcodedParentClassesWithFailedOverriddenMatchModelDefinition { }
			[Fact]
			public void HardcodedParentClassesWithFailedOverriddenMatch()
				=> typeof(GeneratedTestClasses.TestOne.HardcodedParentClassesWithFailedOverriddenMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(GeneratedTestClasses), "TestOne").And
					.HaveSameNamespaceAs(typeof(HardcodedParentClassesWithFailedOverriddenMatchModelDefinition));

			[GenerateModel(ModelParentClasses = "GeneratedTestClasses+TestTwo")]
			public partial class HardcodedParentClassesWithSuccessfulDefaultMatchModelDefinition { }
			[Fact]
			public void HardcodedParentClassesWithSuccessfulDefaultMatch()
				=> typeof(GeneratedTestClasses.TestTwo.HardcodedParentClassesWithSuccessfulDefaultMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(GeneratedTestClasses), "TestTwo").And
					.HaveSameNamespaceAs(typeof(HardcodedParentClassesWithSuccessfulDefaultMatchModelDefinition));

			[GenerateModel(ModelParentClasses = "GeneratedTestClasses+${3}")]
			public partial class CustomModelParentClassesFromDefaultMatchModelDefinition { }
			[Fact]
			public void CustomModelParentClassesFromDefaultMatch()
				=> typeof(GeneratedTestClasses.GenerateModelAttributePathTests.ModelParentClasses.CustomModelParentClassesFromDefaultMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(GeneratedTestClasses), nameof(GenerateModelAttributePathTests), nameof(ModelParentClasses)).And
					.HaveSameNamespaceAs(typeof(CustomModelParentClassesFromDefaultMatchModelDefinition));

			[GenerateModel]
			public partial class DefaultModelParentClassesFromDefaultMatchModelDefinition { }
			[Fact]
			public void DefaultModelParentClassesFromDefaultMatch()
				=> typeof(DefaultModelParentClassesFromDefaultMatchModel)
					.Should()
					.HaveSameParentClassesAs(typeof(DefaultModelParentClassesFromDefaultMatchModelDefinition)).And
					.HaveSameNamespaceAs(typeof(DefaultModelParentClassesFromDefaultMatchModelDefinition));

			[GenerateModel(ModelParentClassesCaptureRegex = "(.+[\\.])?(([^\\.]+)\\+)?ModelParentClasses\\+[^\\+]+")]
			public partial class DefaultModelParentClassesFromOverriddenMatchModelDefinition { }
			[Fact]
			public void DefaultModelParentClassesFromOverriddenMatch()
				=> typeof(DefaultModelParentClassesFromOverriddenMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(GenerateModelAttributePathTests)).And
					.HaveSameNamespaceAs(typeof(DefaultModelParentClassesFromOverriddenMatchModelDefinition));
		}

		public partial class ModelNamespace
		{
			[GenerateModel(ModelNamespace = "Generated", ModelNamespaceCaptureRegex = "MatchThatFails")]
			public partial class HardcodedSingleNamespaceWithSuccessfulDefaultMatchModelDefinition { }
			[Fact]
			public void HardcodedSingleNamespaceWithSuccessfulDefaultMatch()
				=> typeof(Generated.GenerateModelAttributePathTests.ModelNamespace.HardcodedSingleNamespaceWithSuccessfulDefaultMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(GenerateModelAttributePathTests), nameof(ModelNamespace)).And
					.HaveNamespaceOf("Generated");

			[GenerateModel(ModelNamespace = "Generated.TestOne", ModelNamespaceCaptureRegex = "MatchThatFails")]
			public partial class HardcodedNamespaceWithFailedOverriddenMatchModelDefinition { }
			[Fact]
			public void HardcodedNamespaceWithFailedOverriddenMatch()
				=> typeof(Generated.TestOne.GenerateModelAttributePathTests.ModelNamespace.HardcodedNamespaceWithFailedOverriddenMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(GenerateModelAttributePathTests), nameof(ModelNamespace)).And
					.HaveNamespaceOf("Generated.TestOne");

			[GenerateModel(ModelNamespace = "Generated.TestTwo")]
			public partial class HardcodedNamespaceWithSuccessfulDefaultMatchModelDefinition { }
			[Fact]
			public void HardcodedNamespaceWithSuccessfulDefaultMatch()
				=> typeof(Generated.TestTwo.GenerateModelAttributePathTests.ModelNamespace.HardcodedNamespaceWithSuccessfulDefaultMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(GenerateModelAttributePathTests), nameof(ModelNamespace)).And
					.HaveNamespaceOf("Generated.TestTwo");

			[GenerateModel(ModelNamespace = "Generated.${2}")]
			public partial class CustomModelNamespaceFromDefaultMatchModelDefinition { }
			[Fact]
			public void CustomModelNamespaceFromDefaultMatch()
				=> typeof(Generated.Valigator.Models.Generator.Tests.GenerateModelAttributePathTests.ModelNamespace.CustomModelNamespaceFromDefaultMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(GenerateModelAttributePathTests), nameof(ModelNamespace)).And
					.HaveNamespaceOf("Generated.Valigator.Models.Generator.Tests");

			[GenerateModel]
			public partial class DefaultModelNamespaceFromDefaultMatchModelDefinition { }
			[Fact]
			public void DefaultModelNamespaceFromDefaultMatch()
				=> typeof(DefaultModelNamespaceFromDefaultMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(GenerateModelAttributePathTests), nameof(ModelNamespace)).And
					.HaveSameNamespaceAs(typeof(DefaultModelNamespaceFromDefaultMatchModelDefinition));

			[GenerateModel(ModelNamespaceCaptureRegex = "((.*)[\\.])?Tests\\.([^\\.]+)")]
			public partial class DefaultModelNamespaceFromOverriddenMatchModelDefinition { }
			[Fact]
			public void DefaultModelNamespaceFromOverriddenMatch()
				=> typeof(Generator.GenerateModelAttributePathTests.ModelNamespace.DefaultModelNamespaceFromOverriddenMatchModel)
					.Should()
					.HaveParentClassesOf(nameof(GenerateModelAttributePathTests), nameof(ModelNamespace)).And
					.HaveNamespaceOf("Valigator.Models.Generator");
		}
	}
}
