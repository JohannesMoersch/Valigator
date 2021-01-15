using System;
using System.Collections.Generic;
using System.Text;
using Valigator;
using Valigator.Core;

namespace Valigator
{
	public static class RootValidationDataExtensions
	{
		public static TNext WithValidValidator<TNext, TValue>(this IRootValidationData<TNext, TValue> data)
			=> data.WithValidator(TestValidator<TValue>.Valid());

		public static TNext WithInvalidValidator<TNext, TValue>(this IRootValidationData<TNext, TValue> data)
			=> data.WithValidator(TestValidator<TValue>.Invalid());
	}
}
