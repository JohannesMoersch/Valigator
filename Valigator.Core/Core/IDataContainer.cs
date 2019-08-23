using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	internal interface IDataContainer<TValue>
	{
		DataDescriptor DataDescriptor { get; }

		Data<TValue> Verify(Data<TValue> data, object model, bool isSet, TValue value);

		Option<ValidationError[]> GetErrors();
	}
}
