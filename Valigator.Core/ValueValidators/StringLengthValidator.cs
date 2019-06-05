using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core.ValueValidators
{
	public struct StringLengthValidator : IValueValidator<string>
	{
		private readonly Option<int> _minimumLength;
		private readonly Option<int> _maximumLength;

		public StringLengthValidator(int? minimumLength, int? maximumLength)
		{
			if (!minimumLength.HasValue && !maximumLength.HasValue)
				throw new ArgumentException("Either a minimum or a maximum length must be set.");

			if (minimumLength < 0)
				throw new ArgumentException("Minimum cannot be less than zero.");

			if (maximumLength < 1)
				throw new ArgumentException("Maximum cannot be less than one.");

			if (maximumLength < minimumLength)
				throw new ArgumentException("Maximum cannot be less than minimum.");

			_minimumLength = Option.FromNullable(minimumLength);
			_maximumLength = Option.FromNullable(maximumLength);
		}

		IValueDescriptor IValueValidator<string>.GetDescriptor()
			=> new StringLengthDescriptor(_minimumLength, _maximumLength);

		bool IValueValidator<string>.IsValid(string value)
		{
			if (_minimumLength.TryGetValue(out var minimum) && value.Length < minimum)
				return false;

			if (_maximumLength.TryGetValue(out var maximum) && value.Length > maximum)
				return false;

			return true;
		}

		ValidationError IValueValidator<string>.GetError(string value, bool inverted)
			=> new ValidationError(nameof(StringLengthValidator));
	}
}
