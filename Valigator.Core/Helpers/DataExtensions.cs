using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.Helpers
{
	internal static class DataExtensions
	{
		public static Result<TValue[], ValidationError> VerifyCollection<TValue>(this Data<TValue> data, object model, TValue[] value)
		{
			var result = new TValue[value.Length];

			for (int i = 0; i < value.Length; ++i)
			{
				if (!data.WithValue(value[i]).Verify(model).TryGetValue(out var success, out var failure))
					return Result.Failure<TValue[], ValidationError>(failure);

				result[i] = success;
			}

			return Result.Success<TValue[], ValidationError>(result);
		}
	}
}
