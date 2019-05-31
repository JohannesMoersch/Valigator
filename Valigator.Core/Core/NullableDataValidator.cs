using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;
using Valigator.Core.Helpers;

namespace Valigator.Core
{
	public class NullableDataValidator<TStateValidator, TValueValidator, TValue> : IDataValidator<Option<TValue>>
		where TStateValidator : IStateValidator<Option<TValue>>
		where TValueValidator : IValueValidator<TValue>
	{
		public DataDescriptor DataDescriptor => new DataDescriptor(typeof(TValue), _stateValidator.GetDescriptor(), CreateValueDescriptorArray(_valueValidator.GetDescriptor()));

		private readonly TStateValidator _stateValidator;

		private readonly TValueValidator _valueValidator;

		public NullableDataValidator(TStateValidator stateValidator, TValueValidator valueValidator)
		{
			_stateValidator = stateValidator;
			_valueValidator = valueValidator;
		}

		public Result<Option<TValue>, ValidationError[]> Validate(object model, bool isSet, Option<TValue> value)
		{
			if (_stateValidator.Validate(model, isSet, value).TryGetValue(out var success, out var failure))
			{
				if (!success.TryGetValue(out var some))
					return Result.Success<Option<TValue>, ValidationError[]>(success);

				if (!_valueValidator.IsValid(some))
					return Result.Failure<Option<TValue>, ValidationError[]>(new[] { _valueValidator.GetError(some, false) });

				return Model<TValue>
					.Verify(some)
					.Select(_ => success);
			}

			return Result.Failure<Option<TValue>, ValidationError[]>(failure);
		}

		private static IValueDescriptor[] CreateValueDescriptorArray(IValueDescriptor valueDescriptor)
			=> valueDescriptor != null ? new[] { valueDescriptor } : Array.Empty<IValueDescriptor>();
	}
}
