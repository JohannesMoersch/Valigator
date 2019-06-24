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
	{
";

		private static readonly string _footer =
@"
	}
}";

		public static string Generate(SourceDefinition source)
		{
			IEnumerable<ValidatorGroups[]> paths;
			switch (source.ValueType)
			{
				case ValueType.Value:
					paths = Data.ValueValidationPaths;
					break;
				case ValueType.Array:
					paths = Data.ArrayValidationPaths;
					break;
				default:
					return String.Empty;
			}

			var root = new ExtensionPathNode(null, null);

			foreach (var path in paths)
				AddValidators(root, path);

			var extensions = ExtensionGenerator.GenerateMapExtension(source)
				.Concat(ExtensionGenerator.GenerateInvertExtensionOne(source))
				.Concat(GenerateExtensions(source, root));

			var header = _header.Replace("__StateValidator__", source.GetSourceName(Option.None<string>()));

			return $"{header}{String.Join($"{Environment.NewLine}{Environment.NewLine}", extensions)}{_footer}";
		}

		private static void AddValidators(ExtensionPathNode current, IEnumerable<ValidatorGroups> validators)
		{
			if (!validators.Any())
				return;

			var validator = validators.First();
			foreach (var extension in Data.Extensions.Where(e => e.Validator.Identifier == validator))
			{
				if (current.TryGetOrAddChild(extension, out var node))
					AddValidators(node, validators.Skip(1));
			}
		}

		private static IEnumerable<string> GenerateExtensions(SourceDefinition source, ExtensionPathNode node)
			=> GenerateExtension(source, node)
				.Concat(node.Children.SelectMany(child => GenerateExtensions(source, child)));

		private static IEnumerable<string> GenerateExtension(SourceDefinition source, ExtensionPathNode node)
		{
			if (!node.Extensions.Any())
				return Enumerable.Empty<string>();

			var nodes = new List<ExtensionPathNode>();

			var current = node;
			while (current != null)
			{
				nodes.Insert(0, current);
				current = current.Parent;
			}

			switch (nodes.Count)
			{
				case 1:
					return nodes[0]
						.Extensions
						.SelectMany(extension => ExtensionGenerator.GenerateExtensionOne(source, node.DataType.Match(Option.Some, () => extension.DataType), extension));
				case 2:
					return nodes[1]
						.Extensions
						.SelectMany(extension => ExtensionGenerator.GenerateExtensionTwo(source, node.DataType.Match(Option.Some, () => extension.DataType), nodes[1].Validator, extension))
						.Concat(ExtensionGenerator.GenerateInvertExtensionTwo(source, node.DataType, nodes[1].Validator));
				case 3:
					return nodes[2]
						.Extensions
						.SelectMany(extension => ExtensionGenerator.GenerateExtensionThree(source, node.DataType.Match(Option.Some, () => extension.DataType), nodes[1].Validator, nodes[2].Validator, extension))
						.Concat(ExtensionGenerator.GenerateInvertExtensionThree(source, node.DataType, nodes[1].Validator, nodes[2].Validator));
				default:
					throw new Exception("Extensions of this length are not supported.");
			}
		}
	}
}
