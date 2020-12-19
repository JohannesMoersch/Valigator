using Functional;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models
{
	internal class OptionDictionaryWrapper<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
	{
		private readonly IReadOnlyDictionary<TKey, Option<TValue>> _values;

		public int Count => _values.Count;

		public IEnumerable<TKey> Keys => _values.Keys;

		public IEnumerable<TValue> Values => _values.Values.Select(v => v.Match(static o => o, static () => throw new Exception("Cannot access value containing None.")));

		public TValue this[TKey key] => _values[key].Match(static o => o, static () => throw new Exception("Cannot access value containing None."));

		public OptionDictionaryWrapper(IReadOnlyDictionary<TKey, Option<TValue>> values) 
			=> _values = values;

		public bool ContainsKey(TKey key)
			=> _values.ContainsKey(key);

#pragma warning disable CS8601 // Possible null reference assignment.
		public bool TryGetValue(TKey key, out TValue value)
		{
			if (_values.TryGetValue(key, out var item))
			{
				value = item.Match(static o => o, static () => throw new Exception("Cannot access value containing None."));
				return true;
			}

			value = default;
			return false;
		}
#pragma warning restore CS8601 // Possible null reference assignment.

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			foreach (var kvp in _values)
				yield return new KeyValuePair<TKey, TValue>(kvp.Key, kvp.Value.Match(static o => o, static () => throw new Exception("Cannot access value containing None.")));
		}

		IEnumerator IEnumerable.GetEnumerator()
			=> GetEnumerator();
	}
}
