using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Valigator.Models.Generator.Tests
{
	public static class ObjectExtensions
	{
		public static TValue Do<TValue>(this TValue value, Action<TValue> action)
		{
			action.Invoke(value);

			return value;
		}

		public static void Throws<TValue, TException>(this TValue value, TException? exceptionType, Action<TValue> action)
			where TException : Exception
		{
			Assert.Throws<TException>(() => action.Invoke(value));
		}

		public static void Throws<TValue, TReturn, TException>(this TValue value, TException? exceptionType, Func<TValue, TReturn> action)
			where TException : Exception
		{
			Assert.Throws<TException>(() => action.Invoke(value));
		}
	}
}
