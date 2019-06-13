using System;
using Functional;
using Valigator.Core;
using Valigator.Core.Helpers;

namespace Valigator
{
	public struct Data<TValue>
	{
		private enum State : byte
		{
			Uninitialized,
			UnSet,
			Set,
			Valid,
			Invalid
		}

		private readonly TValue _value;

		private readonly State _state;

		private readonly IDataValidator<TValue> _dataValidator;

		private readonly ValidationError[] _validationErrors;

		public TValue Value
		{
			get
			{
				if (_state == State.Uninitialized)
					throw new DataNotInitializedException();

				if (_state == State.UnSet || _state == State.Set)
					throw new DataNotVerifiedException();

				if (_state == State.Invalid)
					throw new DataFailedVerificationException();

				return _value;
			}
		}

		public DataDescriptor DataDescriptor
			=> _state != State.Uninitialized ? _dataValidator.DataDescriptor : throw new DataNotInitializedException();

		public Data(IDataValidator<TValue> dataValidator)
		{
			_state = State.UnSet;
			_dataValidator = dataValidator ?? throw new ArgumentNullException(nameof(dataValidator));
			_value = default;
			_validationErrors = null;
		}

		private Data(State state, TValue value, IDataValidator<TValue> dataValidator, ValidationError[] validationErrors)
		{
			_state = state;
			_dataValidator = dataValidator;
			_value = value;
			_validationErrors = validationErrors;
		}

		public Data<TValue> WithValue(TValue value)
		{
			if (_state == State.UnSet)
				return new Data<TValue>(State.Set, value, _dataValidator, null);

			if (_state == State.Uninitialized)
				throw new DataNotInitializedException();

			throw new DataAlreadySetException();
		}

		public Data<TValue> WithErrors(params ValidationError[] validationErrors)
			=> new Data<TValue>(State.Invalid, default, _dataValidator, validationErrors);

		public Result<TValue, ValidationError[]> TryGetValue()
		{
			if (_state == State.Invalid)
				return Result.Failure<TValue, ValidationError[]>(_validationErrors);

			return Result.Success<TValue, ValidationError[]>(Value);
		}

		public Data<TValue> Verify(object model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			if (_state == State.Uninitialized)
				throw new DataNotInitializedException();

			if (_state == State.Valid || _state == State.Invalid)
				throw new DataAlreadyVerifiedException();

			if (_dataValidator.Validate(model, _state == State.Set, _value).TryGetValue(out var success, out var failure))
				return new Data<TValue>(State.Valid, success, _dataValidator, null);
			else
				return WithErrors(failure);
		}

		public static implicit operator TValue(Data<TValue> data)
			=> data.Value;
	}
}
