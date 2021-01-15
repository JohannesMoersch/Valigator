using System;
using System.Collections.Generic;
using System.Text;
using Valigator;
using Valigator.Core;

namespace Valigator
{
	public static class RootModelValidationDataExtensions
	{
		public static TNext WithValidValidator<TModel, TNext, TValue>(this IRootModelValidationData<TNext, TModel, TValue> data)
			=> data.WithValidator(TestModelValidator<TModel, TValue>.Valid());

		public static TNext WithInvalidValidator<TModel, TNext, TValue>(this IRootModelValidationData<TNext, TModel, TValue> data)
			=> data.WithValidator(TestModelValidator<TModel, TValue>.Invalid());
	}
}
