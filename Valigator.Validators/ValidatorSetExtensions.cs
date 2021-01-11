using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Valigator.Core;
using Valigator.Validators;

namespace Valigator
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ValidatorSetExtensions
	{
		public static TNext Length<TNext>(this IInvertableValidationData<TNext, string> data, int length)
			=> data.WithValidator(new StringLengthValidator(length, length));

		public static TNext Length<TNext>(this IInvertableValidationData<TNext, string> data, int minimum, int maximum)
			=> data.WithValidator(new StringLengthValidator(minimum, maximum));

		public static TNext Count<TNext, TValue>(this IInvertableValidationData<TNext, IReadOnlyCollection<TValue>> data, int length)
			=> data.WithValidator(new CollectionCountValidator<TValue>(length, length));

		public static TNext Count<TNext, TValue>(this IInvertableValidationData<TNext, IReadOnlyCollection<TValue>> data, int minimum, int maximum)
			=> data.WithValidator(new CollectionCountValidator<TValue>(minimum, maximum));
	}
}
