using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;

namespace Valigator
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class CollectionFactoryExtensions
	{
		public static DefaultedCollectionStateValidator<TValue> DefaultedToEmpty<TValue>(this CollectionFactory<TValue> factory)
			=> factory.Defaulted(Array.Empty<TValue>());
	}
}
