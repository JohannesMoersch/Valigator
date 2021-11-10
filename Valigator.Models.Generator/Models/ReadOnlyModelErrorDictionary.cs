using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Models
{
	public struct ReadOnlyModelErrorDictionary : IReadOnlyDictionary<string, ValidationError[]>
	{
		private IReadOnlyDictionary<string, ValidationError[]>? _errors;

		public ValidationError[] this[string key] => _errors?[key] ?? throw new KeyNotFoundException();

		public int Count => _errors?.Count ?? 0;

		public IEnumerable<string> Keys => _errors?.Keys ?? Enumerable.Empty<string>();

		public IEnumerable<ValidationError[]> Values => _errors?.Values ?? Enumerable.Empty<ValidationError[]>();

		internal ReadOnlyModelErrorDictionary(IReadOnlyDictionary<string, ValidationError[]>? errors)
			=> _errors = errors;

		public bool ContainsKey(string key)
			=> _errors?.ContainsKey(key) ?? false;

		public bool TryGetValue(string key, [MaybeNullWhen(false)] out ValidationError[] value)
		{
			if (_errors == null)
			{
				value = null;
				return false;
			}

			return _errors.TryGetValue(key, out value);
		}

		public ModelErrorDictionary Clone()
			=> new ModelErrorDictionary(_errors);

		public IEnumerator<KeyValuePair<string, ValidationError[]>> GetEnumerator()
			=> _errors?.GetEnumerator() ?? Enumerable.Empty<KeyValuePair<string, ValidationError[]>>().GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
			=> GetEnumerator();
	}
}
