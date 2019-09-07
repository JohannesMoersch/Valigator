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
	public struct NullableRequiredNullableCollectionStateValidator<TValue> : ICollectionStateValidator<Option<Option<TValue>[]>, TValue>
	{
		private static IDataContainer<Option<Option<TValue>[]>> CreateContainer(NullableRequiredNullableCollectionStateValidator<TValue> stateValidator)
			=> new NullableCollectionNullableDataContainer<NullableRequiredNullableCollectionStateValidator<TValue>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance);

		public Data<Option<Option<TValue>[]>> Data => new Data<Option<Option<TValue>[]>>(CreateContainer(this));

		private readonly Data<Option<TValue>> _item;

		public NullableRequiredNullableCollectionStateValidator(Data<Option<TValue>> item)
			=> _item = item;

		public DataSourceStandard<NullableCollectionNullableDataContainerFactory<NullableRequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<Option<TValue>[]>, Option<TValue>[], TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> new DataSourceStandard<NullableCollectionNullableDataContainerFactory<NullableRequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<Option<TValue>[]>, Option<TValue>[], TValueValidator>(new NullableCollectionNullableDataContainerFactory<NullableRequiredNullableCollectionStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<NullableCollectionNullableDataContainerFactory<NullableRequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<Option<TValue>[]>, Option<TValue>[]> MappedFrom<TSource>(Func<TSource, TValue> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<NullableCollectionNullableDataContainerFactory<NullableRequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<Option<TValue>[]>, Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<NullableCollectionNullableDataContainerFactory<NullableRequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<Option<TValue>[]>, Option<TValue>[]> MappedFrom<TSource>(Func<TSource, TValue> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<NullableCollectionNullableDataContainerFactory<NullableRequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<Option<TValue>[]>, Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<NullableCollectionNullableDataContainerFactory<NullableRequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<Option<TValue>[]>, Option<TValue>[]> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<NullableCollectionNullableDataContainerFactory<NullableRequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<Option<TValue>[]>, Option<TValue>[]>(new NullableCollectionNullableDataContainerFactory<NullableRequiredNullableCollectionStateValidator<TValue>, TSource, TValue>(this, mapping));

		IStateDescriptor IStateValidator<Option<Option<TValue>[]>, Option<TValue>[]>.GetDescriptor()
			=> new CollectionStateDescriptor(Option.None<object[]>(), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Option<Option<TValue>[]>, Option<TValue>[]>.GetImplicitValueDescriptors()
			=> new IValueDescriptor[] { new RequiredDescriptor() };

		Result<Option<Option<TValue>[]>, ValidationError[]> IStateValidator<Option<Option<TValue>[]>, Option<TValue>[]>.Validate(Option<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var isSet))
				return Result.Success<Option<Option<TValue>[]>, ValidationError[]>(isSet);

			return Result.Failure<Option<Option<TValue>[]>, ValidationError[]>(new[] { ValidationErrors.Required() });
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Option<Option<TValue>[]> value)
			=> StateValidatorHelpers.IsCollectionValid(_item, model, value);

		public static implicit operator Data<Option<Option<TValue>[]>>(NullableRequiredNullableCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
