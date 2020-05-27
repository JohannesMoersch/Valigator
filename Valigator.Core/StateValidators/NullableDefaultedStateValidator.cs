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
	public struct NullableDefaultedStateValidator<TValue> : IStateValidator<Option<TValue>, TValue>
	{
		private static IDataContainer<Option<TValue>> Instance { get; } = CreateContainer(new NullableDefaultedStateValidator<TValue>(default(TValue)));

		private static IDataContainer<Option<TValue>> CreateContainer(NullableDefaultedStateValidator<TValue> stateValidator)
			=> new NullableDataContainer<NullableDefaultedStateValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance);

		public Data<Option<TValue>> Data
		{
			get
			{
				if (_defaultValueFactory == null && !_defaultValue.TryGetValue(out var value))
					return new Data<Option<TValue>>(Instance);

				return new Data<Option<TValue>>(CreateContainer(this));
			}
		}

		private readonly Option<TValue> _defaultValue;

		private readonly Func<TValue> _defaultValueFactory;

		public NullableDefaultedStateValidator(TValue defaultValue)
		{
			_defaultValue = Option.Some(defaultValue != null ? defaultValue : throw new NullDefaultException());
			_defaultValueFactory = null;
		}

		public NullableDefaultedStateValidator(Func<TValue> defaultValueFactory)
		{
			_defaultValue = Option.None<TValue>();
			_defaultValueFactory = defaultValueFactory ?? throw new ArgumentNullException(nameof(defaultValueFactory));
		}

		public DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue>
			=> new DataSourceStandard<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator>(new NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Func<TSource, Option<TValue>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Func<TSource, Result<Option<TValue>, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Func<TSource, Option<TValue>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Func<TSource, Result<Option<TValue>, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue>(new NullableDataContainerFactory<NullableDefaultedStateValidator<TValue>, TSource, TValue>(this, mapping));

		private Option<TValue> GetDefaultValue()
			=> Option.Some(StateValidatorHelpers.GetDefaultValue(_defaultValue, _defaultValueFactory));

		IStateDescriptor IStateValidator<Option<TValue>, TValue>.GetDescriptor()
			=> new StateDescriptor(Option.Some<object>(GetDefaultValue()));

		IValueDescriptor[] IStateValidator<Option<TValue>, TValue>.GetImplicitValueDescriptors()
			=> Array.Empty<IValueDescriptor>();

		Result<Option<TValue>, ValidationError[]> IStateValidator<Option<TValue>, TValue>.Validate(Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var isSet))
				return Result.Success<Option<TValue>, ValidationError[]>(isSet);

			return Result.Success<Option<TValue>, ValidationError[]>(GetDefaultValue());
		}

		public static implicit operator Data<Option<TValue>>(NullableDefaultedStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
