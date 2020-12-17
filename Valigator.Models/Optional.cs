using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models
{
	public static class Optional
	{
		public static Optional<TValue> Set<TValue>(TValue value)
			=> new Optional<TValue>(value);

		public static Optional<TValue> Unset<TValue>()
			=> new Optional<TValue>();
	}

	public struct Optional<TValue> : IEquatable<Optional<TValue>>
	{
		private readonly bool _hasValue;

		private readonly TValue _value;

		internal Optional(TValue value)
		{
			_hasValue = true;
			_value = value;
		}

		public TResult Match<TResult>(Func<TValue, TResult> set, Func<TResult> unset)
		{
			if (set == null)
				throw new ArgumentNullException(nameof(set));

			if (unset == null)
				throw new ArgumentNullException(nameof(unset));

			return _hasValue ? set.Invoke(_value) : unset.Invoke();
		}	

		public bool Equals(Optional<TValue> other)
			=> EqualityComparer<TValue?>.Default.Equals(_value, other._value);

		public override int GetHashCode()
			=> _hasValue && _value != null ? _value.GetHashCode() * 31 : 0;

		public override bool Equals(object obj)
			=> obj is Optional<TValue> Nullable && Equals(Nullable);

		public override string ToString()
			=> _hasValue ? $"Set:{_value}" : "Unset";

		public static bool operator ==(Optional<TValue> left, Optional<TValue> right)
			=> left.Equals(right);

		public static bool operator !=(Optional<TValue> left, Optional<TValue> right)
			=> !left.Equals(right);
	}
}
