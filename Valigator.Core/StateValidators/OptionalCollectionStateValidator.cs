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
	public struct OptionalCollectionStateValidator<TValue> : ICollectionStateValidator<Optional<TValue[]>, TValue>
	{
		private static IDataContainer<Optional<TValue[]>> CreateContainer(OptionalCollectionStateValidator<TValue> stateValidator)
			=> new OptionalCollectionDataContainer<OptionalCollectionStateValidator<TValue>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance);

		public Data<Optional<TValue[]>> Data => new Data<Optional<TValue[]>>(CreateContainer(this));

		private readonly Data<TValue> _item;

		public OptionalCollectionStateValidator(Data<TValue> item)
			=> _item = item;

		public NullableOptionalCollectionStateValidator<TValue> Nullable()
			=> new NullableOptionalCollectionStateValidator<TValue>(_item);

		public DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TValue, TValue>, Optional<TValue[]>, TValue[], TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> new DataSourceStandard<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TValue, TValue>, Optional<TValue[]>, TValue[], TValueValidator>(new OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[]> MappedFrom<TSource>(Func<TSource, TValue> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[]> MappedFrom<TSource>(Func<TSource, TValue> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[]> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Optional<TValue[]>, TValue[]>(new OptionalCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>(this, mapping));

		IStateDescriptor IStateValidator<Optional<TValue[]>, Option<TValue>[]>.GetDescriptor()
			=> new CollectionStateDescriptor(Option.None<object[]>(), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Optional<TValue[]>, Option<TValue>[]>.GetImplicitValueDescriptors()
			=> new[] { new NotNullDescriptor() };

		Result<Optional<TValue[]>, ValidationError[]> IStateValidator<Optional<TValue[]>, Option<TValue>[]>.Validate(Optional<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
				{
					if (StateValidatorHelpers.ValidateCollectionNotNull(notNull).TryGetValue(out var success, out var failure))
						return Result.Success<Optional<TValue[]>, ValidationError[]>(Optional.Set(success));

					return Result.Failure<Optional<TValue[]>, ValidationError[]>(failure);
				}

				return Result.Failure<Optional<TValue[]>, ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Success<Optional<TValue[]>, ValidationError[]>(Optional.Unset<TValue[]>());
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Optional<TValue[]> value)
			=> StateValidatorHelpers.IsCollectionValid(_item, model, value);

		public static implicit operator Data<Optional<TValue[]>>(OptionalCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
