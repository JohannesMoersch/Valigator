using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.Helpers
{
	internal static class DataExtensions
	{
		public static Result<TValue[], ValidationError[]> VerifyCollection<TValue>(this Data<TValue> data, object model, TValue[] value)
		{
			var result = new TValue[value.Length];

			List<ValidationError> errors = null;

			for (int i = 0; i < value.Length; ++i)
			{
				if (data.WithValue(value[i]).Verify(model).TryGetValue().TryGetValue(out var success, out var failure))
					result[i] = success;
				else
					(errors = (errors ?? new List<ValidationError>())).AddRange(AddIndexToErrors(failure, i));
			}

			if (errors != null)
				return Result.Failure<TValue[], ValidationError[]>(errors.ToArray());

			return Result.Success<TValue[], ValidationError[]>(result);
		}

		private static ValidationError[] AddIndexToErrors(ValidationError[] errors, int index)
		{
			if (errors != null)
			{
				foreach (var error in errors)
					error.Path.AddIndex(index);
			}

			return errors;
		}
	}
}
