using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredStateValidatorExtensions
	{
		public static DataSourceStandard<RequiredStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this RequiredStateValidator<TValue> requiredValidator, string description, Func<TValue, bool> validator)
			=> new DataSourceStandard<RequiredStateValidator<TValue>, CustomValidator<TValue>, TValue>(requiredValidator, new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal> Precision(this RequiredStateValidator<decimal> requiredValidator, decimal? minimumDecimalPlaces, decimal? maximumDecimalPlaces)
			=> new DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal>(requiredValidator, new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValue> Equals<TValue>(this RequiredStateValidator<TValue> requiredValidator, TValue value)
			=> new DataSourceStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValue>(requiredValidator, new EqualsValidator<TValue>(value));

		public static DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredStateValidator<TValue> requiredValidator, params TValue[] options)
			=> new DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue>(requiredValidator, new InSetValidator<TValue>(options));

		public static DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredStateValidator<TValue> requiredValidator, ISet<TValue> options)
			=> new DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue>(requiredValidator, new InSetValidator<TValue>(options));

		public static DataSourceStandard<RequiredStateValidator<string>, StringLengthValidator, string> Length(this RequiredStateValidator<string> requiredValidator, int? minimumLength = null, int? maximumLength = null)
			=> new DataSourceStandard<RequiredStateValidator<string>, StringLengthValidator, string>(requiredValidator, new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceInverted<RequiredStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this RequiredStateValidator<string> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<string>, EqualsValidator<string>, string>(requiredValidator, new EqualsValidator<string>(String.Empty));

		public static DataSourceInverted<RequiredStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this RequiredStateValidator<Guid> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<Guid>, EqualsValidator<Guid>, Guid>(requiredValidator, new EqualsValidator<Guid>(Guid.Empty));

		public static DataSourceInverted<RequiredStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this RequiredStateValidator<byte> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<byte>, EqualsValidator<byte>, byte>(requiredValidator, new EqualsValidator<byte>(0));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> InRange(this RequiredStateValidator<byte> requiredValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));
		}
	}
}
