using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidations.Tests
{
	public static class ResultExtensions
	{
		public static TSuccess AssureSuccess<TSuccess, TFailure>(this Result<TSuccess, TFailure> result)
			=> result.Match(_ => _, _ => throw new Exception("Expected success but found failure."));

		public static TFailure AssureFailure<TSuccess, TFailure>(this Result<TSuccess, TFailure> result)
			=> result.Match(_ => throw new Exception("Expected failure but found success."), _ => _);
	}
}
