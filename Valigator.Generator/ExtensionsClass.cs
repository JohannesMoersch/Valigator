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
			var root = new ExtensionPathNode(Option.None<string>(), ValueValidators.Root, null);

			foreach (var path in Data.ValueValidationPaths)
				AddValidators(root, path);

			var extensions = GenerateExtensions(source, root).OrderBy(_ => _);

			return String.Join(Environment.NewLine, new[] { _header.Replace("__StateValidator__", source.GetSourceName(Option.None<string>())) }.Concat(extensions).Append(_footer));
		}

		private static void AddValidators(ExtensionPathNode current, IEnumerable<ValueValidators> validators)
		{
			if (!validators.Any())
				return;

			var validator = validators.First();
			foreach (var match in Data.Extensions.Where(e => e.Identifier == validator))
			{
				if (current.TryGetOrAddChild(match.DataType, validator, out var node))
					AddValidators(node, validators.Skip(1));
			}
		}

		private static IEnumerable<string> GenerateExtensions(SourceDefinition source, ExtensionPathNode extension)
		{
			var childExtensions = extension.Children.SelectMany(child => GenerateExtensions(source, child)).ToArray();

			if (extension.ValueValidator == ValueValidators.Root)
				return childExtensions;

			return GenerateExtension(source, extension, childExtensions.Any())
				.Concat(childExtensions);
		}

		private static IEnumerable<string> GenerateExtension(SourceDefinition source, ExtensionPathNode extension, bool hasChildren)
		{
			var extensions = new List<ValueValidators>();

			var current = extension;
			while (current.ValueValidator != ValueValidators.Root)
			{
				extensions.Insert(0, current.ValueValidator);
				current = current.Parent;
			}

			foreach (var set in GetExtensionDefinitions(extensions, extension.DataType))
			{
				switch (set.Length)
				{
					case 1:
						yield return ExtensionGenerator.GenerateExtensionOne(source, extension.DataType, set[0]);
						//if (hasChildren)
						//	yield return ExtensionGenerator.GenerateInvertExtensionTwo(source, set[0].DataType, set[0]);
						break;
					case 2:
						yield return ExtensionGenerator.GenerateExtensionTwo(source, extension.DataType, set[0], set[1]);
						//if (hasChildren)
						//	yield return ExtensionGenerator.GenerateInvertExtensionThree(source, set[1].DataType, set[0], set[1]);
						break;
					case 3:
						yield return ExtensionGenerator.GenerateExtensionThree(source, extension.DataType, set[0], set[1], set[2]);
						break;
					default:
						throw new Exception("Extensions of this length are not supported.");
				}
			}
		}
		private static IEnumerable<ExtensionDefinition[]> GetExtensionDefinitions(List<ValueValidators> valueValidators, Option<string> dataType)
			=>
			from one in Data.Extensions.Where(e => e.Identifier == valueValidators.Skip(0).FirstOrDefault() && e.DataType == dataType).Take(valueValidators.Count > 1 ? 1 : Int32.MaxValue)
			from two in Data.Extensions.Where(e => e.Identifier == valueValidators.Skip(1).FirstOrDefault()&& e.DataType == dataType).Take(valueValidators.Count > 2 ? 1 : Int32.MaxValue).DefaultIfEmpty()
			from three in Data.Extensions.Where(e => e.Identifier == valueValidators.Skip(2).FirstOrDefault()&& e.DataType == dataType).Take(valueValidators.Count > 3 ? 1 : Int32.MaxValue).DefaultIfEmpty()
			select new[] { one, two, three }.OfType<ExtensionDefinition>().ToArray();
	}
}
