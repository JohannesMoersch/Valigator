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
	public struct RequiredCollectionStateValidator<TValue> : IStateValidator<TValue[]>
	{
		public Data<TValue[]> Data => new DataSource<RequiredCollectionStateValidator<TValue>, TValue[]>(this);

		private readonly Data<TValue> _item;

		public RequiredCollectionStateValidator(Data<TValue> item)
			=> _item = item;

		public RequiredCollectionNullableStateValidator<TValue> Nullable()
			=> new RequiredCollectionNullableStateValidator<TValue>(_item);

		IStateDescriptor IStateValidator<TValue[]>.GetDescriptor()
			=> new RequiredCollectionStateDescriptor(false, _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<TValue[]>.GetImplicitValueDescriptors()
			=> new IValueDescriptor[] { new RequiredDescriptor(), new NotNullDescriptor() };

		Result<TValue[], ValidationError[]> IStateValidator<TValue[]>.Validate(object model, bool isSet, TValue[] value)
			=> isSet
				? (value != null ? _item.VerifyCollection(model, value) : Result.Failure<TValue[], ValidationError[]>(new[] { ValidationErrors.NotNull() }))
				: Result.Failure<TValue[], ValidationError[]>(new[] { new ValidationError("", new RequiredDescriptor()) });

		public static implicit operator Data<TValue[]>(RequiredCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
