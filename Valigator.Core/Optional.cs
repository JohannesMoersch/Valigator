using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	public struct Optional<TValue> : IEquatable<Optional<TValue>>
	{
		private readonly bool _hasValue;

		private readonly TValue _value;

		internal Optional(bool hasValue, TValue value)
		{
			_hasValue = hasValue;

			_value = value;
		}

		public TResult Match<TResult>(Func<TValue, TResult> some, Func<TResult> none)
		{
			if (some == null)
				throw new ArgumentNullException(nameof(some));

			if (none == null)
				throw new ArgumentNullException(nameof(none));

			return _hasValue ? some.Invoke(_value) : none.Invoke();
		}

		public bool Equals(Optional<TValue> other)
			=> _hasValue == other._hasValue && (!_hasValue || EqualityComparer<TValue>.Default.Equals(_value, other._value));

		public override int GetHashCode()
			=> _hasValue ? _value.GetHashCode() * 31 : 0;

		public override bool Equals(object obj)
			=> obj is Optional<TValue> option && Equals(option);

		public override string ToString()
			=> _hasValue ? $"Some:{_value}" : "None";

		public static bool operator ==(Optional<TValue> left, Optional<TValue> right)
			=> left.Equals(right);

		public static bool operator !=(Optional<TValue> left, Optional<TValue> right)
			=> !left.Equals(right);
	}

	public static class Optional
	{
		public static Optional<T> Some<T>(T value)
		{
			if (value == null)
				throw new ArgumentNullException(nameof(value));

			return new Optional<T>(true, value);
		}

		public static Optional<T> None<T>()
			=> new Optional<T>(false, default);

		public static Optional<T> Create<T>(bool isSome, T value)
			=> isSome
				? Some(value)
				: None<T>();
	}
}
