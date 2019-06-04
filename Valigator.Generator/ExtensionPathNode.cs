using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Generator
{
	public class ExtensionPathNode
	{
		public ValueValidators ValueValidator { get; }

		private SortedList<ValueValidators, ExtensionPathNode> _children = new SortedList<ValueValidators, ExtensionPathNode>();
		public IEnumerable<ExtensionPathNode> Children => _children.Values;

		public ExtensionPathNode Parent { get; }

		public ExtensionPathNode(ValueValidators valueValidator, ExtensionPathNode parent)
		{
			ValueValidator = valueValidator;
			Parent = parent;
		}

		public ExtensionPathNode GetOrAddChild(ValueValidators valueValidator)
		{
			if (!_children.TryGetValue(valueValidator, out var validator))
			{
				validator = new ExtensionPathNode(valueValidator, this);

				_children.Add(validator.ValueValidator, validator);
			}

			return validator;
		}
	}
}
