using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct RequiredCollectionNullableStateValidator<TValue> : IStateValidator<Option<TValue[]>>
	{
		public Data<Option<TValue[]>> Data => new DataSource<RequiredCollectionNullableStateValidator<TValue>, Option<TValue[]>>(this);

		private readonly Data<TValue> _item;

		public RequiredCollectionNullableStateValidator(Data<TValue> item)
			=> _item = item;

		IStateDescriptor IStateValidator<Option<TValue[]>>.GetDescriptor()
			=> new RequiredCollectionStateDescriptor(true, _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Option<TValue[]>>.GetImplicitValueDescriptors()
			=> new[] { new RequiredDescriptor() };

		Result<Option<TValue[]>, ValidationError[]> IStateValidator<Option<TValue[]>>.Validate(object model, bool isSet, Option<TValue[]> value)
			=> isSet
				? (value.TryGetValue(out var v) ? _item.VerifyCollection(model, v).Select(Option.Some) : Result.Success<Option<TValue[]>, ValidationError[]>(value))
				: Result.Failure<Option<TValue[]>, ValidationError[]>(new[] { new ValidationError("", new RequiredDescriptor()) });

		public static implicit operator Data<Option<TValue[]>>(RequiredCollectionNullableStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
