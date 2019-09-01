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
	public struct NullableDefaultedCollectionStateValidator<TValue> : ICollectionStateValidator<Option<TValue[]>, TValue>
	{
		private static IDataContainer<Option<TValue[]>> CreateContainer(NullableDefaultedCollectionStateValidator<TValue> stateValidator)
			=> new NullableCollectionDataContainer<NullableDefaultedCollectionStateValidator<TValue>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance);

		public Data<Option<TValue[]>> Data => new Data<Option<TValue[]>>(CreateContainer(this));

		private readonly Data<TValue> _item;

		private readonly Option<TValue[]> _defaultValue;

		private readonly Func<TValue[]> _defaultValueFactory;

		public NullableDefaultedCollectionStateValidator(Data<TValue> item, TValue[] defaultValue)
		{
			_item = item;
			_defaultValue = Option.Some(defaultValue ?? throw new NullDefaultException());
			_defaultValueFactory = default;
		}

		public NullableDefaultedCollectionStateValidator(Data<TValue> item, Func<TValue[]> defaultValueFactory)
		{
			_item = item;
			_defaultValue = default;
			_defaultValueFactory = defaultValueFactory ?? throw new ArgumentNullException(nameof(defaultValueFactory));
		}

		public DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> new DataSourceStandard<NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], TValueValidator>(new NullableCollectionDataContainerFactory<NullableDefaultedCollectionStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		private Option<TValue[]> GetDefaultValue()
			=> Option.Some(StateValidatorHelpers.GetDefaultValue(_defaultValue, _defaultValueFactory));

		IStateDescriptor IStateValidator<Option<TValue[]>, Option<TValue>[]>.GetDescriptor()
			=> new CollectionStateDescriptor(StateValidatorHelpers.GetDefaultValueForDescriptor(_defaultValue, _defaultValueFactory), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Option<TValue[]>, Option<TValue>[]>.GetImplicitValueDescriptors()
			=> Array.Empty<IValueDescriptor>();

		Result<Option<TValue[]>, ValidationError[]> IStateValidator<Option<TValue[]>, Option<TValue>[]>.Validate(Option<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
				{
					if (StateValidatorHelpers.ValidateCollectionNotNull(notNull).TryGetValue(out var success, out var failure))
						return Result.Success<Option<TValue[]>, ValidationError[]>(Option.Some(success));

					return Result.Failure<Option<TValue[]>, ValidationError[]>(failure);
				}

				return Result.Success<Option<TValue[]>, ValidationError[]>(Option.None<TValue[]>());
			}

			return Result.Success<Option<TValue[]>, ValidationError[]>(GetDefaultValue());
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Option<TValue[]> value)
			=> StateValidatorHelpers.IsCollectionValid(_item, model, value);

		public static implicit operator Data<Option<TValue[]>>(NullableDefaultedCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
