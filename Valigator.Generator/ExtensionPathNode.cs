using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;

namespace Valigator.Generator
{
	public class ExtensionPathNode
	{
		private class NodeComparer : IComparer<(Option<string> dataType, ValueValidators valueValidator)>
		{
			public int Compare((Option<string> dataType, ValueValidators valueValidator) x, (Option<string> dataType, ValueValidators valueValidator) y)
			{
				var typeComparison = x.dataType.Match(xType => y.dataType.Match(yType => xType.CompareTo(yType), () => 1), () => y.dataType.Match(_ => -1, () => 0));

				if (typeComparison == 0)
					return x.valueValidator.CompareTo(y.valueValidator);

				return typeComparison;
			}
		}

		public ValueValidators ValueValidator { get; }

		public Option<string> DataType { get; }

		private SortedList<(Option<string> dataType, ValueValidators valueValidator), ExtensionPathNode> _children = new SortedList<(Option<string>, ValueValidators), ExtensionPathNode>(new NodeComparer());
		public IEnumerable<ExtensionPathNode> Children => _children.Values;

		public ExtensionPathNode Parent { get; }

		public ExtensionPathNode(Option<string> dataType, ValueValidators valueValidator, ExtensionPathNode parent)
		{
			DataType = dataType;
			ValueValidator = valueValidator;
			Parent = parent;
		}

		public bool TryGetOrAddChild(Option<string> dataType, ValueValidators valueValidator, out ExtensionPathNode node)
		{
			if (!DataType.Match(value => dataType.Match(newValue => newValue == value, () => true), () => true))
			{
				node = null;
				return false;
			}

			if (!_children.TryGetValue((dataType, valueValidator), out var validator))
			{
				validator = new ExtensionPathNode(dataType, valueValidator, this);

				_children.Add((dataType, valueValidator), validator);
			}

			node = validator;
			return true;
		}

		public override string ToString()
			=> $"{ValueValidator}<{DataType}>";
	}
}
