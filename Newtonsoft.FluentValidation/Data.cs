using System;
using Functional;
using Newtonsoft.FluentValidation.DataValidators;

namespace Newtonsoft.FluentValidation
{
	public struct Data<T>
	{
		private readonly bool _hasBeenSet;

		private readonly IDataValidator<T> _dataValidator;

		public T Value { get; }

		public Data(IDataValidator<T> dataValidator)
		{
			Value = default;

			_hasBeenSet = false;
			_dataValidator = dataValidator;

		}

		private Data(T value, IDataValidator<T> dataValidator)
		{
			Value = value;

			_hasBeenSet = true;
			_dataValidator = dataValidator;
		}

		public Data<T> WithValue(T value)
			=> new Data<T>(value, _dataValidator);

		public Result<Unit, ValidationError> Validate()
			=> _dataValidator.Validate(_hasBeenSet, Option.Create(Value != null, Value));

		public static implicit operator Data<T>(T value)
			=> new Data<T>(value, new RequiredValidator<T>());

		public static implicit operator T(Data<T> data)
			=> data.Value;
	}
}
