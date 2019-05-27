using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.ValueValidators;

namespace Newtonsoft.FluentValidation.DataSources
{
	public struct RequiredNullableSource<TValue> : IDataSource<Option<TValue>>
	{
		private static DataValidator<RequiredNullableSource<TValue>, PassthroughValidator<Option<TValue>>, Option<TValue>> Instance { get; } = new DataValidator<RequiredNullableSource<TValue>, PassthroughValidator<Option<TValue>>, Option<TValue>>(default, default);

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(Instance);

		public Result<Option<TValue>, ValidationError> Validate(object model, bool isSet, Option<TValue> value)
			=> isSet
			? Result.Success<Option<TValue>, ValidationError>(value)
			: Result.Failure<Option<TValue>, ValidationError>(new ValidationError(""));

		public static implicit operator Data<Option<TValue>>(RequiredNullableSource<TValue> dataSource)
			=> dataSource.Data;
	}
}
