using System;
using Functional;

namespace Newtonsoft.FluentValidation
{
	public struct Data<TValue>
	{
		private readonly bool _hasBeenSet;

		private readonly IDataValidator<TValue> _dataValidator; // TODO: Handle this being null

		public TValue Value { get; }

		public Data(TValue value)
		{
			Value = value;

			_hasBeenSet = true;
			_dataValidator = null;
		}

		public Data(IDataValidator<TValue> dataValidator)
		{
			Value = default;

			_hasBeenSet = false;
			_dataValidator = dataValidator;
		}

		private Data(TValue value, IDataValidator<TValue> dataValidator)
		{
			Value = value;

			_hasBeenSet = true;
			_dataValidator = dataValidator;
		}

		public Data<TValue> WithValue(TValue value)
			=> new Data<TValue>(value, _dataValidator);

		public Result<Data<TValue>, ValidationError> Verify(object model)
			=> _dataValidator
				.Validate(model, _hasBeenSet, Value)
				.Match(value => Result.Success<Data<TValue>, ValidationError>(new Data<TValue>(value)), Result.Failure<Data<TValue>, ValidationError>);

		public static implicit operator Data<TValue>(TValue value)
			=> new Data<TValue>(value, null);

		public static implicit operator TValue(Data<TValue> data)
			=> data.Value;
	}
}
