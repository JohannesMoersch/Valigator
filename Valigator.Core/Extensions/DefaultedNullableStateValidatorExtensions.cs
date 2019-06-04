using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedNullableStateValidatorExtensions
	{
		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DefaultedNullableStateValidator<TValue> defaultedValidator, string description, Func<TValue, bool> validator)
			=> new NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, CustomValidator<TValue>, TValue>(defaultedValidator, new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> Precision(this DefaultedNullableStateValidator<decimal> defaultedValidator, decimal? minimumDecimalPlaces, decimal? maximumDecimalPlaces)
			=> new NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal>(defaultedValidator, new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedNullableStateValidator<TValue> defaultedValidator, params TValue[] options)
			=> new NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>(defaultedValidator, new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedNullableStateValidator<TValue> defaultedValidator, ISet<TValue> options)
			=> new NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>(defaultedValidator, new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<string>, StringLengthValidator, string> Length(this DefaultedNullableStateValidator<string> defaultedValidator, int? minimumLength = null, int? maximumLength = null) 
			=> new NullableDataSourceStandard<DefaultedNullableStateValidator<string>, StringLengthValidator, string>(defaultedValidator, new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this DefaultedNullableStateValidator<byte> defaultedValidator, byte value)
			=> new NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this DefaultedNullableStateValidator<byte> defaultedValidator, byte value)
			=> new NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this DefaultedNullableStateValidator<byte> defaultedValidator, byte value)
			=> new NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<byte> defaultedValidator, byte value)
			=> new NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> InRange(this DefaultedNullableStateValidator<byte> defaultedValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
			=> new NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));
	}
}
