using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.ValueDescriptors
{
	public class ItemCountDescriptor : IValueDescriptor, IEquatable<ItemCountDescriptor>
	{
		public Option<int> MinimumItems { get; }

		public Option<int> MaximumItems { get; }

		public ItemCountDescriptor(Option<int> minimumItems, Option<int> maximumItems)
		{
			MinimumItems = minimumItems;
			MaximumItems = maximumItems;
		}

		public override bool Equals(object obj)
			=> Equals(obj as ItemCountDescriptor);

		public bool Equals(ItemCountDescriptor other)
			=> other != null && MinimumItems.Equals(other.MinimumItems) && MaximumItems.Equals(other.MaximumItems);

		public bool Equals(IValueDescriptor other)
			=> other is ItemCountDescriptor itemCountDescriptor && Equals(itemCountDescriptor);

		public override int GetHashCode()
		{
			var hashCode = -1002496056;
			hashCode = hashCode * -1521134295 + EqualityComparer<Option<int>>.Default.GetHashCode(MinimumItems);
			hashCode = hashCode * -1521134295 + EqualityComparer<Option<int>>.Default.GetHashCode(MaximumItems);
			return hashCode;
		}
	}
}
