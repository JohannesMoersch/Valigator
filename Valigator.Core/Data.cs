using System;
using Functional;
using Valigator.Core;

namespace Valigator
{
	public struct Data<TValue>
	{
		private readonly bool _hasBeenSet;

		private readonly IDataValidator<TValue> _dataValidator;

		private TValue _value;
		public TValue Value => _dataValidator == null ? (_hasBeenSet ? _value : throw new DataNotInitializedException()) : throw new DataNotVerifiedException();

		public Data(TValue value)
		{
			_value = value;

			_hasBeenSet = true;
			_dataValidator = null;
		}

		public Data(IDataValidator<TValue> dataValidator)
		{
			_value = default;

			_hasBeenSet = false;
			_dataValidator = dataValidator;
		}

		private Data(TValue value, IDataValidator<TValue> dataValidator)
		{
			_value = value;

			_hasBeenSet = true;
			_dataValidator = dataValidator;
		}

		public Data<TValue> WithValue(TValue value)
		{
			if (_hasBeenSet)
				throw new DataAlreadySetException();

			if (_dataValidator == null)
				throw new DataNotInitializedException();

			return new Data<TValue>(value, _dataValidator);
		}

		public Result<Data<TValue>, ValidationError> Verify(object model)
		{
			if (_dataValidator == null)
			{
				if (_hasBeenSet)
					throw new DataAlreadyVerifiedException();

				throw new DataNotInitializedException();
			}

			return _dataValidator
				  .Validate(model ?? throw new ArgumentNullException(nameof(model)), _hasBeenSet, _value)
				  .Match(value => Result.Success<Data<TValue>, ValidationError>(new Data<TValue>(value)), Result.Failure<Data<TValue>, ValidationError>);
		}

		public static implicit operator TValue(Data<TValue> data)
			=> data.Value;
	}
}
