using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct CollectionNullableStateValidator<TValue> : IStateValidator<Option<TValue[]>>
	{
		public Data<Option<TValue[]>> Data => new DataSource<CollectionNullableStateValidator<TValue>, PassthroughValidator<Option<TValue[]>>, Option<TValue[]>>(this, default);

		private readonly Data<TValue> _item;

		public CollectionNullableStateValidator(Data<TValue> item)
			=> _item = item;

		IStateDescriptor IStateValidator<Option<TValue[]>>.GetDescriptor()
			=> new CollectionStateDescriptor(false, _item.DataDescriptor);

		Result<Option<TValue[]>, ValidationError> IStateValidator<Option<TValue[]>>.Validate(object model, bool isSet, Option<TValue[]> value) 
			=> throw new NotImplementedException();

		public static implicit operator Data<Option<TValue[]>>(CollectionNullableStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
