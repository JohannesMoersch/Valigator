using System;
using Functional;
using Valigator.Core;
using Valigator.Core.DataContainers;
using Valigator.Core.Helpers;

namespace Valigator
{
	public struct Data<TValue>
	{
		private readonly TValue _value;

		private readonly IDataContainer<TValue> _dataContainer;

		public IDataContainer DataContainer
			=> State != DataState.Uninitialized ? _dataContainer : throw new DataNotInitializedException();

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

		internal Data<TValue> WithValidatedValue(TValue value)
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
			=> new Data<TValue>(DataState.UnSet, default, GetErrorDataContainer(_dataContainer, validationErrors));

		public Result<TValue, ValidationError[]> TryGetValue()
		{
			if (State == DataState.Invalid)
			{
				if (_dataContainer.GetErrors().TryGetValue(out var some))
					return Result.Failure<TValue, ValidationError[]>(some);

				return Result.Failure<TValue, ValidationError[]>(Array.Empty<ValidationError>());
			}

			return Result.Success<TValue, ValidationError[]>(Value);
		}

		public Data<TValue> Verify()
			=> Verify(Option.None<object>());

		public Data<TValue> Verify(object model)
			=> Verify(Option.Some(model ?? throw new ArgumentNullException(nameof(model))));

		private Data<TValue> Verify(Option<object> model)
		{
			if (State == DataState.Uninitialized)
				throw new DataNotInitializedException();

			if (State == DataState.Valid || State == DataState.Invalid)
				throw new DataAlreadyVerifiedException();

			if (_dataContainer is ErrorDataContainer<TValue>)
				return new Data<TValue>(DataState.Invalid, _value, _dataContainer);

			if (_dataContainer.IsValid(model, Option.Create(State == DataState.Set, _value)).TryGetValue(out var value, out var failure))
				return new Data<TValue>(DataState.Valid, value, _dataContainer);

			return new Data<TValue>(DataState.Invalid, _value, GetErrorDataContainer(_dataContainer, failure));
		}

		private static IDataContainer<TValue> GetErrorDataContainer(IDataContainer<TValue> dataContainer, ValidationError[] validationErrors)
			=> new ErrorDataContainer<TValue>(() => dataContainer.DataDescriptor, validationErrors);

		public static implicit operator TValue(Data<TValue> data)
			=> data.Value;
	}
}
