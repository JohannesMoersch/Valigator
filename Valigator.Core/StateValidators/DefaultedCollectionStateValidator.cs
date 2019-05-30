using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;
using Valigator.Core.Helpers;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct DefaultedCollectionStateValidator<TValue> : IStateValidator<TValue[]>
	{
		public Data<TValue[]> Data => new DataSource<DefaultedCollectionStateValidator<TValue>, PassthroughValidator<TValue[]>, TValue[]>(this, default);

		private readonly Data<TValue> _item;

		private readonly TValue[] _defaultValue;

		public DefaultedCollectionStateValidator(Data<TValue> item, TValue[] defaultValue)
		{
			_item = item;
			_defaultValue = defaultValue;
		}

		public DefaultedCollectionNullableStateValidator<TValue> Nullable()
			=> new DefaultedCollectionNullableStateValidator<TValue>();

		IStateDescriptor IStateValidator<TValue[]>.GetDescriptor()
			=> new CollectionStateDescriptor(false, _item.DataDescriptor);

		Result<TValue[], ValidationError> IStateValidator<TValue[]>.Validate(object model, bool isSet, TValue[] value)
			=> isSet
				? (value != null ? _item.VerifyCollection(model, value) : Result.Failure<TValue[], ValidationError>(new ValidationError("")))
				: Result.Success<TValue[], ValidationError>(_defaultValue);

		public static implicit operator Data<TValue[]>(DefaultedCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
