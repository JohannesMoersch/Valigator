using System;
using System.Collections.Generic;

namespace Valigator.Core.ValueDescriptors
{
	public class MappingDescriptor : IValueDescriptor, IEquatable<MappingDescriptor>
	{
		public MappingDescriptor(Type fromType, Type toType)
		{
			FromType = fromType;
			ToType = toType;
		}

		public Type FromType { get; }

		public Type ToType { get; }

		public override bool Equals(object obj)
			=> Equals(obj as MappingDescriptor);

		public bool Equals(MappingDescriptor other)
			=> other != null && EqualityComparer<Type>.Default.Equals(FromType, other.FromType) && EqualityComparer<Type>.Default.Equals(ToType, other.ToType);
		
		public bool Equals(IValueDescriptor other)
			=> other is MappingDescriptor mappingDescriptor && Equals(mappingDescriptor);

		public override int GetHashCode()
		{
			var hashCode = 1267219665;
			hashCode = hashCode * -1521134295 + EqualityComparer<Type>.Default.GetHashCode(FromType);
			hashCode = hashCode * -1521134295 + EqualityComparer<Type>.Default.GetHashCode(ToType);
			return hashCode;
		}
	}
}
