using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public static class ValidatorSetResult
	{
		public static ValidatorSetResult<TValue> Success<TValue>(TValue success)
			=> new ValidatorSetResult<TValue>(success, default);

		public static ValidatorSetResult<TValue> Failure<TValue>(ValidationError[] errors)
			=> new ValidatorSetResult<TValue>(default, errors);
	}

	public struct ValidatorSetResult<TValue> : IEquatable<ValidatorSetResult<TValue>>
	{
		private readonly TValue? _success;

		private readonly ValidationError[]? _failure;

		internal ValidatorSetResult(TValue? success, ValidationError[]? failure)
		{
			_success = success;
			_failure = failure;
		}

		public TResult Match<TResult>(Func<TValue, TResult> success, Func<ValidationError[], TResult> failure)
		{
			if (success == null)
				throw new ArgumentNullException(nameof(success));

			if (failure == null)
				throw new ArgumentNullException(nameof(failure));

			return _success is not null ? success.Invoke(_success) : (_failure is not null ? failure.Invoke(_failure) : throw new ResultNotInitializedException());
		}

		public bool Equals(ValidatorSetResult<TValue> other)
			=> EqualityComparer<TValue?>.Default.Equals(_success, other._success) && EqualityComparer<ValidationError[]?>.Default.Equals(_failure, other._failure);

		public override int GetHashCode()
			=> _success is not null ? _success.GetHashCode() * 31 : (_failure is not null ? _failure.GetHashCode() * 31 : throw new ResultNotInitializedException());

		public override bool Equals(object obj)
			=> obj is ValidatorSetResult<TValue> result && Equals(result);

		public override string ToString()
			=> _success is not null ? $"Success:{_success}" : $"Failure:{_failure}";

		public static bool operator ==(ValidatorSetResult<TValue> left, ValidatorSetResult<TValue> right)
			=> left.Equals(right);

		public static bool operator !=(ValidatorSetResult<TValue> left, ValidatorSetResult<TValue> right)
			=> !left.Equals(right);
	}
}
