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
	public struct OptionalCollectionStateValidator<TValue> : IStateValidator<Option<TValue[]>>
	{
		public Data<Option<TValue[]>> Data => new DataSource<OptionalCollectionStateValidator<TValue>, Option<TValue[]>>(this);

		private readonly Data<TValue> _item;

		public OptionalCollectionStateValidator(Data<TValue> item)
			=> _item = item;

		public OptionalCollectionNullableStateValidator<TValue> Nullable()
			=> new OptionalCollectionNullableStateValidator<TValue>(_item);

		IStateDescriptor IStateValidator<Option<TValue[]>>.GetDescriptor()
			=> new OptionalCollectionStateDescriptor(false, _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Option<TValue[]>>.GetImplicitValueDescriptors()
			=> new[] { new NotNullDescriptor() };

		Result<Option<TValue[]>, ValidationError[]> IStateValidator<Option<TValue[]>>.Validate(object model, bool isSet, Option<TValue[]> value)
			=> isSet
				? (value.TryGetValue(out var v) ? _item.VerifyCollection(model, v).Select(Option.Some) : Result.Failure<Option<TValue[]>, ValidationError[]>(new[] { ValidationErrors.NotNull() }))
				: Result.Success<Option<TValue[]>, ValidationError[]>(Option.None<TValue[]>());

		public static implicit operator Data<Option<TValue[]>>(OptionalCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
