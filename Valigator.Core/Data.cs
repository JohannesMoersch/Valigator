using System;
using Functional;
using Valigator.Core;
using Valigator.Core.Helpers;

namespace Valigator
{
	public struct Data<TValue>
	{
		private enum State
		{
			Uninitialized,
			UnSet,
			Set,
			Verified
		}

		private readonly State _state;

		private readonly IDataValidator<TValue> _dataValidator;

		private readonly TValue _value;
		public TValue Value => _state == State.Uninitialized ? throw new DataNotInitializedException() : (_state == State.Verified ? _value : throw new DataNotVerifiedException());

		public DataDescriptor DataDescriptor
			=> _state != State.Uninitialized ? _dataValidator.DataDescriptor : throw new DataNotInitializedException();

		public Data(IDataValidator<TValue> dataValidator)
		{
			_state = State.UnSet;
			_dataValidator = dataValidator ?? throw new ArgumentNullException(nameof(dataValidator));
			_value = default;
		}

		private Data(State state, TValue value, IDataValidator<TValue> dataValidator)
		{
			_state = state;
			_dataValidator = dataValidator;
			_value = value;
		}

		public Data<TValue> WithValue(TValue value)
		{
			if (_state == State.UnSet)
				return new Data<TValue>(State.Set, value, _dataValidator);

			if (_state == State.Uninitialized)
				throw new DataNotInitializedException();

			throw new DataAlreadySetException();
		}

		public Result<Data<TValue>, ValidationError> Verify(object model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			if (_state == State.Uninitialized)
				throw new DataNotInitializedException();

			if (_state == State.Verified)
				throw new DataAlreadyVerifiedException();

			if (_dataValidator.Validate(model, _state == State.Set, _value).TryGetValue(out var success, out var failure))
				return Result.Success<Data<TValue>, ValidationError>(new Data<TValue>(State.Verified, success, _dataValidator));
			else
				return Result.Failure<Data<TValue>, ValidationError>(failure);
		}

		public static implicit operator TValue(Data<TValue> data)
			=> data.Value;
	}
}
