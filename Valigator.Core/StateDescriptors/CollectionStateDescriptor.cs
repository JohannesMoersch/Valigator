using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.StateDescriptors
{
	public class CollectionStateDescriptor : IStateDescriptor, IEquatable<CollectionStateDescriptor>
	{
		public Option<object[]> DefaultValue { get; }

		public DataDescriptor ItemDescriptor { get; }

		public CollectionStateDescriptor(Option<object[]> defaultValue, DataDescriptor itemDescriptor)
		{
			DefaultValue = defaultValue;
			ItemDescriptor = itemDescriptor;
		}

		public override bool Equals(object obj) 
			=> Equals(obj as CollectionStateDescriptor);

		public bool Equals(IStateDescriptor other)
			=> Equals(other as CollectionStateDescriptor);

		public bool Equals(CollectionStateDescriptor other) 
			=> other != null && DefaultValue.Equals(other.DefaultValue) && ItemDescriptor.Equals(other.ItemDescriptor);

		public override int GetHashCode()
		{
			var hashCode = 1089678594;
			hashCode = hashCode * -1521134295 + EqualityComparer<Option<object[]>>.Default.GetHashCode(DefaultValue);
			hashCode = hashCode * -1521134295 + EqualityComparer<DataDescriptor>.Default.GetHashCode(ItemDescriptor);
			return hashCode;
		}
	}
}
