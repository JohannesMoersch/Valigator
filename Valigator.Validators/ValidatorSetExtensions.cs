using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Validators
{
	public static class ValidatorSetExtensions
	{
		public static TNext Length<TNext, TInput>(this IInvertableValidationData<TNext, TInput, string> data, int length)
			=> data.WithValidator(new StringLengthValidator(length, length));
	}
}
