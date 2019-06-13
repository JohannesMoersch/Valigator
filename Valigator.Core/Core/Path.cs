using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Core
{
	public class Path
	{
		private readonly string _property;

		private readonly int? _index;

		private Path _parent;

		private Path Root => _parent?.Root ?? this;

		internal Path()
		{
		}

		internal Path(string property) 
			=> _property = property;

		internal Path(int index) 
			=> _index = index;

		public Path AddProperty(string property)
			=> Root._parent = new Path(property);

		public Path AddIndex(int index)
			=> Root._parent = new Path(index);

		public override string ToString()
			=> String
				.Join
				(
					".",
					GetPathParts()
						.Reverse()
						.Select(p => p._property ?? $"[{p._index ?? 0}]")
				)
				.Replace(".[", "[");

		private IEnumerable<Path> GetPathParts()
		{
			var current = this;
			while (current != null)
			{
				if (current._property != null || current._index != null)
					yield return current;
				current = current._parent;
			}
		}
	}
}
