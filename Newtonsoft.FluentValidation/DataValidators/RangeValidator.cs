using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation.DataValidators
{
	public struct RangeValidator_Int32 : IValueValidator<int>
	{
		public Result<Unit, ValidationError> Validate(int value) 
			=> throw new NotImplementedException();
	}
}
