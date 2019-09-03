using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public interface ICollectionStateValidator<TDataValue, TValue> : IStateValidator<TDataValue, Option<TValue>[]>
	{
		Result<Unit, ValidationError[]> IsValid(Option<object> model, TDataValue value);
	}
}
