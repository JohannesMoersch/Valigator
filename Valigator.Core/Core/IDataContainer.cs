using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public interface IDataContainer { }

	internal interface IDataContainer<TValue> : IDataContainer
	{
		DataDescriptor DataDescriptor { get; }

		Result<Unit, ValidationError[]> IsValid(Option<object> model, Option<TValue> value);

		Option<ValidationError[]> GetErrors();
	}
}
