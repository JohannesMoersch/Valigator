using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator
{
	public struct Data<TValue>
	{
		private Result<TValue, ValidationError[]> _value;

		private IPropertyData<TValue> _propertyData;

		public TValue Value
		{
			get
			{
				if (_propertyData == null)
					throw new DataNotInitializedException();

				if (!_value.TryGetValue(out var success, out var failure))
					throw new DataInvalidException(failure);

				return success;
			}
		}

		public Data(IPropertyData<TValue> propertyData)
		{
			_propertyData = propertyData;

			if (_propertyData.CoerceUnset().TryGetValue(out var success, out var failure) && _propertyData.Validate(success).TryGetValue(out var _, out failure))
				_value = Result.Success<TValue, ValidationError[]>(success);
			else
				_value = Result.Failure<TValue, ValidationError[]>(failure);
		}

		private Data(TValue value, IPropertyData<TValue> propertyData)
		{
			_value = Result.Success<TValue, ValidationError[]>(value);
			_propertyData = propertyData;
		}

		private Data(ValidationError[] errors, IPropertyData<TValue> propertyData)
		{
			_value = Result.Failure<TValue, ValidationError[]>(errors);
			_propertyData = propertyData;
		}

		public Result<TValue, ValidationError[]> TryGetValue()
		{
			if (_propertyData == null)
				throw new DataNotInitializedException();

			if (!_value.TryGetValue(out var success, out var failure))
				return Result.Failure<TValue, ValidationError[]>(failure);

			return Result.Success<TValue, ValidationError[]>(success);
		}

		public Data<TValue> WithValue<T>(Option<T> input)
		{
			if (_propertyData is IPropertyData<T, TValue> propertyData)
			{
				if (propertyData.Coerce(Optional.Set(input)).TryGetValue(out var value, out var errors) && propertyData.Validate(value).TryGetValue(out var success, out errors))
					return new Data<TValue>(value, propertyData);

				return new Data<TValue>(errors, propertyData);
			}

			throw new ArgumentException($"Type \"{nameof(T)}\" must match interior type of \"{nameof(TValue)}\".", nameof(T));
		}
	}
}
