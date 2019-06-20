using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core.ValueValidators
{
	public struct MultipleOfValidator_Byte : IValueValidator<byte>
	{
		private readonly byte _divisor;

		public MultipleOfValidator_Byte(byte divisor)
		{
			if (divisor == 0)
				throw new ArgumentException(nameof(divisor), $"{nameof(divisor)} cannot be zero.");

			_divisor = divisor;
		}

		IValueDescriptor IValueValidator<byte>.GetDescriptor()
			=> new MultipleOfDescriptor(_divisor);

		bool IValueValidator<byte>.IsValid(byte value)
			=> value % _divisor == 0;

		ValidationError IValueValidator<byte>.GetError(byte value, bool inverted)
			=> new ValidationError(nameof(MultipleOfValidator_Byte), (this as IValueValidator<byte>).GetDescriptor());
	}

	public struct MultipleOfValidator_SByte : IValueValidator<sbyte>
	{
		private readonly sbyte _divisor;

		public MultipleOfValidator_SByte(sbyte divisor)
		{
			if (divisor == 0)
				throw new ArgumentException(nameof(divisor), $"{nameof(divisor)} cannot be zero.");

			_divisor = divisor;
		}

		IValueDescriptor IValueValidator<sbyte>.GetDescriptor()
			=> new MultipleOfDescriptor(_divisor);

		bool IValueValidator<sbyte>.IsValid(sbyte value)
			=> value % _divisor == 0;

		ValidationError IValueValidator<sbyte>.GetError(sbyte value, bool inverted)
			=> new ValidationError(nameof(MultipleOfValidator_SByte), (this as IValueValidator<sbyte>).GetDescriptor());
	}

	public struct MultipleOfValidator_Int16 : IValueValidator<short>
	{
		private readonly short _divisor;

		public MultipleOfValidator_Int16(short divisor)
		{
			if (divisor == 0)
				throw new ArgumentException(nameof(divisor), $"{nameof(divisor)} cannot be zero.");

			_divisor = divisor;
		}

		IValueDescriptor IValueValidator<short>.GetDescriptor()
			=> new MultipleOfDescriptor(_divisor);

		bool IValueValidator<short>.IsValid(short value)
			=> value % _divisor == 0;

		ValidationError IValueValidator<short>.GetError(short value, bool inverted)
			=> new ValidationError(nameof(MultipleOfValidator_Int16), (this as IValueValidator<short>).GetDescriptor());
	}

	public struct MultipleOfValidator_UInt16 : IValueValidator<ushort>
	{
		private readonly ushort _divisor;

		public MultipleOfValidator_UInt16(ushort divisor)
		{
			if (divisor == 0)
				throw new ArgumentException(nameof(divisor), $"{nameof(divisor)} cannot be zero.");

			_divisor = divisor;
		}

		IValueDescriptor IValueValidator<ushort>.GetDescriptor()
			=> new MultipleOfDescriptor(_divisor);

		bool IValueValidator<ushort>.IsValid(ushort value)
			=> value % _divisor == 0;

		ValidationError IValueValidator<ushort>.GetError(ushort value, bool inverted)
			=> new ValidationError(nameof(MultipleOfValidator_UInt16), (this as IValueValidator<ushort>).GetDescriptor());
	}

	public struct MultipleOfValidator_Int32 : IValueValidator<int>
	{
		private readonly int _divisor;

		public MultipleOfValidator_Int32(int divisor)
		{
			if (divisor == 0)
				throw new ArgumentException(nameof(divisor), $"{nameof(divisor)} cannot be zero.");

			_divisor = divisor;
		}

		IValueDescriptor IValueValidator<int>.GetDescriptor()
			=> new MultipleOfDescriptor(_divisor);

		bool IValueValidator<int>.IsValid(int value)
			=> value % _divisor == 0;

		ValidationError IValueValidator<int>.GetError(int value, bool inverted)
			=> new ValidationError(nameof(MultipleOfValidator_Int32), (this as IValueValidator<int>).GetDescriptor());
	}

	public struct MultipleOfValidator_UInt32 : IValueValidator<uint>
	{
		private readonly uint _divisor;

		public MultipleOfValidator_UInt32(uint divisor)
		{
			if (divisor == 0)
				throw new ArgumentException(nameof(divisor), $"{nameof(divisor)} cannot be zero.");

			_divisor = divisor;
		}

		IValueDescriptor IValueValidator<uint>.GetDescriptor()
			=> new MultipleOfDescriptor(_divisor);

		bool IValueValidator<uint>.IsValid(uint value)
			=> value % _divisor == 0;

		ValidationError IValueValidator<uint>.GetError(uint value, bool inverted)
			=> new ValidationError(nameof(MultipleOfValidator_UInt32), (this as IValueValidator<uint>).GetDescriptor());
	}

	public struct MultipleOfValidator_Int64 : IValueValidator<long>
	{
		private readonly long _divisor;

		public MultipleOfValidator_Int64(long divisor)
		{
			if (divisor == 0)
				throw new ArgumentException(nameof(divisor), $"{nameof(divisor)} cannot be zero.");

			_divisor = divisor;
		}

		IValueDescriptor IValueValidator<long>.GetDescriptor()
			=> new MultipleOfDescriptor(_divisor);

		bool IValueValidator<long>.IsValid(long value)
			=> value % _divisor == 0;

		ValidationError IValueValidator<long>.GetError(long value, bool inverted)
			=> new ValidationError(nameof(MultipleOfValidator_Int64), (this as IValueValidator<long>).GetDescriptor());
	}

	public struct MultipleOfValidator_UInt64 : IValueValidator<ulong>
	{
		private readonly ulong _divisor;

		public MultipleOfValidator_UInt64(ulong divisor)
		{
			if (divisor == 0)
				throw new ArgumentException(nameof(divisor), $"{nameof(divisor)} cannot be zero.");

			_divisor = divisor;
		}

		IValueDescriptor IValueValidator<ulong>.GetDescriptor()
			=> new MultipleOfDescriptor(_divisor);

		bool IValueValidator<ulong>.IsValid(ulong value)
			=> value % _divisor == 0;

		ValidationError IValueValidator<ulong>.GetError(ulong value, bool inverted)
			=> new ValidationError(nameof(MultipleOfValidator_UInt64), (this as IValueValidator<ulong>).GetDescriptor());
	}
}
