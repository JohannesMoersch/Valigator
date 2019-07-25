using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Valigator
{
	public class ValigatorModelStateException : Exception
	{
		public ValigatorModelStateException(string name, BindingSource source, params ValidationError[] errors)
		{
			Name = name;
			BindingSource = source;
			ValidationErrors = errors;
		}

		public string Name { get; }
		public BindingSource BindingSource { get; }
		public ValidationError[] ValidationErrors { get; }
	}
}
