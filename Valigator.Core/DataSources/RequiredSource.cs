using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.DataSources
{
	public struct RequiredSource<TValue> : IDataSource<TValue>
	{
		private static DataValidator<RequiredSource<TValue>, PassthroughValidator<TValue>, TValue> Instance { get; } = new DataValidator<RequiredSource<TValue>, PassthroughValidator<TValue>, TValue>(default, default);

		public Data<TValue> Data => new Data<TValue>(Instance);

		public RequiredNullableSource<TValue> Nullable()
			=> new RequiredNullableSource<TValue>();

		public Result<TValue, ValidationError> Validate(object model, bool isSet, TValue value)
			=> isSet
				? (value != null ? Result.Success<TValue, ValidationError>(value) : Result.Failure<TValue, ValidationError>(new ValidationError("")))
				: Result.Failure<TValue, ValidationError>(new ValidationError(""));

		public static implicit operator Data<TValue>(RequiredSource<TValue> dataSource)
			=> dataSource.Data;
	}
}
