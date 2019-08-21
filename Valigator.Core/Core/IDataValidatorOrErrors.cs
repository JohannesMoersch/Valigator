using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public interface IDataValidatorOrErrors<TSource, TValue>
	{
		DataDescriptor DataDescriptor { get; }

		Result<TValue, ValidationError[]> Validate(object model, bool isSet, TSource value);

		Option<ValidationError[]> GetErrors();
	}
}
