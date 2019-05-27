﻿using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation.ValueValidators
{
	public struct RangeValidator_Int32<TStateValidator> : IValueValidator<int>
		where TStateValidator : IDataSource<int>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Option<int> _lessThan;
		private readonly bool _lessThanOrEqualTo;
		private readonly Option<int> _greaterThan;
		private readonly bool _greaterThanOrEqualTo;

		public RangeValidator_Int32(TStateValidator stateValidator, int? lessThan, bool lessThanOrEqualTo, int? greaterThan, bool greaterThanOrEqualTo)
		{
			_stateValidator = stateValidator;

			_lessThan = Option.FromNullable(lessThan);
			_lessThanOrEqualTo = lessThanOrEqualTo;
			_greaterThan = Option.FromNullable(greaterThan);
			_greaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		public Result<Unit, ValidationError> Validate(int value)
		{
			var lessThanOrEqualTo = _lessThanOrEqualTo;
			var greaterThan = _greaterThan;
			var greaterThanOrEqualTo = _greaterThanOrEqualTo;

			return _lessThan
				.Match
				(
					lt => Result.Create(lessThanOrEqualTo ? value <= lt : value < lt, () => Unit.Value, () => new ValidationError("Test")),
					() => Result.Unit<ValidationError>()
				)
				.Match
				(
					success => greaterThan
						.Match
						(
							gt => Result.Create(greaterThanOrEqualTo ? value >= gt : value > gt, () => Unit.Value, () => new ValidationError("Test")),
							() => Result.Unit<ValidationError>()
						),
					Result.Failure<Unit, ValidationError>
				);
		}

		public static implicit operator Data<int>(RangeValidator_Int32<TStateValidator> valueValidator)
			=> new Data<int>(new DataValidator<TStateValidator, RangeValidator_Int32<TStateValidator>, int>(valueValidator._stateValidator, valueValidator));
	}
}