using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public struct Nullable<TValue> : IEquatable<Nullable<TValue>>
	{
		private readonly TValue? _value;

		internal Nullable(TValue? value) 
			=> _value = value;

		public TResult Match<TResult>(Func<TValue, TResult> some, Func<TResult> none)
		{
			if (some == null)
				throw new ArgumentNullException(nameof(some));

			if (none == null)
				throw new ArgumentNullException(nameof(none));

			return _value is not null ? some.Invoke(_value) : none.Invoke();
		}

		public bool Equals(Nullable<TValue> other)
			=> EqualityComparer<TValue?>.Default.Equals(_value, other._value);

		public override int GetHashCode()
			=> _value is not null ? _value.GetHashCode() * 31 : 0;

		public override bool Equals(object obj)
			=> obj is Nullable<TValue> Nullable && Equals(Nullable);

		public override string ToString()
			=> _value is not null ? $"Some:{_value}" : "None";

		public static bool operator ==(Nullable<TValue> left, Nullable<TValue> right)
			=> left.Equals(right);

		public static bool operator !=(Nullable<TValue> left, Nullable<TValue> right)
			=> !left.Equals(right);
	}
}
