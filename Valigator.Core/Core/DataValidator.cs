using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public class DataValidator<TStateValidator, TValueValidator, TValue> : IDataValidator<TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidator : IValueValidator<TValue>
	{
		public DataDescriptor DataDescriptor => new DataDescriptor(typeof(TValue), _stateValidator.GetDescriptor(), CreateValueDescriptorArray(_valueValidator.GetDescriptor()));

		private readonly TStateValidator _stateValidator;

		private readonly TValueValidator _valueValidator;

		public DataValidator(TStateValidator stateValidator, TValueValidator valueValidator)
		{
			_stateValidator = stateValidator;
			_valueValidator = valueValidator;
		}

		public Result<TValue, ValidationError[]> Validate(object model, bool isSet, TValue value)
		{
			if (_stateValidator.Validate(model, isSet, value).TryGetValue(out var success, out var failure))
			{
				if (!_valueValidator.IsValid(success))
					return Result.Failure<TValue, ValidationError[]>(new[] { _valueValidator.GetError(success, false) });

				return Model<TValue>
					.Verify(success)
					.Select(_ => success);
			}

			return Result.Failure<TValue, ValidationError[]>(failure);
		}

		private static IValueDescriptor[] CreateValueDescriptorArray(IValueDescriptor valueDescriptor)
			=> valueDescriptor != null ? new[] { valueDescriptor } : Array.Empty<IValueDescriptor>();
	}
}
