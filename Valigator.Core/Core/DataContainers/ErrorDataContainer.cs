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

		public ErrorDataContainer(Func<DataDescriptor> dataDescriptorFactory, ValidationError[] validationErrors)
		{
			_dataDescriptorFactory = dataDescriptorFactory;
			_validationErrors = validationErrors ?? throw new ArgumentNullException(nameof(validationErrors));
		}

		Result<Unit, ValidationError[]> IDataContainer<TValue>.IsValid(Option<object> model, TValue value)
			=> Result.Failure<Unit, ValidationError[]>(_validationErrors);

		public Option<ValidationError[]> GetErrors()
			=> Option.Some(_validationErrors);
	}
}
