using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredNullableStateValidatorExtensions
	{
		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this RequiredNullableStateValidator<TValue> requiredValidator, string description, Func<TValue, bool> validator)
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, CustomValidator<TValue>, TValue>(requiredValidator, new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> Precision(this RequiredNullableStateValidator<decimal> requiredValidator, decimal? minimumDecimalPlaces, decimal? maximumDecimalPlaces)
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal>(requiredValidator, new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredNullableStateValidator<TValue> requiredValidator, params TValue[] options)
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>(requiredValidator, new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredNullableStateValidator<TValue> requiredValidator, ISet<TValue> options)
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>(requiredValidator, new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<string>, StringLengthValidator, string> Length(this RequiredNullableStateValidator<string> requiredValidator, int? minimumLength = null, int? maximumLength = null)
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<string>, StringLengthValidator, string>(requiredValidator, new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this RequiredNullableStateValidator<byte> requiredValidator, byte value)
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this RequiredNullableStateValidator<byte> requiredValidator, byte value)
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this RequiredNullableStateValidator<byte> requiredValidator, byte value)
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this RequiredNullableStateValidator<byte> requiredValidator, byte value)
			=> new NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> InRange(this RequiredNullableStateValidator<byte> requiredValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));
		}
	}
}
