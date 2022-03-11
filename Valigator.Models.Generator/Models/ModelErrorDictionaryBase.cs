using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Models
{
	public class ModelErrorDictionaryBase : IReadOnlyModelErrorDictionary
	{
		public static IReadOnlyModelErrorDictionary? Uncoerced { get; } = null;

		public static IReadOnlyModelErrorDictionary? Unvalidated { get; } = new ModelErrorDictionaryBase(null);

		public static IReadOnlyModelErrorDictionary? Valid { get; } = new ModelErrorDictionaryBase(null);

		protected Dictionary<string, ValidationError[]>? _errors;

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

		public ModelErrorDictionaryBase() { }

		public ModelErrorDictionaryBase(IReadOnlyDictionary<string, ValidationError[]>? errors)
			=> _errors = errors != null
				? new Dictionary<string, ValidationError[]>(errors)
				: null;

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
