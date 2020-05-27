using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.DataContainers;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;
using Valigator.Core.ValueValidators;
using Valigator.Core.DataContainers.Factories;
using Valigator.Core.DataSources;

namespace Valigator.Core.StateValidators
{
	public struct DefaultedStateValidator<TValue> : IStateValidator<TValue, TValue>
	{
		private static IDataContainer<TValue> Instance { get; } = CreateContainer(new DefaultedStateValidator<TValue>(default(TValue)));

		private static IDataContainer<TValue> CreateContainer(DefaultedStateValidator<TValue> stateValidator)
			=> new DataContainer<DefaultedStateValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance);

		public Data<TValue> Data
		{
			get
			{
				if (_defaultValueFactory == null && !_defaultValue.TryGetValue(out var value))
					return new Data<TValue>(Instance);

				return new Data<TValue>(CreateContainer(this));
			}
		}

		private readonly Option<TValue> _defaultValue;

		private readonly Func<TValue> _defaultValueFactory;

		public DefaultedStateValidator(TValue defaultValue)
		{
			_defaultValue = Option.Some(defaultValue != null ? defaultValue : throw new NullDefaultException());
			_defaultValueFactory = null;
		}

		public DefaultedStateValidator(Func<TValue> defaultValueFactory)
		{
			_defaultValue = Option.None<TValue>();
			_defaultValueFactory = defaultValueFactory;
		}

		public NullableDefaultedStateValidator<TValue> Nullable()
		{
			if (_defaultValueFactory != null)
				return new NullableDefaultedStateValidator<TValue>(_defaultValueFactory);

			if (_defaultValue.TryGetValue(out var some))
				return new NullableDefaultedStateValidator<TValue>(some);

			return new NullableDefaultedStateValidator<TValue>();
		}

		public DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue, TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue>
			=> new DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue, TValueValidator>(new DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue> MappedFrom<TSource>(Func<TSource, TValue> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue> MappedFrom<TSource>(Func<TSource, TValue> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue>(new DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>(this, mapping));

		private TValue GetDefaultValue()
			=> StateValidatorHelpers.GetDefaultValue(_defaultValue, _defaultValueFactory);

		IStateDescriptor IStateValidator<TValue, TValue>.GetDescriptor()
			=> new StateDescriptor(Option.Some<object>(GetDefaultValue()));

		IValueDescriptor[] IStateValidator<TValue, TValue>.GetImplicitValueDescriptors()
			=> new[] { new NotNullDescriptor() };

		Result<TValue, ValidationError[]> IStateValidator<TValue, TValue>.Validate(Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
					return Result.Success<TValue, ValidationError[]>(notNull);

				return Result.Failure<TValue, ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Success<TValue, ValidationError[]>(GetDefaultValue());
		}

		public static implicit operator Data<TValue>(DefaultedStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
