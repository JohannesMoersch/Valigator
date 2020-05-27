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
	public struct OptionalCollectionStateValidator<TValue> : ICollectionStateValidator<Option<TValue[]>, TValue>
	{
		private static IDataContainer<Option<TValue[]>> CreateContainer(OptionalCollectionStateValidator<TValue> stateValidator)
			=> new NullableCollectionDataContainer<OptionalCollectionStateValidator<TValue>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance);

		public Data<Option<TValue[]>> Data => new Data<Option<TValue[]>>(CreateContainer(this));

		private readonly Data<TValue> _item;

		public OptionalCollectionStateValidator(Data<TValue> item)
			=> _item = item;

		public NullableOptionalCollectionStateValidator<TValue> Nullable()
			=> new NullableOptionalCollectionStateValidator<TValue>(_item);

		public DataSourceStandard<NullableCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> new DataSourceStandard<NullableCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], TValueValidator>(new NullableCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<NullableCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> MappedFrom<TSource>(Func<TSource, TValue> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<NullableCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<NullableCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> MappedFrom<TSource>(Func<TSource, TValue> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<NullableCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<NullableCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<NullableCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]>(new NullableCollectionDataContainerFactory<OptionalCollectionStateValidator<TValue>, TSource, TValue>(this, mapping));

		IStateDescriptor IStateValidator<Option<TValue[]>, Option<TValue>[]>.GetDescriptor()
			=> new CollectionStateDescriptor(Option.None<object[]>(), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Option<TValue[]>, Option<TValue>[]>.GetImplicitValueDescriptors()
			=> new[] { new NotNullDescriptor() };

		Result<Option<TValue[]>, ValidationError[]> IStateValidator<Option<TValue[]>, Option<TValue>[]>.Validate(Optional<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
				{
					if (StateValidatorHelpers.ValidateCollectionNotNull(notNull).TryGetValue(out var success, out var failure))
						return Result.Success<Option<TValue[]>, ValidationError[]>(Option.Some(success));

					return Result.Failure<Option<TValue[]>, ValidationError[]>(failure);
				}

				return Result.Failure<Option<TValue[]>, ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Success<Option<TValue[]>, ValidationError[]>(Option.None<TValue[]>());
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Option<TValue[]> value)
			=> StateValidatorHelpers.IsCollectionValid(_item, model, value);

		public static implicit operator Data<Option<TValue[]>>(OptionalCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
