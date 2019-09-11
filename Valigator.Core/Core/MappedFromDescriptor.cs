using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Core
{
	public class MappedFromDescriptor : IEquatable<MappedFromDescriptor>
	{
		public Type SourceType { get; }

		public IReadOnlyList<IValueDescriptor> SourceValueDescriptors { get; }

		public MappedFromDescriptor(Type sourceType, IReadOnlyList<IValueDescriptor> sourceValueDescriptors)
		{
			SourceType = sourceType ?? throw new ArgumentNullException(nameof(sourceType));
			SourceValueDescriptors = sourceValueDescriptors ?? throw new ArgumentNullException(nameof(sourceValueDescriptors));
		}

		public override bool Equals(object obj) 
			=> Equals(obj as MappedFromDescriptor);

		public bool Equals(MappedFromDescriptor other) 
			=> other != null && EqualityComparer<Type>.Default.Equals(SourceType, other.SourceType) && SourceValueDescriptors.SequenceEqual(other.SourceValueDescriptors);

		public override int GetHashCode()
		{
			var hashCode = 1778391349;
			hashCode = hashCode * -1521134295 + EqualityComparer<Type>.Default.GetHashCode(SourceType);

			for (int i = 0; i < SourceValueDescriptors.Count; ++i)
				hashCode = hashCode * -1521134295 + EqualityComparer<IValueDescriptor>.Default.GetHashCode(SourceValueDescriptors[i]);

			return hashCode;
		}
	}
}
