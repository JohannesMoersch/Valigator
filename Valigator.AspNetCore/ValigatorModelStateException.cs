using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Valigator
{
	internal class ValigatorModelStateException : Exception
	{
		public ValigatorModelStateException(string name, BindingSource source, params ValidationError[] errors)
		{
			Name = name;
			Source = source;
			ValidationErrors = errors;
		}

		public string Name { get; }
		public BindingSource Source { get; }
		public ValidationError[] ValidationErrors { get; }
	}
}
