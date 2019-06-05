using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;

namespace Valigator.Generator
{
	public class ExtensionPathNode
	{
		public ValidatorDefinition Validator { get; }


		private Dictionary<ValidatorDefinition, ExtensionPathNode> _children = new Dictionary<ValidatorDefinition, ExtensionPathNode>();
		public IEnumerable<ExtensionPathNode> Children => _children.Values;

		private HashSet<ExtensionDefinition> _extensions = new HashSet<ExtensionDefinition>();
		public IEnumerable<ExtensionDefinition> Extensions => _extensions;

		public ExtensionPathNode Parent { get; }

		public Option<string> DataType => Validator?.DataType.Match(Option.Some, () => Parent?.DataType ?? default) ?? default;

		public ExtensionPathNode(ValidatorDefinition validator, ExtensionPathNode parent)
		{
			Validator = validator;
			Parent = parent;
		}

		public bool TryGetOrAddChild(ExtensionDefinition extension, out ExtensionPathNode node)
		{
			if (!DataType.Match(value => extension.DataType.Match(newValue => newValue == value, () => true), () => true))
			{
				node = null;
				return false;
			}

			_extensions.Add(extension);

			if (!_children.TryGetValue(extension.Validator, out var child))
			{
				child = new ExtensionPathNode(extension.Validator, this);

				_children.Add(extension.Validator, child);
			}

			node = child;
			return true;
		}

		public override string ToString()
			=> $"{Validator.Identifier}{DataType.Match(type => $"<{type}>", () => String.Empty)}";
	}
}
