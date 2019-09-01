using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.StateValidators;

namespace Valigator.Core
{
	public struct NullableCollectionFactory<TValue>
	{
		private readonly Data<TValue> _item;

		public NullableCollectionFactory(Data<TValue> item) 
			=> _item = item;

		public RequiredNullableCollectionStateValidator<TValue> Required()
			=> new RequiredNullableCollectionStateValidator<TValue>(_item);

		public OptionalNullableCollectionStateValidator<TValue> Optional()
			=> new OptionalNullableCollectionStateValidator<TValue>(_item);

		public DefaultedNullableCollectionStateValidator<TValue> Defaulted()
			=> new DefaultedNullableCollectionStateValidator<TValue>(_item, Array.Empty<Option<TValue>>());

		public DefaultedNullableCollectionStateValidator<TValue> Defaulted(Option<TValue>[] defaultValue)
			=> new DefaultedNullableCollectionStateValidator<TValue>(_item, defaultValue);

		public DefaultedNullableCollectionStateValidator<TValue> Defaulted(Func<Option<TValue>[]> defaultValueFactory)
			=> new DefaultedNullableCollectionStateValidator<TValue>(_item, defaultValueFactory);
	}
}
