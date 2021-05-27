using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Valigator.Core;
using Valigator.ModelPropertyFactories;
using Valigator.ModelValidationData;

namespace Valigator
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ModelValuePropertyFactoryExtensions
	{
		public static DefaultedValueModelValidationData<TModel, TValue> Defaulted<TModel, TValue>(this ModelValuePropertyFactory<TModel, TValue> factory)
			where TValue : struct
			=> factory.Defaulted(() => default);
	}
}
