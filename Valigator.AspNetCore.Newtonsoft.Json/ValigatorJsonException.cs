﻿using Newtonsoft.Json.Serialization;
using System;

namespace Valigator.AspNetCore.Newtonsoft.Json
{
	public class ValigatorJsonException : Exception
	{
		public ValigatorJsonException(ErrorContext errorContext)
		{
			ErrorContext = errorContext;
		}

		public ErrorContext ErrorContext { get; }
	}
}