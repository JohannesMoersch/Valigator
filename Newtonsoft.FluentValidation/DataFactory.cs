using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.DataValidators;

namespace Newtonsoft.FluentValidation
{
	public static class Data
	{
		public static RequiredValidator<TValue> Required<TValue>()
			=> new RequiredValidator<TValue>();

		public static OptionalValidator<Option<TValue>> Optional<TValue>()
			=> new OptionalValidator<TValue>();

		public static OptionalWithDefaultValidator<TValue> Optional<TValue>(TValue defaultValue)
			=> new OptionalWithDefaultValidator<TValue>();
	}
}
