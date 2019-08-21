using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core
{
	public struct Data<TSource, TValue>
	{
		private readonly TSource _source;

		private readonly TValue _value;

		private readonly IDataValidatorOrErrors<TSource, TValue> _dataValidator;

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

		public Data(IDataValidatorOrErrors<TSource, TValue> dataValidator)
		{
			State = DataState.UnSet;
			_dataValidator = dataValidator ?? throw new ArgumentNullException(nameof(dataValidator));
			_source = default;
			_value = default;
		}

		private Data(DataState state, TSource source, TValue value, IDataValidatorOrErrors<TSource, TValue> dataValidator)
		{
			State = state;
			_dataValidator = dataValidator;
			_source = source;
			_value = value;
		}

		public Data<TSource, TValue> WithValue(TSource source)
		{
			if (State == DataState.UnSet)
				return new Data<TSource, TValue>(DataState.Set, source, default, _dataValidator);

			if (State == DataState.Uninitialized)
				throw new DataNotInitializedException();

			throw new DataAlreadySetException();
		}

		public Data<TSource, TValue> WithErrors(params ValidationError[] validationErrors)
			=> new Data<TSource, TValue>(DataState.Invalid, default, default, new DataValidatorAndErrors<TSource, TValue>(_dataValidator, validationErrors));

		public Result<TValue, ValidationError[]> TryGetValue()
		{
			if (State == DataState.Invalid)
				return Result.Failure<TValue, ValidationError[]>(_dataValidator.GetErrors().Match(_ => _, () => default));

			return Result.Success<TValue, ValidationError[]>(Value);
		}

		public Data<TSource, TValue> Verify(object model)
		{
			if (model == null)
				throw new ArgumentNullException(nameof(model));

			if (State == DataState.Uninitialized)
				throw new DataNotInitializedException();

			if (State == DataState.Valid || State == DataState.Invalid)
				throw new DataAlreadyVerifiedException();

			if (_dataValidator.Validate(model, State == DataState.Set, _source).TryGetValue(out var success, out var failure))
				return new Data<TSource, TValue>(DataState.Valid, default, success, _dataValidator);
			else
				return WithErrors(failure);
		}

		public static implicit operator TValue(Data<TSource, TValue> data)
			=> data.Value;
	}
}
