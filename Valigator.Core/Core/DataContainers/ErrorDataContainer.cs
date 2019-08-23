using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.Core.DataContainers
{
	internal class ErrorDataContainer<TValue> : IDataContainer<TValue>
	{
		private readonly ValidationError[] _validationErrors;

		public DataDescriptor DataDescriptor { get; }

		public ErrorDataContainer(DataDescriptor dataDescriptor, ValidationError[] validationErrors)
		{
			DataDescriptor = dataDescriptor;
			_validationErrors = validationErrors ?? throw new ArgumentNullException(nameof(validationErrors));
		}

		public Data<TValue> Verify(Data<TValue> data, object model, bool isSet, TValue value) 
			=> throw new NotSupportedException();

		public Data<TValue> WithValue(Data<TValue> data, TValue value) 
			=> throw new NotSupportedException();

		public Option<ValidationError[]> GetErrors()
			=> Option.Some(_validationErrors);
	}
}
