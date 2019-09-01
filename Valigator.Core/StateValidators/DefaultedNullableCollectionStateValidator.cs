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
	public struct DefaultedNullableCollectionStateValidator<TValue> : ICollectionStateValidator<Option<TValue>[], TValue>
	{
		private static IDataContainer<Option<TValue>[]> CreateContainer(DefaultedNullableCollectionStateValidator<TValue> stateValidator)
			=> new CollectionNullableDataContainer<DefaultedNullableCollectionStateValidator<TValue>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance);

		public Data<Option<TValue>[]> Data => new Data<Option<TValue>[]>(CreateContainer(this));

		private readonly Data<TValue> _item;

		private readonly Option<Option<TValue>[]> _defaultValue;

		private readonly Func<Option<TValue>[]> _defaultValueFactory;

		public DefaultedNullableCollectionStateValidator(Data<TValue> item, Option<TValue>[] defaultValue)
		{
			_item = item;
			_defaultValue = Option.Some(defaultValue ?? throw new NullDefaultException());
			_defaultValueFactory = default;
		}

		public DefaultedNullableCollectionStateValidator(Data<TValue> item, Func<Option<TValue>[]> defaultValueFactory)
		{
			_item = item;
			_defaultValue = default;
			_defaultValueFactory = defaultValueFactory ?? throw new ArgumentNullException(nameof(defaultValueFactory));
		}

		public NullableDefaultedNullableCollectionStateValidator<TValue> Nullable()
		{
			if (_defaultValueFactory != null)
				return new NullableDefaultedNullableCollectionStateValidator<TValue>(_item, _defaultValueFactory);

			if (_defaultValue.TryGetValue(out var some))
				return new NullableDefaultedNullableCollectionStateValidator<TValue>(_item, some);

			return new NullableDefaultedNullableCollectionStateValidator<TValue>();
		}

		public DataSourceStandard<CollectionNullableDataContainerFactory<DefaultedNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[], TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> new DataSourceStandard<CollectionNullableDataContainerFactory<DefaultedNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[], TValueValidator>(new CollectionNullableDataContainerFactory<DefaultedNullableCollectionStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<CollectionNullableDataContainerFactory<DefaultedNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]> MappedFrom<TSource>(Func<TSource, TValue> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<CollectionNullableDataContainerFactory<DefaultedNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<CollectionNullableDataContainerFactory<DefaultedNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]> MappedFrom<TSource>(Func<TSource, TValue> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<CollectionNullableDataContainerFactory<DefaultedNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<CollectionNullableDataContainerFactory<DefaultedNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<CollectionNullableDataContainerFactory<DefaultedNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]>(new CollectionNullableDataContainerFactory<DefaultedNullableCollectionStateValidator<TValue>, TSource, TValue>(this, mapping));

		private Option<TValue>[] GetDefaultValue()
			=> StateValidatorHelpers.GetDefaultValue(_defaultValue, _defaultValueFactory);

		IStateDescriptor IStateValidator<Option<TValue>[], Option<TValue>[]>.GetDescriptor()
			=> new CollectionStateDescriptor(StateValidatorHelpers.GetDefaultValueForDescriptor(_defaultValue, _defaultValueFactory), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Option<TValue>[], Option<TValue>[]>.GetImplicitValueDescriptors()
			=> new[] { new NotNullDescriptor() };

		Result<Option<TValue>[], ValidationError[]> IStateValidator<Option<TValue>[], Option<TValue>[]>.Validate(Option<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
					return Result.Success<Option<TValue>[], ValidationError[]>(notNull);

				return Result.Failure<Option<TValue>[], ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Success<Option<TValue>[], ValidationError[]>(GetDefaultValue());
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Option<TValue>[] value)
			=> StateValidatorHelpers.IsCollectionValid(_item, model, value);

		public static implicit operator Data<Option<TValue>[]>(DefaultedNullableCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
