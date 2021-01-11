using Functional;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	internal class OptionListWrapper<TValue> : IReadOnlyList<TValue>
	{
		private readonly IReadOnlyList<Option<TValue>> _values;

		public int Count => _values.Count;

		public TValue this[int index] => _values[index].Match(static o => o, static () => throw new Exception("Cannot access value containing None."));

		public OptionListWrapper(IReadOnlyList<Option<TValue>> values) 
			=> _values = values;

		public IEnumerator<TValue> GetEnumerator()
		{
			for (int i = 0; i < _values.Count; ++i)
				yield return this[i];
		}

		IEnumerator IEnumerable.GetEnumerator()
			=> GetEnumerator();
	}
}
