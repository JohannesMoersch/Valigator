using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IRootValidationData<TNext, out TValue> : IValidationData<TNext, TValue>, IInvertableValidationData<TNext, TValue>
	{
	}
}
