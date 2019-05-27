using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.ValueValidators;

namespace Newtonsoft.FluentValidation.DataSources
{
	public struct DefaultedNullableSource<TValue> : IDataSource<Option<TValue>>
	{
		private static DataValidator<DefaultedNullableSource<TValue>, PassthroughValidator<Option<TValue>>, Option<TValue>> Instance { get; } = new DataValidator<DefaultedNullableSource<TValue>, PassthroughValidator<Option<TValue>>, Option<TValue>>(default, default);

		public Data<Option<TValue>> Data
		{
			get
			{
				var instance = this;

				var validator = _defaultValue
					.Match
					(
						value => new DataValidator<DefaultedNullableSource<TValue>, PassthroughValidator<Option<TValue>>, Option<TValue>>(instance, default),
						() => Instance
					);

				return new Data<Option<TValue>>(validator);
			}
		}

		private readonly Option<TValue> _defaultValue;

		public DefaultedNullableSource(TValue defaultValue) 
			=> _defaultValue = Option.Some(defaultValue != null ? defaultValue : throw new ArgumentNullException(nameof(defaultValue)));

		public Result<Option<TValue>, ValidationError> Validate(object model, bool isSet, Option<TValue> value)
			=> Result.Success<Option<TValue>, ValidationError>(isSet ? value : _defaultValue);

		public static implicit operator Data<Option<TValue>>(DefaultedNullableSource<TValue> dataSource)
			=> dataSource.Data;
	}
}
