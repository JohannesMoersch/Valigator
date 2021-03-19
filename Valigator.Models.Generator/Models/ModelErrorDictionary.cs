using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Models
{
	public struct ModelErrorDictionary : IReadOnlyDictionary<string, ValidationError[]>
	{
		private Dictionary<string, ValidationError[]>? _errors;

		public ValidationError[] this[string key] 
		{
			get => _errors?[key] ?? throw new KeyNotFoundException();
			set
			{
				if (value == null)
					throw new ArgumentNullException(nameof(value));

				if (_errors == null)
					_errors = new Dictionary<string, ValidationError[]>();

				_errors[key] = value;
			}
		}

		public int Count => _errors?.Count ?? 0;

		public IEnumerable<string> Keys => _errors?.Keys ?? Enumerable.Empty<string>();

		public IEnumerable<ValidationError[]> Values => _errors?.Values ?? Enumerable.Empty<ValidationError[]>();

		public bool ContainsKey(string key)
			=> _errors?.ContainsKey(key) ?? false;

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		public bool TryGetValue(string key, out ValidationError[] value)
		{
			if (_errors == null)
			{
				value = null;
				return false;
			}

			return _errors.TryGetValue(key, out value);
		}
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

		public void Add(string key, ValidationError[] value)
		{
			if (value == null)
				throw new ArgumentNullException(nameof(value));

			if (_errors == null)
				_errors = new Dictionary<string, ValidationError[]>();

			_errors.Add(key, value);
		}

		public bool Remove(string key)
		{
			if (_errors == null)
				return false;

			if (_errors.Remove(key))
			{
				if (_errors.Count == 0)
					_errors = null;

				return true;
			}

			return false;
		}

		public void Clear()
			=> _errors = null;

		public IEnumerator<KeyValuePair<string, ValidationError[]>> GetEnumerator()
			=> _errors?.GetEnumerator() ?? Enumerable.Empty<KeyValuePair<string, ValidationError[]>>().GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
			=> GetEnumerator();
	}
}
