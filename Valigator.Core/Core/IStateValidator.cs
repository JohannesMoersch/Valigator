using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public interface IStateValidator<TDataValue, TValue>
	{
		Data<TDataValue> Data { get; }

		IStateDescriptor GetDescriptor();

		IValueDescriptor[] GetImplicitValueDescriptors();

		Result<TDataValue, ValidationError[]> WithValue(Option<TValue> value);

		Result<Unit, ValidationError[]> Verify(TDataValue value);
	}
}
