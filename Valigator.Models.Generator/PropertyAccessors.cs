﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator
{
	public enum PropertyAccessors
	{
		/// <summary>
		/// Unset tells the generator to use the parent classes attribute value.
		/// </summary>
		Unset = -1,
		Get = 0,
		GetAndSet = 1,
		GetAndInit = 2
	}
}
