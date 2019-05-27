using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.ValueValidators;

namespace Newtonsoft.FluentValidation.DataSources
{
	public class OptionalNullableSource<TValue> : IDataSource<Option<TValue>>
	{
		private static DataValidator<OptionalNullableSource<TValue>, PassthroughValidator<Option<TValue>>, Option<TValue>> Instance { get; } = new DataValidator<OptionalNullableSource<TValue>, PassthroughValidator<Option<TValue>>, Option<TValue>>(default, default);

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(Instance);

		public Result<Option<TValue>, ValidationError> Validate(object model, bool isSet, Option<TValue> value)
			=> Result.Success<Option<TValue>, ValidationError>(value);

		public static implicit operator Data<Option<TValue>>(OptionalNullableSource<TValue> dataSource)
			=> dataSource.Data;
	}
}
