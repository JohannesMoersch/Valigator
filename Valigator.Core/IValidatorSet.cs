using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IValidatorSet<TIn, TOut>
	{
		public ValidatorSetResult<TOut> Process(TIn input);
	}
}
