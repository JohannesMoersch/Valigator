﻿using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IInvertableValidator<TValue> : IValidator
	{
		Result<Unit, ValidationError> InverseValidate(TValue value);
	}
}
