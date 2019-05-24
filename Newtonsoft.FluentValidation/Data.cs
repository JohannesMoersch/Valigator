using System;
using Functional;
using Newtonsoft.FluentValidation.DataValidators;

namespace Newtonsoft.FluentValidation
{
	public struct Data<TValue>
	{
		private readonly bool _hasBeenSet;

		private readonly IDataValidator<TValue> _dataValidator;

		public TValue Value { get; }

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

		public Result<Unit, ValidationError> Validate()
			=> _dataValidator.Validate(_hasBeenSet, Value).Match(_ => Result.Unit<ValidationError>(), _ => Result.Unit<ValidationError>());

		public static implicit operator Data<TValue>(TValue value)
			=> new Data<TValue>(value, null);

		public static implicit operator TValue(Data<TValue> data)
			=> data.Value;
	}
}
