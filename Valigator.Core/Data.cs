using System;
using Functional;
using Valigator.Core;
using Valigator.Core.Helpers;

namespace Valigator
{
	public struct Data<TValue>
	{
		private readonly TValue _value;

		private readonly IDataValidator<TValue> _dataValidator;

		private readonly ValidationError[] _validationErrors;

		public DataState State { get; }

		public TValue Value
		{
			get
			{
				if (State == DataState.Uninitialized)
					throw new DataNotInitializedException();

				if (State == DataState.UnSet || State == DataState.Set)
					throw new DataNotVerifiedException();

				if (State == DataState.Invalid)
					throw new DataFailedVerificationException();

				return _value;
			}
		}

		public DataDescriptor DataDescriptor
			=> State != DataState.Uninitialized ? _dataValidator.DataDescriptor : throw new DataNotInitializedException();

		public Data(IDataValidator<TValue> dataValidator)
		{
			State = DataState.UnSet;
			_dataValidator = dataValidator ?? throw new ArgumentNullException(nameof(dataValidator));
			_value = default;
			_validationErrors = null;
		}

		private Data(DataState state, TValue value, IDataValidator<TValue> dataValidator, ValidationError[] validationErrors)
		{
			State = state;
			_dataValidator = dataValidator;
			_value = value;
			_validationErrors = validationErrors;
		}

		public Data<TValue> WithValue(TValue value)
		{
			if (State == DataState.UnSet)
				return new Data<TValue>(DataState.Set, value, _dataValidator, null);

			if (State == DataState.Uninitialized)
				throw new DataNotInitializedException();

			throw new DataAlreadySetException();
		}

		public Data<TValue> WithErrors(params ValidationError[] validationErrors)
			=> new Data<TValue>(DataState.Invalid, default, _dataValidator, validationErrors);

		public Result<TValue, ValidationError[]> TryGetValue()
		{
			if (State == DataState.Invalid)
				return Result.Failure<TValue, ValidationError[]>(_validationErrors);

			return Result.Success<TValue, ValidationError[]>(Value);
		}

		public Data<TValue> Verify(object model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			if (State == DataState.Uninitialized)
				throw new DataNotInitializedException();

			if (State == DataState.Valid || State == DataState.Invalid)
				throw new DataAlreadyVerifiedException();

			if (_dataValidator.Validate(model, State == DataState.Set, _value).TryGetValue(out var success, out var failure))
				return new Data<TValue>(DataState.Valid, success, _dataValidator, null);
			else
				return WithErrors(failure);
		}

		public static implicit operator TValue(Data<TValue> data)
			=> data.Value;
	}
}
