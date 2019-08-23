using System;
using Functional;
using Valigator.Core;
using Valigator.Core.Core.DataContainers;
using Valigator.Core.Helpers;

namespace Valigator
{
	public struct Data<TValue>
	{
		private readonly TValue _value;

		private readonly IDataContainer<TValue> _dataContainer;

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
			=> State != DataState.Uninitialized ? _dataContainer.DataDescriptor : throw new DataNotInitializedException();

		internal Data(IDataContainer<TValue> dataContainer)
		{
			State = DataState.UnSet;
			_dataContainer = dataContainer ?? throw new ArgumentNullException(nameof(dataContainer));
			_value = default;
		}

		private Data(DataState state, TValue value, IDataContainer<TValue> dataContainer)
		{
			State = state;
			_dataContainer = dataContainer;
			_value = value;
		}

		public Data<TValue> WithValue(TValue value)
		{
			if (value == null)
				throw new ArgumentNullException(nameof(value));

			if (State == DataState.UnSet)
				return new Data<TValue>(DataState.Set, value, _dataContainer);

			if (State == DataState.Uninitialized)
				throw new DataNotInitializedException();

			throw new DataAlreadySetException();
		}

		public Data<TValue> WithErrors(params ValidationError[] validationErrors)
			=> new Data<TValue>(DataState.Invalid, default, new ErrorDataContainer<TValue>(_dataContainer.DataDescriptor, validationErrors));

		public Result<TValue, ValidationError[]> TryGetValue()
		{
			if (State == DataState.Invalid)
				return Result.Failure<TValue, ValidationError[]>(_dataContainer.GetErrors().Match(_ => _, () => default));

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

			if (!_dataContainer.IsValid(model, _value).TryGetValue(out var _, out var failure))
				return WithErrors(failure);

			return new Data<TValue>(DataState.Valid, _value, _dataContainer);
		}

		public static implicit operator TValue(Data<TValue> data)
			=> data.Value;
	}
}
