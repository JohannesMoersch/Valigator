using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valigator.AspNetCore.TestAPI.Controllers
{
	[GenerateModel(Type = ModelType.Struct)]
	public partial class TestModelDefinition
	{
		public Property<int> Required => Data.Value<int>().Required();

		public Property<Option<int>> RequiredNullable => Data.Value<int>(o => o.Nullable()).Required();

		public Property<Optional<int>> SetOptional => Data.Value<int>().Optional();

		public Property<Optional<Option<int>>> SetOptionalNullable => Data.Value<int>(o => o.Nullable()).Optional();

		public Property<Optional<int>> UnsetOptional => Data.Value<int>().Optional();

		public Property<Optional<Option<int>>> UnsetOptionalNullable => Data.Value<int>(o => o.Nullable()).Optional();

		public Property<int> Defaulted => Data.Value<int>().Defaulted(5);

		public Property<Option<int>> DefaultedNullable => Data.Value<int>(o => o.Nullable()).Defaulted(Option.Some(5));
	}
}
