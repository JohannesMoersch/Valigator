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

		IValueDescriptor IValueValidator<byte>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<byte>.IsValid(byte value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return false;

			return true;
		}

		ValidationError IValueValidator<byte>.GetError(byte value, bool inverted)
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

		IValueDescriptor IValueValidator<sbyte>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<sbyte>.IsValid(sbyte value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return false;

			return true;
		}

		ValidationError IValueValidator<sbyte>.GetError(sbyte value, bool inverted)
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

		IValueDescriptor IValueValidator<short>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<short>.IsValid(short value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return false;

			return true;
		}

		ValidationError IValueValidator<short>.GetError(short value, bool inverted)
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

		IValueDescriptor IValueValidator<ushort>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<ushort>.IsValid(ushort value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return false;

			return true;
		}

		ValidationError IValueValidator<ushort>.GetError(ushort value, bool inverted)
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

		IValueDescriptor IValueValidator<int>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<int>.IsValid(int value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return false;

			return true;
		}

		ValidationError IValueValidator<int>.GetError(int value, bool inverted)
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

		IValueDescriptor IValueValidator<uint>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<uint>.IsValid(uint value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return false;

			return true;
		}

		ValidationError IValueValidator<uint>.GetError(uint value, bool inverted)
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

		IValueDescriptor IValueValidator<long>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<long>.IsValid(long value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return false;

			return true;
		}

		ValidationError IValueValidator<long>.GetError(long value, bool inverted)
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

		IValueDescriptor IValueValidator<ulong>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<ulong>.IsValid(ulong value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return false;

			return true;
		}

		ValidationError IValueValidator<ulong>.GetError(ulong value, bool inverted)
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

		IValueDescriptor IValueValidator<float>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<float>.IsValid(float value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return false;

			return true;
		}

		ValidationError IValueValidator<float>.GetError(float value, bool inverted)
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

		IValueDescriptor IValueValidator<double>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<double>.IsValid(double value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return false;

			return true;
		}

		ValidationError IValueValidator<double>.GetError(double value, bool inverted)
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

		IValueDescriptor IValueValidator<decimal>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<decimal>.IsValid(decimal value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return false;

			return true;
		}

		ValidationError IValueValidator<decimal>.GetError(decimal value, bool inverted)
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

		IValueDescriptor IValueValidator<DateTime>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<DateTime>.IsValid(DateTime value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && _lessThanOrEqualTo ? value > lessThan : value >= lessThan)
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && _greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan)
				return false;

			return true;
		}

		ValidationError IValueValidator<DateTime>.GetError(DateTime value, bool inverted)
			=> new ValidationError("");
	}
}
