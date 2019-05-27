using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.DataSources
{
	public struct DefaultedSource<TValue> : IDataSource<TValue>
	{
		private static DataValidator<DefaultedSource<TValue>, PassthroughValidator<TValue>, TValue> Instance { get; } = new DataValidator<DefaultedSource<TValue>, PassthroughValidator<TValue>, TValue>(default, default);

		public Data<TValue> Data
		{
			get
			{
				var instance = this;

				var validator = _defaultValue
					.Match
					(
						value => new DataValidator<DefaultedSource<TValue>, PassthroughValidator<TValue>, TValue>(instance, default),
						() => Instance
					);

				return new Data<TValue>(validator);
			}
		}

		private readonly Option<TValue> _defaultValue;

		public DefaultedSource(TValue defaultValue)
			=> _defaultValue = Option.Some(defaultValue != null ? defaultValue : throw new ArgumentNullException(nameof(defaultValue)));

		public DefaultedNullableSource<TValue> Nullable()
			=> _defaultValue
				.Match
				(
					value => new DefaultedNullableSource<TValue>(value),
					() => new DefaultedNullableSource<TValue>()
				);

		public Result<TValue, ValidationError> Validate(object model, bool isSet, TValue value)
			=> !isSet || value != null
				? Result.Success<TValue, ValidationError>(isSet ? value : _defaultValue.Match(_ => _, () => default))
				: Result.Failure<TValue, ValidationError>(new ValidationError("Value cannot be null."));

		public static implicit operator Data<TValue>(DefaultedSource<TValue> dataSource)
			=> dataSource.Data;
	}
}
