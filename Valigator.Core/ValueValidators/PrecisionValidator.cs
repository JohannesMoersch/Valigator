using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core.ValueValidators
{
	public struct PrecisionValidator : IValueValidator<decimal>
	{
		private readonly Option<decimal> _minimumDecimalPlaces;
		private readonly Option<decimal> _maximumDecimalPlaces;

		public PrecisionValidator(decimal? minimumDecimalPlaces, decimal? maximumDecimalPlaces)
		{
			_minimumDecimalPlaces = Option.FromNullable(minimumDecimalPlaces);
			_maximumDecimalPlaces = Option.FromNullable(maximumDecimalPlaces);
		}

		IValueDescriptor IValueValidator<decimal>.GetDescriptor()
			=> new PrecisionDescriptor(_minimumDecimalPlaces, _maximumDecimalPlaces);

		bool IValueValidator<decimal>.IsValid(decimal value)
		{
			var currentPrecision = GetPrecision(value);

			if (_minimumDecimalPlaces.TryGetValue(out var minimum) && currentPrecision < minimum)
				return false;

			if (_maximumDecimalPlaces.TryGetValue(out var maximum) && currentPrecision > maximum)
				return false;

			return true;
		}

		private int GetPrecision(decimal decimalValue)
			=> Math.Max((decimalValue - Math.Truncate(decimalValue)).ToString().Length - 2, 0);

		ValidationError IValueValidator<decimal>.GetError(decimal value, bool inverted)
			=> new ValidationError("");
	}
}
