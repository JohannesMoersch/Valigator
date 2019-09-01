using System;
using System.Collections.Generic;
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
	public struct NullableDefaultedNullableCollectionStateValidator<TValue> : ICollectionStateValidator<Option<Option<TValue>[]>, TValue>
	{
		private static IDataContainer<Option<Option<TValue>[]>> CreateContainer(NullableDefaultedNullableCollectionStateValidator<TValue> stateValidator)
			=> new NullableCollectionNullableDataContainer<NullableDefaultedNullableCollectionStateValidator<TValue>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance);

		public Data<Option<Option<TValue>[]>> Data => new Data<Option<Option<TValue>[]>>(CreateContainer(this));

		private readonly Data<TValue> _item;

		private readonly Option<Option<TValue>[]> _defaultValue;

		private readonly Func<Option<TValue>[]> _defaultValueFactory;

		public NullableDefaultedNullableCollectionStateValidator(Data<TValue> item, Option<TValue>[] defaultValue)
		{
			_item = item;
			_defaultValue = Option.Some(defaultValue ?? throw new NullDefaultException());
			_defaultValueFactory = default;
		}

		public NullableDefaultedNullableCollectionStateValidator(Data<TValue> item, Func<Option<TValue>[]> defaultValueFactory)
		{
			_item = item;
			_defaultValue = default;
			_defaultValueFactory = defaultValueFactory ?? throw new ArgumentNullException(nameof(defaultValueFactory));
		}

		public DataSourceStandard<NullableCollectionNullableDataContainerFactory<NullableDefaultedNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<Option<TValue>[]>, Option<TValue>[], TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> new DataSourceStandard<NullableCollectionNullableDataContainerFactory<NullableDefaultedNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<Option<TValue>[]>, Option<TValue>[], TValueValidator>(new NullableCollectionNullableDataContainerFactory<NullableDefaultedNullableCollectionStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		private Option<Option<TValue>[]> GetDefaultValue()
			=> Option.Some(StateValidatorHelpers.GetDefaultValue(_defaultValue, _defaultValueFactory));

		IStateDescriptor IStateValidator<Option<Option<TValue>[]>, Option<TValue>[]>.GetDescriptor()
			=> new CollectionStateDescriptor(StateValidatorHelpers.GetDefaultValueForDescriptor(_defaultValue, _defaultValueFactory), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Option<Option<TValue>[]>, Option<TValue>[]>.GetImplicitValueDescriptors()
			=> Array.Empty<IValueDescriptor>();

		Result<Option<Option<TValue>[]>, ValidationError[]> IStateValidator<Option<Option<TValue>[]>, Option<TValue>[]>.Validate(Option<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var isSet))
				return Result.Success<Option<Option<TValue>[]>, ValidationError[]>(isSet);

			return Result.Success<Option<Option<TValue>[]>, ValidationError[]>(GetDefaultValue());
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Option<Option<TValue>[]> value)
			=> StateValidatorHelpers.IsCollectionValid(_item, model, value);

		public static implicit operator Data<Option<Option<TValue>[]>>(NullableDefaultedNullableCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
