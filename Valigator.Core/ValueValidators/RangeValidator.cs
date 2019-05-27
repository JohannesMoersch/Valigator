using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.ValueValidators
{
	public struct RangeValidator_Byte<TStateValidator> : IValueValidator<byte>
		where TStateValidator : IDataSource<byte>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<byte> _lessThan;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<byte> _greaterThan;
		private readonly bool _greaterThanOrEqualTo;

		public Data<byte> Data => new Data<byte>(new DataValidator<TStateValidator, RangeValidator_Byte<TStateValidator>, byte>(_stateValidator, this));

		public RangeValidator_Byte(TStateValidator stateValidator, byte? lessThan, bool lessThanOrEqualTo, byte? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThan = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThan = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		public Result<Unit, ValidationError> Validate(byte value)
		{
			var lessThanOrEqualTo = _lessThanOrEqualTo;
			var greaterThan = _greaterThan;
			var greaterThanOrEqualTo = _greaterThanOrEqualTo;

			return _lessThan
				.Match
				(
					lt => Result.Create(lessThanOrEqualTo ? value <= lt : value < lt, () => Unit.Value, () => new ValidationError("Test")),
					() => Result.Unit<ValidationError>()
				)
				.Match
				(
					success => greaterThan
						.Match
						(
							gt => Result.Create(greaterThanOrEqualTo ? value >= gt : value > gt, () => Unit.Value, () => new ValidationError("Test")),
							() => Result.Unit<ValidationError>()
						),
					Result.Failure<Unit, ValidationError>
				);
		}

		public static implicit operator Data<byte>(RangeValidator_Byte<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_SByte<TStateValidator> : IValueValidator<sbyte>
		where TStateValidator : IDataSource<sbyte>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<sbyte> _lessThan;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<sbyte> _greaterThan;
		private readonly bool _greaterThanOrEqualTo;

		public Data<sbyte> Data => new Data<sbyte>(new DataValidator<TStateValidator, RangeValidator_SByte<TStateValidator>, sbyte>(_stateValidator, this));

		public RangeValidator_SByte(TStateValidator stateValidator, sbyte? lessThan, bool lessThanOrEqualTo, sbyte? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThan = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThan = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		public Result<Unit, ValidationError> Validate(sbyte value)
		{
			var lessThanOrEqualTo = _lessThanOrEqualTo;
			var greaterThan = _greaterThan;
			var greaterThanOrEqualTo = _greaterThanOrEqualTo;

			return _lessThan
				.Match
				(
					lt => Result.Create(lessThanOrEqualTo ? value <= lt : value < lt, () => Unit.Value, () => new ValidationError("Test")),
					() => Result.Unit<ValidationError>()
				)
				.Match
				(
					success => greaterThan
						.Match
						(
							gt => Result.Create(greaterThanOrEqualTo ? value >= gt : value > gt, () => Unit.Value, () => new ValidationError("Test")),
							() => Result.Unit<ValidationError>()
						),
					Result.Failure<Unit, ValidationError>
				);
		}

		public static implicit operator Data<sbyte>(RangeValidator_SByte<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_Int16<TStateValidator> : IValueValidator<short>
		where TStateValidator : IDataSource<short>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<short> _lessThan;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<short> _greaterThan;
		private readonly bool _greaterThanOrEqualTo;

		public Data<short> Data => new Data<short>(new DataValidator<TStateValidator, RangeValidator_Int16<TStateValidator>, short>(_stateValidator, this));

		public RangeValidator_Int16(TStateValidator stateValidator, short? lessThan, bool lessThanOrEqualTo, short? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThan = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThan = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		public Result<Unit, ValidationError> Validate(short value)
		{
			var lessThanOrEqualTo = _lessThanOrEqualTo;
			var greaterThan = _greaterThan;
			var greaterThanOrEqualTo = _greaterThanOrEqualTo;

			return _lessThan
				.Match
				(
					lt => Result.Create(lessThanOrEqualTo ? value <= lt : value < lt, () => Unit.Value, () => new ValidationError("Test")),
					() => Result.Unit<ValidationError>()
				)
				.Match
				(
					success => greaterThan
						.Match
						(
							gt => Result.Create(greaterThanOrEqualTo ? value >= gt : value > gt, () => Unit.Value, () => new ValidationError("Test")),
							() => Result.Unit<ValidationError>()
						),
					Result.Failure<Unit, ValidationError>
				);
		}

		public static implicit operator Data<short>(RangeValidator_Int16<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_UInt16<TStateValidator> : IValueValidator<ushort>
		where TStateValidator : IDataSource<ushort>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<ushort> _lessThan;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<ushort> _greaterThan;
		private readonly bool _greaterThanOrEqualTo;

		public Data<ushort> Data => new Data<ushort>(new DataValidator<TStateValidator, RangeValidator_UInt16<TStateValidator>, ushort>(_stateValidator, this));

		public RangeValidator_UInt16(TStateValidator stateValidator, ushort? lessThan, bool lessThanOrEqualTo, ushort? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThan = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThan = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		public Result<Unit, ValidationError> Validate(ushort value)
		{
			var lessThanOrEqualTo = _lessThanOrEqualTo;
			var greaterThan = _greaterThan;
			var greaterThanOrEqualTo = _greaterThanOrEqualTo;

			return _lessThan
				.Match
				(
					lt => Result.Create(lessThanOrEqualTo ? value <= lt : value < lt, () => Unit.Value, () => new ValidationError("Test")),
					() => Result.Unit<ValidationError>()
				)
				.Match
				(
					success => greaterThan
						.Match
						(
							gt => Result.Create(greaterThanOrEqualTo ? value >= gt : value > gt, () => Unit.Value, () => new ValidationError("Test")),
							() => Result.Unit<ValidationError>()
						),
					Result.Failure<Unit, ValidationError>
				);
		}

		public static implicit operator Data<ushort>(RangeValidator_UInt16<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_Int32<TStateValidator> : IValueValidator<int>
		where TStateValidator : IDataSource<int>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<int> _lessThan;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<int> _greaterThan;
		private readonly bool _greaterThanOrEqualTo;

		public Data<int> Data => new Data<int>(new DataValidator<TStateValidator, RangeValidator_Int32<TStateValidator>, int>(_stateValidator, this));

		public RangeValidator_Int32(TStateValidator stateValidator, int? lessThan, bool lessThanOrEqualTo, int? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThan = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThan = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		public Result<Unit, ValidationError> Validate(int value)
		{
			var lessThanOrEqualTo = _lessThanOrEqualTo;
			var greaterThan = _greaterThan;
			var greaterThanOrEqualTo = _greaterThanOrEqualTo;

			return _lessThan
				.Match
				(
					lt => Result.Create(lessThanOrEqualTo ? value <= lt : value < lt, () => Unit.Value, () => new ValidationError("Test")),
					() => Result.Unit<ValidationError>()
				)
				.Match
				(
					success => greaterThan
						.Match
						(
							gt => Result.Create(greaterThanOrEqualTo ? value >= gt : value > gt, () => Unit.Value, () => new ValidationError("Test")),
							() => Result.Unit<ValidationError>()
						),
					Result.Failure<Unit, ValidationError>
				);
		}

		public static implicit operator Data<int>(RangeValidator_Int32<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_UInt32<TStateValidator> : IValueValidator<uint>
		where TStateValidator : IDataSource<uint>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<uint> _lessThan;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<uint> _greaterThan;
		private readonly bool _greaterThanOrEqualTo;

		public Data<uint> Data => new Data<uint>(new DataValidator<TStateValidator, RangeValidator_UInt32<TStateValidator>, uint>(_stateValidator, this));

		public RangeValidator_UInt32(TStateValidator stateValidator, uint? lessThan, bool lessThanOrEqualTo, uint? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThan = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThan = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		public Result<Unit, ValidationError> Validate(uint value)
		{
			var lessThanOrEqualTo = _lessThanOrEqualTo;
			var greaterThan = _greaterThan;
			var greaterThanOrEqualTo = _greaterThanOrEqualTo;

			return _lessThan
				.Match
				(
					lt => Result.Create(lessThanOrEqualTo ? value <= lt : value < lt, () => Unit.Value, () => new ValidationError("Test")),
					() => Result.Unit<ValidationError>()
				)
				.Match
				(
					success => greaterThan
						.Match
						(
							gt => Result.Create(greaterThanOrEqualTo ? value >= gt : value > gt, () => Unit.Value, () => new ValidationError("Test")),
							() => Result.Unit<ValidationError>()
						),
					Result.Failure<Unit, ValidationError>
				);
		}

		public static implicit operator Data<uint>(RangeValidator_UInt32<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_Int64<TStateValidator> : IValueValidator<long>
		where TStateValidator : IDataSource<long>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<long> _lessThan;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<long> _greaterThan;
		private readonly bool _greaterThanOrEqualTo;

		public Data<long> Data => new Data<long>(new DataValidator<TStateValidator, RangeValidator_Int64<TStateValidator>, long>(_stateValidator, this));

		public RangeValidator_Int64(TStateValidator stateValidator, long? lessThan, bool lessThanOrEqualTo, long? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThan = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThan = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		public Result<Unit, ValidationError> Validate(long value)
		{
			var lessThanOrEqualTo = _lessThanOrEqualTo;
			var greaterThan = _greaterThan;
			var greaterThanOrEqualTo = _greaterThanOrEqualTo;

			return _lessThan
				.Match
				(
					lt => Result.Create(lessThanOrEqualTo ? value <= lt : value < lt, () => Unit.Value, () => new ValidationError("Test")),
					() => Result.Unit<ValidationError>()
				)
				.Match
				(
					success => greaterThan
						.Match
						(
							gt => Result.Create(greaterThanOrEqualTo ? value >= gt : value > gt, () => Unit.Value, () => new ValidationError("Test")),
							() => Result.Unit<ValidationError>()
						),
					Result.Failure<Unit, ValidationError>
				);
		}

		public static implicit operator Data<long>(RangeValidator_Int64<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}

	public struct RangeValidator_UInt64<TStateValidator> : IValueValidator<ulong>
		where TStateValidator : IDataSource<ulong>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<ulong> _lessThan;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<ulong> _greaterThan;
		private readonly bool _greaterThanOrEqualTo;

		public Data<ulong> Data => new Data<ulong>(new DataValidator<TStateValidator, RangeValidator_UInt64<TStateValidator>, ulong>(_stateValidator, this));

		public RangeValidator_UInt64(TStateValidator stateValidator, ulong? lessThan, bool lessThanOrEqualTo, ulong? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThan = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThan = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		public Result<Unit, ValidationError> Validate(ulong value)
		{
			var lessThanOrEqualTo = _lessThanOrEqualTo;
			var greaterThan = _greaterThan;
			var greaterThanOrEqualTo = _greaterThanOrEqualTo;

			return _lessThan
				.Match
				(
					lt => Result.Create(lessThanOrEqualTo ? value <= lt : value < lt, () => Unit.Value, () => new ValidationError("Test")),
					() => Result.Unit<ValidationError>()
				)
				.Match
				(
					success => greaterThan
						.Match
						(
							gt => Result.Create(greaterThanOrEqualTo ? value >= gt : value > gt, () => Unit.Value, () => new ValidationError("Test")),
							() => Result.Unit<ValidationError>()
						),
					Result.Failure<Unit, ValidationError>
				);
		}

		public static implicit operator Data<ulong>(RangeValidator_UInt64<TStateValidator> valueValidator)
			=> valueValidator.Data;
	}
}
