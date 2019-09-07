using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.StateValidators;

namespace Valigator.Core
{
	public struct CollectionFactory<TValue>
	{
		private readonly Data<TValue> _item;

		public CollectionFactory(Data<TValue> item) 
			=> _item = item;

		public RequiredCollectionStateValidator<TValue> Required()
			=> new RequiredCollectionStateValidator<TValue>(_item);

		public OptionalCollectionStateValidator<TValue> Optional()
			=> new OptionalCollectionStateValidator<TValue>(_item);

		public DefaultedCollectionStateValidator<TValue> Defaulted()
			=> new DefaultedCollectionStateValidator<TValue>(_item, Array.Empty<TValue>());

		public DefaultedCollectionStateValidator<TValue> Defaulted(TValue[] defaultValue)
			=> new DefaultedCollectionStateValidator<TValue>(_item, defaultValue);

		public DefaultedCollectionStateValidator<TValue> Defaulted(Func<TValue[]> defaultValueFactory)
			=> new DefaultedCollectionStateValidator<TValue>(_item, defaultValueFactory);
	}
}
