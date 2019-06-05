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
			var root = new ExtensionPathNode(null, null);

			foreach (var path in Data.ValueValidationPaths)
				AddValidators(root, path);

			var extensions = GenerateExtensions(source, root).OrderBy(_ => _);

			return String.Join(Environment.NewLine, new[] { _header.Replace("__StateValidator__", source.GetSourceName(Option.None<string>())) }.Concat(extensions).Append(_footer));
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
				yield break;

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
					foreach (var extension in nodes[0].Extensions)
						yield return ExtensionGenerator.GenerateExtensionOne(source, node.DataType.Match(Option.Some, () => extension.DataType), extension);
					//if (hasChildren)
					//	yield return ExtensionGenerator.GenerateInvertExtensionTwo(source, set[0].DataType, set[0]);
					break;
				case 2:
					foreach (var extension in nodes[1].Extensions)
						yield return ExtensionGenerator.GenerateExtensionTwo(source, node.DataType.Match(Option.Some, () => extension.DataType), nodes[1].Validator, extension);
					//if (hasChildren)
					//	yield return ExtensionGenerator.GenerateInvertExtensionThree(source, set[1].DataType, set[0], set[1]);
					break;
				case 3:
					foreach (var extension in nodes[2].Extensions)
						yield return ExtensionGenerator.GenerateExtensionThree(source, node.DataType.Match(Option.Some, () => extension.DataType), nodes[1].Validator, nodes[2].Validator, extension);
					break;
				default:
					throw new Exception("Extensions of this length are not supported.");
			}
		}
	}
}
