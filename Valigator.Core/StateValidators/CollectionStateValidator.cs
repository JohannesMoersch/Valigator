using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct CollectionStateValidator<TValue> : IStateValidator<TValue[]>
	{
		public Data<TValue[]> Data => new DataSource<CollectionStateValidator<TValue>, PassthroughValidator<TValue[]>, TValue[]>(this, default);

		private readonly Data<TValue> _item;

		public CollectionStateValidator(Data<TValue> item)
			=> _item = item;

		public CollectionNullableStateValidator<TValue> Nullable()
			=> new CollectionNullableStateValidator<TValue>();

		IStateDescriptor IStateValidator<TValue[]>.GetDescriptor()
			=> new CollectionStateDescriptor(false, _item.DataDescriptor);

		Result<TValue[], ValidationError> IStateValidator<TValue[]>.Validate(object model, bool isSet, TValue[] value) 
			=> throw new NotImplementedException();

		public static implicit operator Data<TValue[]>(CollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
