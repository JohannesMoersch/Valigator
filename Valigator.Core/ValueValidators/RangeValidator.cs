using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;
using Valigator.Core.Helpers;

namespace Valigator.Core.ValueValidators
{
	public struct RangeValidator_Byte<TStateValidator> : IValueValidator<byte>
		where TStateValidator : IStateValidator<byte>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<byte> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<byte> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public Data<byte> Data => new Data<byte>(new DataValidator<TStateValidator, RangeValidator_Byte<TStateValidator>, byte>(_stateValidator, this));

		public RangeValidator_Byte(TStateValidator stateValidator, byte? lessThan, bool lessThanOrEqualTo, byte? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThanValue = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThanValue = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		IEnumerable<IValueDescriptor> IValueValidator<byte>.GetDescriptors()
			=> new[] { new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo) };

		public Result<Unit, ValidationError> Validate(byte value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			return Result.Unit<ValidationError>();
		}

		private ValidationError GetValidationError(byte value)
			=> new ValidationError("");

		public static implicit operator Data<byte>(RangeValidator_Byte<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_SByte<TStateValidator> : IValueValidator<sbyte>
		where TStateValidator : IStateValidator<sbyte>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<sbyte> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<sbyte> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public Data<sbyte> Data => new Data<sbyte>(new DataValidator<TStateValidator, RangeValidator_SByte<TStateValidator>, sbyte>(_stateValidator, this));

		public RangeValidator_SByte(TStateValidator stateValidator, sbyte? lessThan, bool lessThanOrEqualTo, sbyte? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThanValue = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThanValue = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		IEnumerable<IValueDescriptor> IValueValidator<sbyte>.GetDescriptors()
			=> new[] { new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo) };

		public Result<Unit, ValidationError> Validate(sbyte value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			return Result.Unit<ValidationError>();
		}

		private ValidationError GetValidationError(sbyte value)
			=> new ValidationError("");

		public static implicit operator Data<sbyte>(RangeValidator_SByte<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_Int16<TStateValidator> : IValueValidator<short>
		where TStateValidator : IStateValidator<short>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<short> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<short> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public Data<short> Data => new Data<short>(new DataValidator<TStateValidator, RangeValidator_Int16<TStateValidator>, short>(_stateValidator, this));

		public RangeValidator_Int16(TStateValidator stateValidator, short? lessThan, bool lessThanOrEqualTo, short? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThanValue = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThanValue = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		IEnumerable<IValueDescriptor> IValueValidator<short>.GetDescriptors()
			=> new[] { new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo) };

		public Result<Unit, ValidationError> Validate(short value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			return Result.Unit<ValidationError>();
		}

		private ValidationError GetValidationError(short value)
			=> new ValidationError("");

		public static implicit operator Data<short>(RangeValidator_Int16<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_UInt16<TStateValidator> : IValueValidator<ushort>
		where TStateValidator : IStateValidator<ushort>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<ushort> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<ushort> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public Data<ushort> Data => new Data<ushort>(new DataValidator<TStateValidator, RangeValidator_UInt16<TStateValidator>, ushort>(_stateValidator, this));

		public RangeValidator_UInt16(TStateValidator stateValidator, ushort? lessThan, bool lessThanOrEqualTo, ushort? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThanValue = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThanValue = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		IEnumerable<IValueDescriptor> IValueValidator<ushort>.GetDescriptors()
			=> new[] { new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo) };

		public Result<Unit, ValidationError> Validate(ushort value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			return Result.Unit<ValidationError>();
		}

		private ValidationError GetValidationError(ushort value)
			=> new ValidationError("");

		public static implicit operator Data<ushort>(RangeValidator_UInt16<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_Int32<TStateValidator> : IValueValidator<int>
		where TStateValidator : IStateValidator<int>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<int> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<int> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public Data<int> Data => new Data<int>(new DataValidator<TStateValidator, RangeValidator_Int32<TStateValidator>, int>(_stateValidator, this));

		public RangeValidator_Int32(TStateValidator stateValidator, int? lessThan, bool lessThanOrEqualTo, int? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThanValue = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThanValue = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		IEnumerable<IValueDescriptor> IValueValidator<int>.GetDescriptors()
			=> new[] { new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo) };

		public Result<Unit, ValidationError> Validate(int value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			return Result.Unit<ValidationError>();
		}

		private ValidationError GetValidationError(int value)
			=> new ValidationError("");

		public static implicit operator Data<int>(RangeValidator_Int32<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_UInt32<TStateValidator> : IValueValidator<uint>
		where TStateValidator : IStateValidator<uint>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<uint> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<uint> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public Data<uint> Data => new Data<uint>(new DataValidator<TStateValidator, RangeValidator_UInt32<TStateValidator>, uint>(_stateValidator, this));

		public RangeValidator_UInt32(TStateValidator stateValidator, uint? lessThan, bool lessThanOrEqualTo, uint? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThanValue = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThanValue = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		IEnumerable<IValueDescriptor> IValueValidator<uint>.GetDescriptors()
			=> new[] { new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo) };

		public Result<Unit, ValidationError> Validate(uint value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			return Result.Unit<ValidationError>();
		}

		private ValidationError GetValidationError(uint value)
			=> new ValidationError("");

		public static implicit operator Data<uint>(RangeValidator_UInt32<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_Int64<TStateValidator> : IValueValidator<long>
		where TStateValidator : IStateValidator<long>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<long> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<long> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public Data<long> Data => new Data<long>(new DataValidator<TStateValidator, RangeValidator_Int64<TStateValidator>, long>(_stateValidator, this));

		public RangeValidator_Int64(TStateValidator stateValidator, long? lessThan, bool lessThanOrEqualTo, long? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThanValue = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThanValue = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		IEnumerable<IValueDescriptor> IValueValidator<long>.GetDescriptors()
			=> new[] { new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo) };

		public Result<Unit, ValidationError> Validate(long value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			return Result.Unit<ValidationError>();
		}

		private ValidationError GetValidationError(long value)
			=> new ValidationError("");

		public static implicit operator Data<long>(RangeValidator_Int64<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_UInt64<TStateValidator> : IValueValidator<ulong>
		where TStateValidator : IStateValidator<ulong>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<ulong> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<ulong> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public Data<ulong> Data => new Data<ulong>(new DataValidator<TStateValidator, RangeValidator_UInt64<TStateValidator>, ulong>(_stateValidator, this));

		public RangeValidator_UInt64(TStateValidator stateValidator, ulong? lessThan, bool lessThanOrEqualTo, ulong? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThanValue = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThanValue = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		IEnumerable<IValueDescriptor> IValueValidator<ulong>.GetDescriptors()
			=> new[] { new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo) };

		public Result<Unit, ValidationError> Validate(ulong value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			return Result.Unit<ValidationError>();
		}

		private ValidationError GetValidationError(ulong value)
			=> new ValidationError("");

		public static implicit operator Data<ulong>(RangeValidator_UInt64<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_Single<TStateValidator> : IValueValidator<float>
		where TStateValidator : IStateValidator<float>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<float> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<float> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public Data<float> Data => new Data<float>(new DataValidator<TStateValidator, RangeValidator_Single<TStateValidator>, float>(_stateValidator, this));

		public RangeValidator_Single(TStateValidator stateValidator, float? lessThan, bool lessThanOrEqualTo, float? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThanValue = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThanValue = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		IEnumerable<IValueDescriptor> IValueValidator<float>.GetDescriptors()
			=> new[] { new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo) };

		public Result<Unit, ValidationError> Validate(float value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			return Result.Unit<ValidationError>();
		}

		private ValidationError GetValidationError(float value)
			=> new ValidationError("");

		public static implicit operator Data<float>(RangeValidator_Single<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_Double<TStateValidator> : IValueValidator<double>
		where TStateValidator : IStateValidator<double>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<double> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<double> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public Data<double> Data => new Data<double>(new DataValidator<TStateValidator, RangeValidator_Double<TStateValidator>, double>(_stateValidator, this));

		public RangeValidator_Double(TStateValidator stateValidator, double? lessThan, bool lessThanOrEqualTo, double? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThanValue = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThanValue = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		IEnumerable<IValueDescriptor> IValueValidator<double>.GetDescriptors()
			=> new[] { new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo) };

		public Result<Unit, ValidationError> Validate(double value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			return Result.Unit<ValidationError>();
		}

		private ValidationError GetValidationError(double value)
			=> new ValidationError("");

		public static implicit operator Data<double>(RangeValidator_Double<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_Decimal<TStateValidator> : IValueValidator<decimal>
		where TStateValidator : IStateValidator<decimal>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<decimal> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<decimal> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public Data<decimal> Data => new Data<decimal>(new DataValidator<TStateValidator, RangeValidator_Decimal<TStateValidator>, decimal>(_stateValidator, this));

		public RangeValidator_Decimal(TStateValidator stateValidator, decimal? lessThan, bool lessThanOrEqualTo, decimal? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThanValue = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThanValue = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		IEnumerable<IValueDescriptor> IValueValidator<decimal>.GetDescriptors()
			=> new[] { new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo) };

		public Result<Unit, ValidationError> Validate(decimal value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			return Result.Unit<ValidationError>();
		}

		private ValidationError GetValidationError(decimal value)
			=> new ValidationError("");

		public static implicit operator Data<decimal>(RangeValidator_Decimal<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}
}
