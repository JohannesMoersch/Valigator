using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Tests
{
	public static class ResultExtensions
	{
		public static TSuccess AssertSuccess<TSuccess, TFailure>(this Result<TSuccess, TFailure> result)
			=> result.Match(_ => _, _ => throw new Exception("Expected success but found failure."));

		public static TFailure AssertFailure<TSuccess, TFailure>(this Result<TSuccess, TFailure> result)
			=> result.Match(_ => throw new Exception("Expected failure but found success."), _ => _);
	}
}
