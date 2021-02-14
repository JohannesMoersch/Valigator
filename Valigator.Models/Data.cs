using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.ValidationData;

namespace Valigator
{
	public struct Data<TValue>
	{
		private TValue _value;
		public TValue Value
		{
			get => TryGetValue()
				.TryGetValue(out var success, out var failure)
				? success
				: throw new DataInvalidException(failure);
		}
		
		private IData _data;

#pragma warning disable CS8601, CS8618 // Possible null reference assignment. Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public Data(IPropertyData<TValue> propertyData)
		{
			_value = default;
			_data = new Unset(new SharedData(propertyData));
		}
#pragma warning restore CS8601, CS8618 // Possible null reference assignment. Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

		private Data(TValue value, IData data)
		{
			_value = value;
			_data = data;
		}

		public Result<TValue, ValidationError[]> TryGetValue()
		{
			if (_data is null)
				throw new DataNotInitializedException();

			if (_data is Valid)
				return Result.Success<TValue, ValidationError[]>(_value);

			if (_data is Unset unset)
			{
				if (_data.Data.CoerceUnset().TryGetValue(out var value, out var errors))
				{
					_value = value;
					_data = unset.ToValid();
				}
				else
					_data = unset.ToInvalid(errors);
			}

			if (_data is Invalid invalid)
				return Result.Failure<TValue, ValidationError[]>(invalid.Errors);

			return Result.Success<TValue, ValidationError[]>(_value);
		}

#pragma warning disable CS8604 // Possible null reference argument.
		public Data<TValue> WithValue<T>(Option<T> input)
		{
			if (_data is null)
				throw new DataNotInitializedException();

			if (_data.Data is IPropertyData<T, TValue> propertyData)
			{
				if (propertyData.Coerce(Optional.Set(input)).TryGetValue(out var value, out var errors) && propertyData.Validate(value).TryGetValue(out var success, out errors))
					return new Data<TValue>(value, _data.ToValid());

				return new Data<TValue>(default, _data.ToInvalid(errors));
			}

			throw new ArgumentException($"Type \"{nameof(T)}\" must match interior type of \"{nameof(TValue)}\".", nameof(T));
		}
#pragma warning restore CS8604 // Possible null reference argument.

		public static implicit operator Data<TValue>(ValidationDataBase<TValue> propertyData)
			=> new Data<TValue>(propertyData);

		private class SharedData
		{
			public IPropertyData<TValue> Data { get; }

			public Unset Unset { get; }

			public Valid Valid { get; }

			public SharedData(IPropertyData<TValue> data)
			{
				Data = data;

				Unset = new Unset(this);
				Valid = new Valid(this);
			}
		}

		private interface IData 
		{
			IPropertyData<TValue> Data { get; }

			IData ToValid();

			IData ToInvalid(ValidationError[] errors);
		}

		private class Unset : IData
		{
			private readonly Data<TValue>.SharedData _data;

			public IPropertyData<TValue> Data => _data.Data;

			public Unset(SharedData data) 
				=> _data = data;

			public IData ToValid()
				=> _data.Valid;

			public IData ToInvalid(ValidationError[] errors)
				=> new Invalid(_data, errors);
		}

		private class Valid : IData
		{
			private readonly Data<TValue>.SharedData _data;

			public IPropertyData<TValue> Data => _data.Data;

			public Valid(SharedData data)
				=> _data = data;

			public IData ToValid()
				=> _data.Valid;

			public IData ToInvalid(ValidationError[] errors)
				=> new Invalid(_data, errors);
		}

		private class Invalid : IData
		{
			private readonly Data<TValue>.SharedData _data;

			public IPropertyData<TValue> Data => _data.Data;

			public ValidationError[] Errors { get; }

			public Invalid(SharedData data, ValidationError[] errors)
			{
				_data = data;
				Errors = errors;
			}

			public IData ToValid()
				=> _data.Valid;

			public IData ToInvalid(ValidationError[] errors)
				=> new Invalid(_data, errors);
		}
	}
}
