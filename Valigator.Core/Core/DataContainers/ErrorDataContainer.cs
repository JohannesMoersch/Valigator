using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.DataContainers
{
	internal class ErrorDataContainer<TValue> : IDataContainer<TValue>
	{
		private readonly ValidationError[] _validationErrors;

		private readonly Func<DataDescriptor> _dataDescriptorFactory;

		public DataDescriptor DataDescriptor => _dataDescriptorFactory.Invoke();

		public Type ValueType => typeof(TValue);

		public ErrorDataContainer(Func<DataDescriptor> dataDescriptorFactory, ValidationError[] validationErrors)
		{
			_dataDescriptorFactory = dataDescriptorFactory;
			_validationErrors = validationErrors ?? throw new ArgumentNullException(nameof(validationErrors));
		}

		Result<TValue, ValidationError[]> IDataContainer<TValue>.IsValid(Option<object> model, Option<TValue> value)
			=> Result.Failure<TValue, ValidationError[]>(_validationErrors);

		public Option<ValidationError[]> GetErrors()
			=> Option.Some(_validationErrors);

		public Data<TValue> WithUncheckedValue(Data<TValue> data, TValue value)
			=> data.WithValidatedValue(value);
	}
}
