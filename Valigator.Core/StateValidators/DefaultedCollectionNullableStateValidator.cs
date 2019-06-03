using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct DefaultedCollectionNullableStateValidator<TValue> : IStateValidator<Option<TValue[]>>
	{
		public Data<Option<TValue[]>> Data => new DataSource<DefaultedCollectionNullableStateValidator<TValue>, Option<TValue[]>>(this);

		private readonly Data<TValue> _item;

		private readonly TValue[] _defaultValue;

		private readonly Func<TValue[]> _defaultValueFactory;

		public DefaultedCollectionNullableStateValidator(Data<TValue> item, TValue[] defaultValue)
		{
			_item = item;
			_defaultValue = defaultValue;
			_defaultValueFactory = null;
		}

		public DefaultedCollectionNullableStateValidator(Data<TValue> item, Func<TValue[]> defaultValueFactory)
		{
			_item = item;
			_defaultValue = null;
			_defaultValueFactory = defaultValueFactory;
		}

		private TValue[] GetDefaultValue()
			=> _defaultValueFactory != null ? _defaultValueFactory.Invoke() : _defaultValue;

		IStateDescriptor IStateValidator<Option<TValue[]>>.GetDescriptor()
			=> new DefaultedCollectionStateDescriptor(true, GetDefaultValue(), _item.DataDescriptor);

		Result<Option<TValue[]>, ValidationError[]> IStateValidator<Option<TValue[]>>.Validate(object model, bool isSet, Option<TValue[]> value)
			=> isSet
				? (value.TryGetValue(out var v) ? _item.VerifyCollection(model, v).Select(Option.Some) : Result.Success<Option<TValue[]>, ValidationError[]>(value))
				: Result.Success<Option<TValue[]>, ValidationError[]>(Option.Some(GetDefaultValue()));

		public static implicit operator Data<Option<TValue[]>>(DefaultedCollectionNullableStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
