using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public class RequiredNullableModelValidatorSet<TModel, TValue> : IValidatorSet<RequiredNullableModelValidatorSet<TModel, TValue>, ModelValue<TModel, Option<TValue>>, TValue>
	{
	}
}
