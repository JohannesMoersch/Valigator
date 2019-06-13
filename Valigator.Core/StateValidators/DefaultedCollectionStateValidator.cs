using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct DefaultedCollectionStateValidator<TValue> : IStateValidator<TValue[]>
	{
		public Data<TValue[]> Data => new DataSource<DefaultedCollectionStateValidator<TValue>, TValue[]>(this);

		private readonly Data<TValue> _item;

		private readonly TValue[] _defaultValue;

		private readonly Func<TValue[]> _defaultValueFactory;

		public DefaultedCollectionStateValidator(Data<TValue> item, TValue[] defaultValue)
		{
			_item = item;
			_defaultValue = defaultValue ?? throw new ArgumentNullException(nameof(defaultValue));
			_defaultValueFactory = null;
		}

		public DefaultedCollectionStateValidator(Data<TValue> item, Func<TValue[]> defaultValueFactory)
		{
			_item = item;
			_defaultValue = null;
			_defaultValueFactory = defaultValueFactory ?? throw new ArgumentNullException(nameof(defaultValueFactory));
		}

		public DefaultedCollectionNullableStateValidator<TValue> Nullable()
		{
			if (_defaultValueFactory != null)
				return new DefaultedCollectionNullableStateValidator<TValue>(_item, _defaultValueFactory);

			return new DefaultedCollectionNullableStateValidator<TValue>(_item, _defaultValue);
		}

		private TValue[] GetDefaultValue()
			=> _defaultValueFactory != null ? _defaultValueFactory.Invoke() : _defaultValue;

		IStateDescriptor IStateValidator<TValue[]>.GetDescriptor()
			=> new DefaultedCollectionStateDescriptor(false, GetDefaultValue(), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<TValue[]>.GetImplicitValueDescriptors()
			=> new[] { new NotNullDescriptor() };

		Result<TValue[], ValidationError[]> IStateValidator<TValue[]>.Validate(object model, bool isSet, TValue[] value)
			=> isSet
				? (value != null ? _item.VerifyCollection(model, value) : Result.Failure<TValue[], ValidationError[]>(new[] { ValidationErrors.NotNull() }))
				: _item.VerifyCollection(model, GetDefaultValue());

		public static implicit operator Data<TValue[]>(DefaultedCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
