using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.DataValidators;
using Newtonsoft.FluentValidation.StateValidators;

namespace Newtonsoft.FluentValidation
{
	public static class Data
	{
		public static RequiredValidator<TValue> Required<TValue>()
			=> new RequiredValidator<TValue>();

		public static OptionalValidator<TValue> Optional<TValue>()
			=> new OptionalValidator<TValue>();

		public static OptionalWithDefaultValidator<TValue> Optional<TValue>(TValue defaultValue)
			=> new OptionalWithDefaultValidator<TValue>(defaultValue);
	}
}
