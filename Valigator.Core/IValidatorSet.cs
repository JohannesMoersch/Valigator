using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IValidatorSet<TIn, TOut>
	{
		public Result<TOut, ValidationError[]> Process(TIn input);
	}
}
