using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IValidatorSet<TValue>
	{
		IReadOnlyList<IValidator<TValue>> Validators { get; }
	}
}
