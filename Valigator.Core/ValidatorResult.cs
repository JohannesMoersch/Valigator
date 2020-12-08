using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public struct ValidatorResult : IEquatable<ValidatorResult>
	{
		private readonly Unit? _success;

		private readonly ValidationError[]? _failure;

		private ValidatorResult(Unit? success, ValidationError[]? failure)
		{
			_success = success;
			_failure = failure;
		}

		public TResult Match<TResult>(Func<Unit, TResult> success, Func<ValidationError[], TResult> failure)
		{
			if (success == null)
				throw new ArgumentNullException(nameof(success));

			if (failure == null)
				throw new ArgumentNullException(nameof(failure));

			return _success.HasValue ? success.Invoke(_success.Value) : (_failure is not null ? failure.Invoke(_failure) : throw new ResultNotInitializedException());
		}

		public bool Equals(ValidatorResult other)
			=> EqualityComparer<Unit?>.Default.Equals(_success, other._success) && EqualityComparer<ValidationError[]?>.Default.Equals(_failure, other._failure);

		public override int GetHashCode()
			=> _success.HasValue ? _success.Value.GetHashCode() * 31 : (_failure is not null ? _failure.GetHashCode() * 31 : throw new ResultNotInitializedException());

		public override bool Equals(object obj)
			=> obj is ValidatorResult result && Equals(result);

		public override string ToString()
			=> _success.HasValue ? $"Success:{_success.Value}" : $"Failure:{_failure}";

		public static bool operator ==(ValidatorResult left, ValidatorResult right)
			=> left.Equals(right);

		public static bool operator !=(ValidatorResult left, ValidatorResult right)
			=> !left.Equals(right);

		public static ValidatorResult Success()
			=> new ValidatorResult(Unit.Value, default);

		public static ValidatorResult Failure(ValidationError[] errors)
			=> new ValidatorResult(default, errors);
	}
}
