using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;
using Valigator.Core.Helpers;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct OptionalCollectionNullableStateValidator<TValue> : IStateValidator<Option<TValue[]>>
	{
		public Data<Option<TValue[]>> Data => new DataSource<OptionalCollectionNullableStateValidator<TValue>, PassthroughValidator<Option<TValue[]>>, Option<TValue[]>>(this, default);

		private readonly Data<TValue> _item;

		public OptionalCollectionNullableStateValidator(Data<TValue> item)
			=> _item = item;

		IStateDescriptor IStateValidator<Option<TValue[]>>.GetDescriptor()
			=> new OptionalCollectionStateDescriptor(true, _item.DataDescriptor);

		Result<Option<TValue[]>, ValidationError[]> IStateValidator<Option<TValue[]>>.Validate(object model, bool isSet, Option<TValue[]> value)
			=> isSet
				? (value.TryGetValue(out var v) ? _item.VerifyCollection(model, v).Select(Option.Some) : Result.Success<Option<TValue[]>, ValidationError[]>(value))
				: Result.Success<Option<TValue[]>, ValidationError[]>(Option.None<TValue[]>());

		public static implicit operator Data<Option<TValue[]>>(OptionalCollectionNullableStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
