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
			get
			{
				if (_data == null)
					throw new DataNotInitializedException();

				if (_data is IInvalidData failure)
					throw new DataInvalidException(failure.Errors);

				return _value;
			}
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
			if (_data == null)
				throw new DataNotInitializedException();

			if (_data is IValidData)
				return Result.Success<TValue, ValidationError[]>(_value);

			if (_data is Unset unset)
			{
				if (_data.Data.CoerceUnset().TryGetValue(out var value, out var errors))
				{
					_value = value;
					_data = unset.ToCoercedValid();
				}
				else
					_data = unset.ToCoercedInvalid(errors);
			}

			if (_data is IInvalidData failure)
				return Result.Failure<TValue, ValidationError[]>(failure.Errors);

			return Result.Success<TValue, ValidationError[]>(_value);
		}

#pragma warning disable CS8604 // Possible null reference argument.
		public Data<TValue> WithValue<T>(Option<T> input)
		{
			if (_data.Data is IPropertyData<T, TValue> propertyData)
			{
				if (propertyData.Coerce(Optional.Set(input)).TryGetValue(out var value, out var errors) && propertyData.Validate(value).TryGetValue(out var success, out errors))
					return new Data<TValue>(value, _data.ToSetValid());

				return new Data<TValue>(default, _data.ToSetInvalid(errors));
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

			public CoercedValid CoercedValid { get; }

			public SetValid SetValid { get; }

			public SharedData(IPropertyData<TValue> data)
			{
				Data = data;

				Unset = new Unset(this);
				CoercedValid = new CoercedValid(this);
				SetValid = new SetValid(this);
			}
		}

		private interface IData 
		{
			IPropertyData<TValue> Data { get; }

			IData ToSetValid();

			IData ToSetInvalid(ValidationError[] errors);
		}

		private interface IInvalidData : IData 
		{
			ValidationError[] Errors { get; }
		}

		private interface IValidData : IData 
		{
		}

		private class Unset : IData
		{
			private readonly Data<TValue>.SharedData _data;

			public IPropertyData<TValue> Data => _data.Data;

			public Unset(SharedData data) 
				=> _data = data;

			public IData ToCoercedValid()
				=> _data.CoercedValid;

			public IData ToCoercedInvalid(ValidationError[] errors)
				=> new CoercedInvalid(_data, errors);

			public IData ToSetValid()
				=> _data.SetValid;

			public IData ToSetInvalid(ValidationError[] errors)
				=> new SetInvalid(_data, errors);
		}

		private class CoercedValid : IValidData
		{
			private readonly Data<TValue>.SharedData _data;

			public IPropertyData<TValue> Data => _data.Data;

			public CoercedValid(SharedData data)
				=> _data = data;

			public IData ToSetValid()
				=> _data.SetValid;

			public IData ToSetInvalid(ValidationError[] errors)
				=> new SetInvalid(_data, errors);
		}

		private class CoercedInvalid : IInvalidData
		{
			private readonly Data<TValue>.SharedData _data;

			public IPropertyData<TValue> Data => _data.Data;

			public ValidationError[] Errors { get; }

			public CoercedInvalid(SharedData data, ValidationError[] errors)
			{
				_data = data;
				Errors = errors;
			}

			public IData ToSetValid()
				=> _data.SetValid;

			public IData ToSetInvalid(ValidationError[] errors)
				=> new SetInvalid(_data, errors);
		}

		private class SetValid : IValidData
		{
			private readonly Data<TValue>.SharedData _data;

			public IPropertyData<TValue> Data => _data.Data;

			public SetValid(SharedData data)
				=> _data = data;

			public IData ToSetValid()
				=> _data.SetValid;

			public IData ToSetInvalid(ValidationError[] errors)
				=> new SetInvalid(_data, errors);
		}

		private class SetInvalid : IInvalidData
		{
			private readonly Data<TValue>.SharedData _data;

			public IPropertyData<TValue> Data => _data.Data;

			public ValidationError[] Errors { get; }

			public SetInvalid(SharedData data, ValidationError[] errors)
			{
				_data = data;
				Errors = errors;
			}

			public IData ToSetValid()
				=> _data.SetValid;

			public IData ToSetInvalid(ValidationError[] errors)
				=> new SetInvalid(_data, errors);
		}
	}
}
