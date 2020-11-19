using System;
using System.Linq;
using Functional;
using Newtonsoft.Json;

namespace Valigator.TestApi.Core31
{
	internal static class JsonReaderExtensions
	{
		public static Result<Guid, Exception> TryParseGuidValue<T>(this JsonReader reader)
			=> Result
				.Try(
					() => Option.FromNullable((string)reader.Value).Select(x => x!),
					_ => new Exception("Value must be a valid Guid."))
				.Bind(o => o.ToResult(() => new Exception("Value must be a valid Guid.")))
				.Bind(TryParseGuid<T>);

		private static Result<Guid, Exception> TryParseGuid<T>(string value)
			=> Option
				.Create(Guid.TryParse(value, out var guidValue), () => guidValue)
				.ToResult(() => new Exception("Value must be a valid Guid."));

		public static Result<string, Exception> TryGetStringValue<T>(this JsonReader reader)
			=> Result
				.Try(
					() => (string)reader.Value,
					_ => new Exception("Value must be a valid string."));

		public static Result<int, Exception> TryGetIntValue<T>(this JsonReader reader)
			=> Result
				.Try(
					() => Option.FromNullable((int?)(long?)(dynamic)reader.Value).ToResult(() => new Exception("Value must be a valid integer.")),
					_ => new Exception("Value must be a valid integer."))
				.Bind(x => x);

		public static Result<decimal, Exception> TryGetDecimalValue<T>(this JsonReader reader)
			=> TryCastToDecimal(reader.Value)
				.ToResult(() => new Exception("Value must be a valid decimal."));

		private static Option<decimal> TryCastToDecimal(object value)
			=> value is long l ? Option.Some((decimal)l) :
				 value is int i ? Option.Some((decimal)i) :
				 value is double d ? Option.Some((decimal)d) :
				 Option.None<decimal>();
	}
}
