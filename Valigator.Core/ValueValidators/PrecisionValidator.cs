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

		bool IValueValidator<decimal>.RequiresModel => false;

		public PrecisionValidator(decimal? minimumDecimalPlaces, decimal? maximumDecimalPlaces)
		{
			if (!minimumDecimalPlaces.HasValue && !maximumDecimalPlaces.HasValue)
				throw new ArgumentException("Either a minimum or a maximum precision must be set.");

			if (minimumDecimalPlaces < 0)
				throw new ArgumentException("Minimum cannot be less than zero.");

			if (maximumDecimalPlaces < 1)
				throw new ArgumentException("Maximum cannot be less than one.");

			if (maximumDecimalPlaces < minimumDecimalPlaces)
				throw new ArgumentException("Maximum cannot be less than minimum.");


			_minimumDecimalPlaces = Option.FromNullable(minimumDecimalPlaces);
			_maximumDecimalPlaces = Option.FromNullable(maximumDecimalPlaces);
		}

		IValueDescriptor IValueValidator<decimal>.GetDescriptor()
			=> new PrecisionDescriptor(_minimumDecimalPlaces, _maximumDecimalPlaces);

		bool IValueValidator<decimal>.IsValid(Option<object> model, decimal value)
		{
			var currentPrecision = GetPrecision(value);

			if (_minimumDecimalPlaces.TryGetValue(out var minimum) && currentPrecision < minimum)
				return false;

			if (_maximumDecimalPlaces.TryGetValue(out var maximum) && currentPrecision > maximum)
				return false;

			return true;
		}

		private int GetPrecision(decimal decimalValue)
			=> Math.Max(Math.Abs((decimalValue - Math.Truncate(decimalValue))).ToString().Length - 2, 0);

		ValidationError IValueValidator<decimal>.GetError(decimal value, bool inverted)
			=> new ValidationError(nameof(PrecisionValidator), (this as IValueValidator<decimal>).GetDescriptor());
	}
}
