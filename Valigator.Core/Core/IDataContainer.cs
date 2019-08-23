using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	internal interface IDataContainer<TValue>
	{
		DataDescriptor DataDescriptor { get; }

		Result<Unit, ValidationError[]> IsValid(object model, TValue value);

		Option<ValidationError[]> GetErrors();
	}
}
