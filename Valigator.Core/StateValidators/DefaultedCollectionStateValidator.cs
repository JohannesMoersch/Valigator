using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.DataContainers;
using Valigator.Core.DataContainers.Factories;
using Valigator.Core.DataSources;
using Valigator.Core.Helpers;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct DefaultedCollectionStateValidator<TValue> : ICollectionStateValidator<TValue[], TValue>
	{
		private static IDataContainer<TValue[]> CreateContainer(DefaultedCollectionStateValidator<TValue> stateValidator)
			=> new CollectionDataContainer<DefaultedCollectionStateValidator<TValue>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance);

		public Data<TValue[]> Data => new Data<TValue[]>(CreateContainer(this));

		private readonly Data<TValue> _item;

		private readonly Option<TValue[]> _defaultValue;

		private readonly Func<TValue[]> _defaultValueFactory;

		public DefaultedCollectionStateValidator(Data<TValue> item, TValue[] defaultValue)
		{
			_item = item;
			_defaultValue = Option.Some(defaultValue ?? throw new NullDefaultException());
			_defaultValueFactory = default;
		}

		public DefaultedCollectionStateValidator(Data<TValue> item, Func<TValue[]> defaultValueFactory)
		{
			_item = item;
			_defaultValue = default;
			_defaultValueFactory = defaultValueFactory ?? throw new ArgumentNullException(nameof(defaultValueFactory));
		}

		public NullableDefaultedCollectionStateValidator<TValue> Nullable()
		{
			if (_defaultValueFactory != null)
				return new NullableDefaultedCollectionStateValidator<TValue>(_item, _defaultValueFactory);

			if (_defaultValue.TryGetValue(out var some))
				return new NullableDefaultedCollectionStateValidator<TValue>(_item, some);

			return new NullableDefaultedCollectionStateValidator<TValue>();
		}

		public DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> new DataSourceStandard<CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], TValueValidator>(new CollectionDataContainerFactory<DefaultedCollectionStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		private TValue[] GetDefaultValue()
			=> StateValidatorHelpers.GetDefaultValue(_defaultValue, _defaultValueFactory);

		IStateDescriptor IStateValidator<TValue[], Option<TValue>[]>.GetDescriptor()
			=> new CollectionStateDescriptor(StateValidatorHelpers.GetDefaultValueForDescriptor(_defaultValue, _defaultValueFactory), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<TValue[], Option<TValue>[]>.GetImplicitValueDescriptors()
			=> new[] { new NotNullDescriptor() };

		Result<TValue[], ValidationError[]> IStateValidator<TValue[], Option<TValue>[]>.Validate(Option<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
				{
					if (StateValidatorHelpers.ValidateCollectionNotNull(notNull).TryGetValue(out var success, out var failure))
						return Result.Success<TValue[], ValidationError[]>(success);

					return Result.Failure<TValue[], ValidationError[]>(failure);
				}

				return Result.Failure<TValue[], ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Success<TValue[], ValidationError[]>(GetDefaultValue());
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, TValue[] value)
			=> StateValidatorHelpers.IsCollectionValid(_item, model, value);

		public static implicit operator Data<TValue[]>(DefaultedCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
