using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;

namespace Valigator.Generator
{
	public static class ExtensionsClass
	{
		private static readonly string _header =
@"using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class __StateValidator__Extensions
	{";

		private static readonly string _footer =
@"	}
}";

		public static string Generate(SourceDefinition source)
		{
			var root = new ExtensionPathNode(ValueValidators.Root, null);

			foreach (var path in Data.ValueValidationPaths)
			{
				var current = root;
				foreach (var validator in path)
					current = current.GetOrAddChild(validator);
			}

			var extensions = GenerateExtensions(source, root);

			return String.Join(Environment.NewLine, new[] { _header.Replace("__StateValidator__", source.GetSourceName(Option.None<string>())) }.Concat(extensions).Append(_footer));
		}

		private static IEnumerable<string> GenerateExtensions(SourceDefinition source, ExtensionPathNode extension)
			=> (extension.ValueValidator == ValueValidators.Root ? Array.Empty<string>() : GenerateExtension(source, extension))
				.Concat(extension.Children.SelectMany(child => GenerateExtensions(source, child)));

		private static IEnumerable<string> GenerateExtension(SourceDefinition source, ExtensionPathNode extension)
		{
			var extensions = new List<ValueValidators>();

			var current = extension;
			while (current.ValueValidator != ValueValidators.Root)
			{
				extensions.Insert(0, current.ValueValidator);
				current = current.Parent;
			}

			foreach (var set in GetExtensionDefinitions(extensions))
			{
				switch (set.Length)
				{
					case 1:
						yield return ExtensionGenerator.GenerateExtensionOne(source, set[0]);
						break;
					case 2:
						var resultTwo = ExtensionGenerator.GenerateExtensionTwo(source, set[0], set[1]);
						if (resultTwo.HasValue())
							yield return resultTwo.ValueOrDefault();
						break;
					case 3:
						var resultThree = ExtensionGenerator.GenerateExtensionThree(source, set[0], set[1], set[2]);
						if (resultThree.HasValue())
							yield return resultThree.ValueOrDefault();
						break;
					default:
						throw new Exception("Extensions of this length are not supported.");
				}
			}
		}
		private static IEnumerable<ExtensionDefinition[]> GetExtensionDefinitions(List<ValueValidators> valueValidators)
			=>
			(
				from one in Data.Extensions.Where(e => e.Identifier == valueValidators.Skip(0).FirstOrDefault())
				from two in Data.Extensions.Where(e => e.Identifier == valueValidators.Skip(1).FirstOrDefault()).DefaultIfEmpty()
				from three in Data.Extensions.Where(e => e.Identifier == valueValidators.Skip(2).FirstOrDefault()).DefaultIfEmpty()
				select (one, two, three)
			)
			.Distinct()
			.Select(set => new[] { set.one, set.two, set.three }.OfType<ExtensionDefinition>().ToArray());
	}
}
