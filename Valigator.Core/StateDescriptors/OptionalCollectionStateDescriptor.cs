using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.StateDescriptors
{
	public class OptionalCollectionStateDescriptor : IStateDescriptor, IEquatable<OptionalCollectionStateDescriptor>
	{
		public bool Nullable { get; }

		public bool ItemsNullable { get; }

		public DataDescriptor ItemDescriptor { get; }

		public OptionalCollectionStateDescriptor(bool nullable, bool itemsNullable, DataDescriptor itemDescriptor)
		{
			Nullable = nullable;
			ItemsNullable = itemsNullable;
			ItemDescriptor = itemDescriptor;
		}

		public override bool Equals(object obj) 
			=> Equals(obj as OptionalCollectionStateDescriptor);

		public bool Equals(OptionalCollectionStateDescriptor other) 
			=> other != null && Nullable == other.Nullable && ItemDescriptor.Equals(other.ItemDescriptor);

		public bool Equals(IStateDescriptor other)
			=> other is OptionalCollectionStateDescriptor optionalCollectionStateDescriptor && Equals(optionalCollectionStateDescriptor);

		public override int GetHashCode()
		{
			var hashCode = -482873273;
			hashCode = hashCode * -1521134295 + Nullable.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<DataDescriptor>.Default.GetHashCode(ItemDescriptor);
			return hashCode;
		}
	}
}
