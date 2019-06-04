using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedStateValidatorExtensions
	{
		public static DataSourceStandard<DefaultedStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DefaultedStateValidator<TValue> defaultedValidator, string description, Func<TValue, bool> validator)
			=> new DataSourceStandard<DefaultedStateValidator<TValue>, CustomValidator<TValue>, TValue>(defaultedValidator, new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> Precision(this DefaultedStateValidator<decimal> defaultedValidator, decimal? minimumDecimalPlaces, decimal? maximumDecimalPlaces)
			=> new DataSourceStandard<DefaultedStateValidator<decimal>, PrecisionValidator, decimal>(defaultedValidator, new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedStateValidator<TValue> defaultedValidator, params TValue[] options)
			=> new DataSourceStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue>(defaultedValidator, new InSetValidator<TValue>(options));

		public static DataSourceStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedStateValidator<TValue> defaultedValidator, ISet<TValue> options)
			=> new DataSourceStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue>(defaultedValidator, new InSetValidator<TValue>(options));

		public static DataSourceStandard<DefaultedStateValidator<string>, StringLengthValidator, string> Length(this DefaultedStateValidator<string> defaultedValidator, int? minimumLength = null, int? maximumLength = null)
			=> new DataSourceStandard<DefaultedStateValidator<string>, StringLengthValidator, string>(defaultedValidator, new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this DefaultedStateValidator<byte> defaultedValidator, byte value)
			=> new DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this DefaultedStateValidator<byte> defaultedValidator, byte value)
			=> new DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this DefaultedStateValidator<byte> defaultedValidator, byte value)
			=> new DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this DefaultedStateValidator<byte> defaultedValidator, byte value)
			=> new DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> InRange(this DefaultedStateValidator<byte> defaultedValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));
		}
	}
}