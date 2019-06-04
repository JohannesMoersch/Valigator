using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalNullableStateValidatorExtensions
	{
		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this OptionalNullableStateValidator<TValue> optionalValidator, string description, Func<TValue, bool> validator)
			=> new NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, CustomValidator<TValue>, TValue>(optionalValidator, new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> Precision(this OptionalNullableStateValidator<decimal> optionalValidator, decimal? minimumDecimalPlaces, decimal? maximumDecimalPlaces)
			=> new NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal>(optionalValidator, new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalNullableStateValidator<TValue> optionalValidator, params TValue[] options)
			=> new NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>(optionalValidator, new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalNullableStateValidator<TValue> optionalValidator, ISet<TValue> options)
			=> new NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>(optionalValidator, new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<string>, StringLengthValidator, string> Length(this OptionalNullableStateValidator<string> optionalValidator, int? minimumLength = null, int? maximumLength = null)
			=> new NullableDataSourceStandard<OptionalNullableStateValidator<string>, StringLengthValidator, string>(optionalValidator, new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this OptionalNullableStateValidator<byte> optionalValidator, byte value)
			=> new NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>(optionalValidator, new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this OptionalNullableStateValidator<byte> optionalValidator, byte value)
			=> new NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>(optionalValidator, new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this OptionalNullableStateValidator<byte> optionalValidator, byte value)
			=> new NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>(optionalValidator, new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this OptionalNullableStateValidator<byte> optionalValidator, byte value)
			=> new NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>(optionalValidator, new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> InRange(this OptionalNullableStateValidator<byte> optionalValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>(optionalValidator, new RangeValidator_Byte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));
		}
	}
}
