using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Validators
{
	public class CollectionCountValidator<TValue> : IInvertableValidator<IReadOnlyCollection<TValue>>
	{
		private readonly int _minimumCount;

		private readonly int _maximumCount;

		public CollectionCountValidator(int minimumCount, int maximumCount)
		{
			_minimumCount = minimumCount;
			_maximumCount = maximumCount;
		}

		public Result<Unit, ValidationError[]> Validate(IReadOnlyCollection<TValue> value)
			=> MeetsCondition(value)
				? Result.Unit<ValidationError[]>()
				: Result.Failure<Unit, ValidationError[]>(new[] { new ValidationError($"Count must be between {_minimumCount} and {_maximumCount}.") });

		public Result<Unit, ValidationError[]> InverseValidate(IReadOnlyCollection<TValue> value)
			=> MeetsCondition(value)
				? Result.Failure<Unit, ValidationError[]>(new[] { new ValidationError($"Count must not be between {_minimumCount} and {_maximumCount}.") })
				: Result.Unit<ValidationError[]>();

		private bool MeetsCondition(IReadOnlyCollection<TValue> value)
			=> value.Count >= _minimumCount && value.Count <= _maximumCount;
	}
}
