﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IValidationData<TNext, TInput, TValue>
	{
		public TNext WithValidator(IValidator<TValue> value);
	}
}
