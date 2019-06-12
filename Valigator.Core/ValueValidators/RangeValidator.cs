using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core.ValueValidators
{
	public struct RangeValidator_Byte : IValueValidator<byte>
	{
		private readonly Option<byte> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<byte> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Byte(byte? greaterThan, byte? greaterThanOrEqualTo, byte? lessThan, byte? lessThanOrEqualTo)
		{
			if (!(lessThan ?? lessThanOrEqualTo).HasValue && !(greaterThan ?? greaterThanOrEqualTo).HasValue)
				throw new ArgumentException("Either a minimum or maximum value must be set.");

			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			_lessThanValue = Option.FromNullable(lessThan ?? lessThanOrEqualTo);
			_lessThanOrEqualTo = lessThanOrEqualTo.HasValue;
			_greaterThanValue = Option.FromNullable(greaterThan ?? greaterThanOrEqualTo);
			_greaterThanOrEqualTo = greaterThanOrEqualTo.HasValue;
		}

		IValueDescriptor IValueValidator<byte>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<byte>.IsValid(byte value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && (_lessThanOrEqualTo ? value > lessThan : value >= lessThan))
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && (_greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan))
				return false;

			return true;
		}

		ValidationError IValueValidator<byte>.GetError(byte value, bool inverted)
			=> new ValidationError(nameof(RangeValidator_Byte), (this as IValueValidator<byte>).GetDescriptor());
	}

	public struct RangeValidator_SByte : IValueValidator<sbyte>
	{
		private readonly Option<sbyte> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<sbyte> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_SByte(sbyte? greaterThan, sbyte? greaterThanOrEqualTo, sbyte? lessThan, sbyte? lessThanOrEqualTo)
		{
			if (!(lessThan ?? lessThanOrEqualTo).HasValue && !(greaterThan ?? greaterThanOrEqualTo).HasValue)
				throw new ArgumentException("Either a minimum or maximum value must be set.");

			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			_lessThanValue = Option.FromNullable(lessThan ?? lessThanOrEqualTo);
			_lessThanOrEqualTo = lessThanOrEqualTo.HasValue;
			_greaterThanValue = Option.FromNullable(greaterThan ?? greaterThanOrEqualTo);
			_greaterThanOrEqualTo = greaterThanOrEqualTo.HasValue;
		}

		IValueDescriptor IValueValidator<sbyte>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<sbyte>.IsValid(sbyte value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && (_lessThanOrEqualTo ? value > lessThan : value >= lessThan))
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && (_greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan))
				return false;

			return true;
		}

		ValidationError IValueValidator<sbyte>.GetError(sbyte value, bool inverted)
			=> new ValidationError(nameof(RangeValidator_SByte), (this as IValueValidator<sbyte>).GetDescriptor());
	}

	public struct RangeValidator_Int16 : IValueValidator<short>
	{
		private readonly Option<short> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<short> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Int16(short? greaterThan, short? greaterThanOrEqualTo, short? lessThan, short? lessThanOrEqualTo)
		{
			if (!(lessThan ?? lessThanOrEqualTo).HasValue && !(greaterThan ?? greaterThanOrEqualTo).HasValue)
				throw new ArgumentException("Either a minimum or maximum value must be set.");

			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			_lessThanValue = Option.FromNullable(lessThan ?? lessThanOrEqualTo);
			_lessThanOrEqualTo = lessThanOrEqualTo.HasValue;
			_greaterThanValue = Option.FromNullable(greaterThan ?? greaterThanOrEqualTo);
			_greaterThanOrEqualTo = greaterThanOrEqualTo.HasValue;
		}

		IValueDescriptor IValueValidator<short>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<short>.IsValid(short value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && (_lessThanOrEqualTo ? value > lessThan : value >= lessThan))
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && (_greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan))
				return false;

			return true;
		}

		ValidationError IValueValidator<short>.GetError(short value, bool inverted)
			=> new ValidationError(nameof(RangeValidator_Int16), (this as IValueValidator<short>).GetDescriptor());
	}

	public struct RangeValidator_UInt16 : IValueValidator<ushort>
	{
		private readonly Option<ushort> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<ushort> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_UInt16(ushort? greaterThan, ushort? greaterThanOrEqualTo, ushort? lessThan, ushort? lessThanOrEqualTo)
		{
			if (!(lessThan ?? lessThanOrEqualTo).HasValue && !(greaterThan ?? greaterThanOrEqualTo).HasValue)
				throw new ArgumentException("Either a minimum or maximum value must be set.");

			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			_lessThanValue = Option.FromNullable(lessThan ?? lessThanOrEqualTo);
			_lessThanOrEqualTo = lessThanOrEqualTo.HasValue;
			_greaterThanValue = Option.FromNullable(greaterThan ?? greaterThanOrEqualTo);
			_greaterThanOrEqualTo = greaterThanOrEqualTo.HasValue;
		}

		IValueDescriptor IValueValidator<ushort>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<ushort>.IsValid(ushort value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && (_lessThanOrEqualTo ? value > lessThan : value >= lessThan))
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && (_greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan))
				return false;

			return true;
		}

		ValidationError IValueValidator<ushort>.GetError(ushort value, bool inverted)
			=> new ValidationError(nameof(RangeValidator_UInt16), (this as IValueValidator<ushort>).GetDescriptor());
	}

	public struct RangeValidator_Int32 : IValueValidator<int>
	{
		private readonly Option<int> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<int> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Int32(int? greaterThan, int? greaterThanOrEqualTo, int? lessThan, int? lessThanOrEqualTo)
		{
			if (!(lessThan ?? lessThanOrEqualTo).HasValue && !(greaterThan ?? greaterThanOrEqualTo).HasValue)
				throw new ArgumentException("Either a minimum or maximum value must be set.");

			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			_lessThanValue = Option.FromNullable(lessThan ?? lessThanOrEqualTo);
			_lessThanOrEqualTo = lessThanOrEqualTo.HasValue;
			_greaterThanValue = Option.FromNullable(greaterThan ?? greaterThanOrEqualTo);
			_greaterThanOrEqualTo = greaterThanOrEqualTo.HasValue;
		}

		IValueDescriptor IValueValidator<int>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<int>.IsValid(int value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && (_lessThanOrEqualTo ? value > lessThan : value >= lessThan))
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && (_greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan))
				return false;

			return true;
		}

		ValidationError IValueValidator<int>.GetError(int value, bool inverted)
			=> new ValidationError(nameof(RangeValidator_Int32), (this as IValueValidator<int>).GetDescriptor());
	}

	public struct RangeValidator_UInt32 : IValueValidator<uint>
	{
		private readonly Option<uint> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<uint> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_UInt32(uint? greaterThan, uint? greaterThanOrEqualTo, uint? lessThan, uint? lessThanOrEqualTo)
		{
			if (!(lessThan ?? lessThanOrEqualTo).HasValue && !(greaterThan ?? greaterThanOrEqualTo).HasValue)
				throw new ArgumentException("Either a minimum or maximum value must be set.");

			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			_lessThanValue = Option.FromNullable(lessThan ?? lessThanOrEqualTo);
			_lessThanOrEqualTo = lessThanOrEqualTo.HasValue;
			_greaterThanValue = Option.FromNullable(greaterThan ?? greaterThanOrEqualTo);
			_greaterThanOrEqualTo = greaterThanOrEqualTo.HasValue;
		}

		IValueDescriptor IValueValidator<uint>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<uint>.IsValid(uint value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && (_lessThanOrEqualTo ? value > lessThan : value >= lessThan))
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && (_greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan))
				return false;

			return true;
		}

		ValidationError IValueValidator<uint>.GetError(uint value, bool inverted)
			=> new ValidationError(nameof(RangeValidator_UInt32), (this as IValueValidator<uint>).GetDescriptor());
	}

	public struct RangeValidator_Int64 : IValueValidator<long>
	{
		private readonly Option<long> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<long> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Int64(long? greaterThan, long? greaterThanOrEqualTo, long? lessThan, long? lessThanOrEqualTo)
		{
			if (!(lessThan ?? lessThanOrEqualTo).HasValue && !(greaterThan ?? greaterThanOrEqualTo).HasValue)
				throw new ArgumentException("Either a minimum or maximum value must be set.");

			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			_lessThanValue = Option.FromNullable(lessThan ?? lessThanOrEqualTo);
			_lessThanOrEqualTo = lessThanOrEqualTo.HasValue;
			_greaterThanValue = Option.FromNullable(greaterThan ?? greaterThanOrEqualTo);
			_greaterThanOrEqualTo = greaterThanOrEqualTo.HasValue;
		}

		IValueDescriptor IValueValidator<long>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<long>.IsValid(long value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && (_lessThanOrEqualTo ? value > lessThan : value >= lessThan))
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && (_greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan))
				return false;

			return true;
		}

		ValidationError IValueValidator<long>.GetError(long value, bool inverted)
			=> new ValidationError(nameof(RangeValidator_Int64), (this as IValueValidator<long>).GetDescriptor());
	}

	public struct RangeValidator_UInt64 : IValueValidator<ulong>
	{
		private readonly Option<ulong> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<ulong> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_UInt64(ulong? greaterThan, ulong? greaterThanOrEqualTo, ulong? lessThan, ulong? lessThanOrEqualTo)
		{
			if (!(lessThan ?? lessThanOrEqualTo).HasValue && !(greaterThan ?? greaterThanOrEqualTo).HasValue)
				throw new ArgumentException("Either a minimum or maximum value must be set.");

			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			_lessThanValue = Option.FromNullable(lessThan ?? lessThanOrEqualTo);
			_lessThanOrEqualTo = lessThanOrEqualTo.HasValue;
			_greaterThanValue = Option.FromNullable(greaterThan ?? greaterThanOrEqualTo);
			_greaterThanOrEqualTo = greaterThanOrEqualTo.HasValue;
		}

		IValueDescriptor IValueValidator<ulong>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<ulong>.IsValid(ulong value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && (_lessThanOrEqualTo ? value > lessThan : value >= lessThan))
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && (_greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan))
				return false;

			return true;
		}

		ValidationError IValueValidator<ulong>.GetError(ulong value, bool inverted)
			=> new ValidationError(nameof(RangeValidator_UInt64), (this as IValueValidator<ulong>).GetDescriptor());
	}

	public struct RangeValidator_Single : IValueValidator<float>
	{
		private readonly Option<float> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<float> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Single(float? greaterThan, float? greaterThanOrEqualTo, float? lessThan, float? lessThanOrEqualTo)
		{
			if (!(lessThan ?? lessThanOrEqualTo).HasValue && !(greaterThan ?? greaterThanOrEqualTo).HasValue)
				throw new ArgumentException("Either a minimum or maximum value must be set.");

			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			_lessThanValue = Option.FromNullable(lessThan ?? lessThanOrEqualTo);
			_lessThanOrEqualTo = lessThanOrEqualTo.HasValue;
			_greaterThanValue = Option.FromNullable(greaterThan ?? greaterThanOrEqualTo);
			_greaterThanOrEqualTo = greaterThanOrEqualTo.HasValue;
		}

		IValueDescriptor IValueValidator<float>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<float>.IsValid(float value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && (_lessThanOrEqualTo ? value > lessThan : value >= lessThan))
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && (_greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan))
				return false;

			return true;
		}

		ValidationError IValueValidator<float>.GetError(float value, bool inverted)
			=> new ValidationError(nameof(RangeValidator_Single), (this as IValueValidator<float>).GetDescriptor());
	}

	public struct RangeValidator_Double : IValueValidator<double>
	{
		private readonly Option<double> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<double> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Double(double? greaterThan, double? greaterThanOrEqualTo, double? lessThan, double? lessThanOrEqualTo)
		{
			if (!(lessThan ?? lessThanOrEqualTo).HasValue && !(greaterThan ?? greaterThanOrEqualTo).HasValue)
				throw new ArgumentException("Either a minimum or maximum value must be set.");

			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			_lessThanValue = Option.FromNullable(lessThan ?? lessThanOrEqualTo);
			_lessThanOrEqualTo = lessThanOrEqualTo.HasValue;
			_greaterThanValue = Option.FromNullable(greaterThan ?? greaterThanOrEqualTo);
			_greaterThanOrEqualTo = greaterThanOrEqualTo.HasValue;
		}

		IValueDescriptor IValueValidator<double>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<double>.IsValid(double value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && (_lessThanOrEqualTo ? value > lessThan : value >= lessThan))
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && (_greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan))
				return false;

			return true;
		}

		ValidationError IValueValidator<double>.GetError(double value, bool inverted)
			=> new ValidationError(nameof(RangeValidator_Double), (this as IValueValidator<double>).GetDescriptor());
	}

	public struct RangeValidator_Decimal : IValueValidator<decimal>
	{
		private readonly Option<decimal> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<decimal> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Decimal(decimal? greaterThan, decimal? greaterThanOrEqualTo, decimal? lessThan, decimal? lessThanOrEqualTo)
		{
			if (!(lessThan ?? lessThanOrEqualTo).HasValue && !(greaterThan ?? greaterThanOrEqualTo).HasValue)
				throw new ArgumentException("Either a minimum or maximum value must be set.");

			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			_lessThanValue = Option.FromNullable(lessThan ?? lessThanOrEqualTo);
			_lessThanOrEqualTo = lessThanOrEqualTo.HasValue;
			_greaterThanValue = Option.FromNullable(greaterThan ?? greaterThanOrEqualTo);
			_greaterThanOrEqualTo = greaterThanOrEqualTo.HasValue;
		}

		IValueDescriptor IValueValidator<decimal>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<decimal>.IsValid(decimal value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && (_lessThanOrEqualTo ? value > lessThan : value >= lessThan))
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && (_greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan))
				return false;

			return true;
		}

		ValidationError IValueValidator<decimal>.GetError(decimal value, bool inverted)
			=> new ValidationError(nameof(RangeValidator_Decimal), (this as IValueValidator<decimal>).GetDescriptor());
	}

	public struct RangeValidator_DateTime : IValueValidator<DateTime>
	{
		private readonly Option<DateTime> _lessThanValue;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<DateTime> _greaterThanValue;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_DateTime(DateTime? greaterThan, DateTime? greaterThanOrEqualTo, DateTime? lessThan, DateTime? lessThanOrEqualTo)
		{
			if (!(lessThan ?? lessThanOrEqualTo).HasValue && !(greaterThan ?? greaterThanOrEqualTo).HasValue)
				throw new ArgumentException("Either a minimum or maximum value must be set.");

			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			_lessThanValue = Option.FromNullable(lessThan ?? lessThanOrEqualTo);
			_lessThanOrEqualTo = lessThanOrEqualTo.HasValue;
			_greaterThanValue = Option.FromNullable(greaterThan ?? greaterThanOrEqualTo);
			_greaterThanOrEqualTo = greaterThanOrEqualTo.HasValue;
		}

		IValueDescriptor IValueValidator<DateTime>.GetDescriptor()
			=> new RangeDescriptor(_lessThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _lessThanOrEqualTo, _greaterThanValue.Match(value => Option.Some<object>(value), Option.None<object>), _greaterThanOrEqualTo);

		bool IValueValidator<DateTime>.IsValid(DateTime value)
		{
			if (_lessThanValue.TryGetValue(out var lessThan) && (_lessThanOrEqualTo ? value > lessThan : value >= lessThan))
				return false;

			if (_greaterThanValue.TryGetValue(out var greaterThan) && (_greaterThanOrEqualTo ? value < greaterThan : value <= greaterThan))
				return false;

			return true;
		}

		ValidationError IValueValidator<DateTime>.GetError(DateTime value, bool inverted)
			=> new ValidationError(nameof(RangeValidator_DateTime), (this as IValueValidator<DateTime>).GetDescriptor());
	}
}
