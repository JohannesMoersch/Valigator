using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Core
{
	public static class ValueValidatorSet
	{
		public static ValueValidatorSet<TValue> Empty<TValue>()
			=> ValueValidatorSet<TValue>.Empty;
	}

	public class ValueValidatorSet<TValue> : IValidatorSet<ValueValidatorSet<TValue>, TValue, TValue>
	{
		internal static ValueValidatorSet<TValue> Empty { get; } = new ValueValidatorSet<TValue>(Enumerable.Empty<IValidator<TValue>>());

		public IValidatorDescriptor Descriptor => throw new NotImplementedException();

		private readonly IReadOnlyList<IValidator<TValue>> _Validators;

		public ValueValidatorSet(IEnumerable<IValidator<TValue>> validators)
			=> _Validators = validators.ToArray();

		public ValueValidatorSet<TValue> AddValidator(IValidator<TValue> value)
			=> new ValueValidatorSet<TValue>(_Validators.Append(value));
		public Result<Unit, ValidationError[]> Validate(TValue value) => throw new NotImplementedException();
	}
}
