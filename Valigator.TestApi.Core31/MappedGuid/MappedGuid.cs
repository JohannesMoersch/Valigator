using System;
using Functional;

namespace Valigator.TestApi.Core31.MappedGuid
{
	public readonly struct MappedGuid : IEquatable<MappedGuid>
	{
		private readonly Option<Guid> _value;
		internal readonly Guid Value => _value.BindIfNone(() => throw new Exception()).ValueOrDefault();

		internal MappedGuid(Guid value)
			=> _value = Option.Some(value);

		public override readonly bool Equals(object obj)
			=> obj is MappedGuid mappedGuid && Equals(mappedGuid);

		public readonly bool Equals(MappedGuid other)
			=> _value == other._value;

		public override readonly int GetHashCode()
			=> _value.GetHashCode();

		public static bool operator ==(MappedGuid identifier1, MappedGuid identifier2)
			=> identifier1.Equals(identifier2);

		public static bool operator !=(MappedGuid identifier1, MappedGuid identifier2)
			=> !(identifier1 == identifier2);

		public override readonly string ToString()
			=> $"{Value}";
	}
}
