using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;
using Valigator.Core.Helpers;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct DefaultedCollectionNullableStateValidator<TValue> : IStateValidator<Option<TValue[]>>
	{
		public Data<Option<TValue[]>> Data => new DataSource<DefaultedCollectionNullableStateValidator<TValue>, PassthroughValidator<Option<TValue[]>>, Option<TValue[]>>(this, default);

		private readonly Data<TValue> _item;

		private readonly Option<TValue[]> _defaultValue;

		public DefaultedCollectionNullableStateValidator(Data<TValue> item, Option<TValue[]> defaultValue)
		{
			_item = item;
			_defaultValue = defaultValue;
		}

		IStateDescriptor IStateValidator<Option<TValue[]>>.GetDescriptor()
			=> new CollectionStateDescriptor(false, _item.DataDescriptor);

		Result<Option<TValue[]>, ValidationError> IStateValidator<Option<TValue[]>>.Validate(object model, bool isSet, Option<TValue[]> value)
			=> isSet
				? (value.TryGetValue(out var v) ? _item.VerifyCollection(model, v).Select(Option.Some) : Result.Success<Option<TValue[]>, ValidationError>(value))
				: Result.Success<Option<TValue[]>, ValidationError>(_defaultValue);

		public static implicit operator Data<Option<TValue[]>>(DefaultedCollectionNullableStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
