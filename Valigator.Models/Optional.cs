using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models
{
	public struct Optional<TValue> : IEquatable<Optional<TValue>>
	{
		private readonly TValue? _value;

		internal Optional(TValue? value) 
			=> _value = value;

		public TResult Match<TResult>(Func<TValue, TResult> set, Func<TResult> unset)
		{
			if (set == null)
				throw new ArgumentNullException(nameof(set));

			if (unset == null)
				throw new ArgumentNullException(nameof(unset));

			return _value is not null ? set.Invoke(_value) : unset.Invoke();
		}	

		public TValue? ToNullable()
			=> _value;

		public bool Equals(Optional<TValue> other)
			=> EqualityComparer<TValue?>.Default.Equals(_value, other._value);

		public override int GetHashCode()
			=> _value is not null ? _value.GetHashCode() * 31 : 0;

		public override bool Equals(object obj)
			=> obj is Optional<TValue> Nullable && Equals(Nullable);

		public override string ToString()
			=> _value is not null ? $"Set:{_value}" : "Unset";

		public static bool operator ==(Optional<TValue> left, Optional<TValue> right)
			=> left.Equals(right);

		public static bool operator !=(Optional<TValue> left, Optional<TValue> right)
			=> !left.Equals(right);
	}
}
