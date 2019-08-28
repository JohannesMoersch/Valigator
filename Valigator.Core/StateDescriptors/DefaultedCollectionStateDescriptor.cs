using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.StateDescriptors
{
	public class DefaultedCollectionStateDescriptor : IStateDescriptor, IEquatable<DefaultedCollectionStateDescriptor>
	{
		public bool Nullable { get; }

		public bool ItemsNullable { get; }

		public object DefaultValue { get; }

		public DataDescriptor ItemDescriptor { get; }

		public DefaultedCollectionStateDescriptor(bool nullable, bool itemsNullable, object defaultValue, DataDescriptor itemDescriptor)
		{
			Nullable = nullable;
			ItemsNullable = itemsNullable;
			DefaultValue = defaultValue;
			ItemDescriptor = itemDescriptor;
		}

		public override bool Equals(object obj) 
			=> Equals(obj as DefaultedCollectionStateDescriptor);

		public bool Equals(DefaultedCollectionStateDescriptor other) 
			=> other != null && Nullable == other.Nullable && EqualityComparer<object>.Default.Equals(DefaultValue, other.DefaultValue) && ItemDescriptor.Equals(other.ItemDescriptor);

		public bool Equals(IStateDescriptor other)
			=> other is DefaultedCollectionStateDescriptor defaultedCollectionStateDescriptor && Equals(defaultedCollectionStateDescriptor);

		public override int GetHashCode()
		{
			var hashCode = 2064393502;
			hashCode = hashCode * -1521134295 + Nullable.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(DefaultValue);
			hashCode = hashCode * -1521134295 + EqualityComparer<DataDescriptor>.Default.GetHashCode(ItemDescriptor);
			return hashCode;
		}
	}
}
