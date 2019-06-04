using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.StateValidators;

namespace Valigator.Generator
{
	public static class Constants
	{
		public static string ValueReplacementString { get; } = "__TValue__";

		public static SourceDefinition[] Sources =>
			new[]
			{
				SourceDefinition.Create(typeof(DefaultedCollectionNullableStateValidator<>)),
				SourceDefinition.Create(typeof(DefaultedCollectionStateValidator<>)),
				SourceDefinition.Create(typeof(OptionalCollectionNullableStateValidator<>)),
				SourceDefinition.Create(typeof(OptionalCollectionStateValidator<>)),
				SourceDefinition.Create(typeof(RequiredCollectionNullableStateValidator<>)),
				SourceDefinition.Create(typeof(RequiredCollectionStateValidator<>)),
				SourceDefinition.Create(typeof(DefaultedNullableStateValidator<>)),
				SourceDefinition.Create(typeof(DefaultedStateValidator<>)),
				SourceDefinition.Create(typeof(OptionalNullableStateValidator<>)),
				SourceDefinition.Create(typeof(OptionalStateValidator<>)),
				SourceDefinition.Create(typeof(RequiredNullableStateValidator<>)),
				SourceDefinition.Create(typeof(RequiredStateValidator<>))
			};
	}
}
