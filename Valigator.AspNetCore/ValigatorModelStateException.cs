using System;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Valigator
{
	public class ValigatorModelStateException : Exception
	{
		public ValigatorModelStateException(ParameterDescriptor parameterDescriptor, params ValidationError[] errors)
		{
			ParameterDescriptor = parameterDescriptor;
			ValidationErrors = errors;
		}

		public ParameterDescriptor ParameterDescriptor { get; }
		public ValidationError[] ValidationErrors { get; }
	}
}
