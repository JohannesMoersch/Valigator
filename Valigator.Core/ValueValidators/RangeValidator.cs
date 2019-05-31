using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;
using Valigator.Core.Helpers;

namespace Valigator.Core.ValueValidators
{
	public struct RangeValidator_Byte : IValueValidator<byte>
	{
		private readonly Option<byte> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<byte> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Byte(byte? lessThan, bool lessThanOrEqualTo, byte? greaterThan, bool greaterThanOrEqualTo)
		{
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
	}

	public struct RangeValidator_SByte : IValueValidator<sbyte>
	{
		private readonly Option<sbyte> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<sbyte> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_SByte(sbyte? lessThan, bool lessThanOrEqualTo, sbyte? greaterThan, bool greaterThanOrEqualTo)
		{
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
	}

	public struct RangeValidator_Int16 : IValueValidator<short>
	{
		private readonly Option<short> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<short> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Int16(short? lessThan, bool lessThanOrEqualTo, short? greaterThan, bool greaterThanOrEqualTo)
		{
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
	}

	public struct RangeValidator_UInt16 : IValueValidator<ushort>
	{
		private readonly Option<ushort> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<ushort> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_UInt16(ushort? lessThan, bool lessThanOrEqualTo, ushort? greaterThan, bool greaterThanOrEqualTo)
		{
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
	}

	public struct RangeValidator_Int32 : IValueValidator<int>
	{
		private readonly Option<int> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<int> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Int32(int? lessThan, bool lessThanOrEqualTo, int? greaterThan, bool greaterThanOrEqualTo)
		{
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
	}

	public struct RangeValidator_UInt32 : IValueValidator<uint>
	{
		private readonly Option<uint> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<uint> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_UInt32(uint? lessThan, bool lessThanOrEqualTo, uint? greaterThan, bool greaterThanOrEqualTo)
		{
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
	}

	public struct RangeValidator_Int64 : IValueValidator<long>
	{
		private readonly Option<long> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<long> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Int64(long? lessThan, bool lessThanOrEqualTo, long? greaterThan, bool greaterThanOrEqualTo)
		{
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
	}

	public struct RangeValidator_UInt64 : IValueValidator<ulong>
	{
		private readonly Option<ulong> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<ulong> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_UInt64(ulong? lessThan, bool lessThanOrEqualTo, ulong? greaterThan, bool greaterThanOrEqualTo)
		{
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
	}

	public struct RangeValidator_Single : IValueValidator<float>
	{
		private readonly Option<float> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<float> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Single(float? lessThan, bool lessThanOrEqualTo, float? greaterThan, bool greaterThanOrEqualTo)
		{
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
	}

	public struct RangeValidator_Double : IValueValidator<double>
	{
		private readonly Option<double> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<double> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Double(double? lessThan, bool lessThanOrEqualTo, double? greaterThan, bool greaterThanOrEqualTo)
		{
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
	}

	public struct RangeValidator_Decimal : IValueValidator<decimal>
	{
		private readonly Option<decimal> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<decimal> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Decimal(decimal? lessThan, bool lessThanOrEqualTo, decimal? greaterThan, bool greaterThanOrEqualTo)
		{
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
	}

	public struct RangeValidator_DateTime : IValueValidator<DateTime>
	{
		private readonly Option<DateTime> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<DateTime> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_DateTime(DateTime? lessThan, bool lessThanOrEqualTo, DateTime? greaterThan, bool greaterThanOrEqualTo)
		{
			_lessThanValue = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThanValue = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		IEnumerable<IValueDescriptor> IValueValidator<DateTime>.GetDescriptors()
			=> new[] { new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo) };

		public Result<Unit, ValidationError> Validate(DateTime value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return Result.Failure<Unit, ValidationError>(GetValidationError(value));

			return Result.Unit<ValidationError>();
		}

		private ValidationError GetValidationError(DateTime value)
			=> new ValidationError("");
	}
}
