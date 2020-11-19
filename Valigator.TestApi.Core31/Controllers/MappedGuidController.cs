using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Functional;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Valigator.Core.DataContainers.Factories;
using Valigator.Core.DataSources;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator.TestApi.Controllers
{
	[Route("mappedGuid")]
	public class MappedGuidController : ControllerBase
	{
		[HttpPost("mappedGuid")]
		public JsonResult MappedGuidEndpoint([FromBody] MappedGuidCollection bodyValue)
			=> new JsonResult(true);

		[HttpPost("mappedGuidHeader")]
		public JsonResult MappedGuidHeaderEndpoint([MappedGuidHelpers.ModelBindings.Required.Header] Data<MappedGuid> mappedGuid)
			=> new JsonResult(true);
	}

	[ValigatorModel]
	public class MappedGuidCollection
	{
		public Data<MappedGuidClass[]> Items { get; set; } = Data
			.Collection<MappedGuidClass>()
			.Required()
			.ItemCount(minimumItems: 1)
			.ElementsUnique(p => p.MappedGuid.TryGetValue().Match(Option.Some, _ => Option.None<MappedGuid>()), $"The {nameof(MappedGuidClass.MappedGuid)} must be unique for each element of {nameof(MappedGuid)}");
	}

	[ValigatorModel]
	public class MappedGuidClass
	{
		private static readonly Data<Guid> _data = Data.Required<Guid>().NotEmpty();

		public Data<MappedGuid> MappedGuid { get; set; } = Data.Required<MappedGuid>().MappedFrom<Guid>(CreateMappedGuid, _ => _data);

		private static MappedGuid CreateMappedGuid(Guid guid)
				=> new MappedGuid(guid);
	}

	public static class DataExtensions
	{
		/// <summary>
		/// Elements are Unique
		/// </summary>
		public static DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> ElementsUnique<TSource, TValue, TProperty>(
			this DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> collection,
			Func<TValue, Option<TProperty>> propertyComparison,
			string validationMessage)
			=> collection.Assert(validationMessage, coll => ValidateElements(coll, propertyComparison));

		/// <summary>
		/// ValidateElements
		/// </summary>
		private static bool ValidateElements<TValue, TProperty>(TValue[] elements, Func<TValue, Option<TProperty>> propertyComparison)
		{
			var set = new HashSet<TProperty>();
			foreach (var e in elements.Select(propertyComparison))
			{
				var result = e.Match(s => set.Add(s), () => true);

				if (!result)
					return result;
			}

			return true;
		}
	}

	public readonly struct MappedGuid : IEquatable<MappedGuid>
	{
		private readonly Option<Guid> _value;
		internal readonly Guid Value => _value.BindIfNone(() => throw new Exception()).ValueOrDefault();

		internal MappedGuid(Guid value)
			=> _value = Option.Some(value);

		public override readonly bool Equals(object obj)
			=> obj is MappedGuid mappedGuid && Equals(mappedGuid);

		public readonly bool Equals(MappedGuid other)
			=> _value == other._value;

		public override readonly int GetHashCode()
			=> _value.GetHashCode();

		public static bool operator ==(MappedGuid identifier1, MappedGuid identifier2)
			=> identifier1.Equals(identifier2);

		public static bool operator !=(MappedGuid identifier1, MappedGuid identifier2)
			=> !(identifier1 == identifier2);

		public override readonly string ToString()
			=> $"{Value}";
	}

	internal static class JsonReaderExtensions
	{
		public static Result<Guid, Exception> TryParseGuidValue<T>(this JsonReader reader)
			=> Result
				.Try(
					() => Option.FromNullable((string?)reader.Value).Select(x => x!),
					_ => new Exception("Value must be a valid Guid."))
				.Bind(o => o.ToResult(() => new Exception("Value must be a valid Guid.")))
				.Bind(TryParseGuid<T>);

		private static Result<Guid, Exception> TryParseGuid<T>(string value)
			=> Option
				.Create(Guid.TryParse(value, out var guidValue), () => guidValue)
				.ToResult(() => new Exception("Value must be a valid Guid."));

		public static Result<string?, Exception> TryGetStringValue<T>(this JsonReader reader)
			=> Result
				.Try(
					() => (string?)reader.Value,
					_ => new Exception("Value must be a valid string."));

		public static Result<int, Exception> TryGetIntValue<T>(this JsonReader reader)
			=> Result
				.Try(
					() => Option.FromNullable((int?)(long?)(dynamic?)reader.Value).ToResult(() => new Exception("Value must be a valid integer.")),
					_ => new Exception("Value must be a valid integer."))
				.Bind(x => x);

		public static Result<decimal, Exception> TryGetDecimalValue<T>(this JsonReader reader)
			=> TryCastToDecimal(reader.Value)
				.ToResult(() => new Exception("Value must be a valid decimal."));

		private static Option<decimal> TryCastToDecimal(object? value)
			=> value is long l ? Option.Some((decimal)l) :
				 value is int i ? Option.Some((decimal)i) :
				 value is double d ? Option.Some((decimal)d) :
				 Option.None<decimal>();
	}

	public class MappedGuidConverter : JsonConverter
	{
		public static readonly MappedGuidConverter Instance = new MappedGuidConverter();

		public override bool CanRead { get; } = true;
		public override bool CanWrite { get; } = true;

		public override bool CanConvert(Type objectType)
			=> objectType == typeof(MappedGuid);

		public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
			=> reader
				.TryParseGuidValue<MappedGuid>()
				.Bind(MappedGuidHelpers.Create)
				.Match(_ => _, e => throw e);

		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
			if (value == null)
				writer.WriteNull();
			else
				JToken.FromObject(((MappedGuid)value).Value).WriteTo(writer);
		}
	}

	public static class MappedGuidHelpers
	{
		public static Result<MappedGuid, Exception> Create(Guid MappedGuid)
			=> Valigator.Required.WithMappedValue(MappedGuid).Verify().TryGetValue().MapFailure(f => new Exception());

		public static Result<MappedGuid, Exception> Create(string MappedGuid)
			=> Guid.TryParse(MappedGuid, out var guid) ? Create(guid) : Result.Failure<MappedGuid, Exception>(new Exception($"'{MappedGuid}' must be a valid guid."));

		public static MappedGuid CreateNew() => new MappedGuid(Guid.NewGuid());

		public static class Valigator
		{
			private static readonly Data<Guid> _data = Data.Required<Guid>().NotEmpty();

			public static Data<MappedGuid> Required { get; } = Data.Required<MappedGuid>().MappedFrom<Guid>(CreateMappedGuid, _ => _data);

			public static Data<Option<MappedGuid>> Optional { get; } = Data.Optional<MappedGuid>().MappedFrom<Guid>(CreateMappedGuid, _ => _data);

			private static MappedGuid CreateMappedGuid(Guid guid)
				=> new MappedGuid(guid);
		}

		public abstract class MappedGuidValidateModelBinderAttribute : ValidateModelBinderAttribute
		{
			public abstract object GetData();
		}

		public static class ModelBindings
		{
			public static class Required
			{
				public abstract class BaseAttribute : MappedGuidValidateModelBinderAttribute
				{
					private readonly Data<MappedGuid> _data = Valigator.Required;

					public override object GetData() => _data;

					public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
						=> Task.FromResult(BindModelInternal(bindingContext));

					private BindResult BindModelInternal(ModelBindingContext bindingContext)
						=> BindResult.Create(GetGuidValue(bindingContext)
							.Match(
								s => _data.WithMappedValue(s),
								_data.WithErrors
							));

					private Result<Guid, ValidationError[]> GetGuidValue(ModelBindingContext bindingContext)
						=> Guid.TryParse(GetValue(bindingContext), out var guid)
							? Result.Success<Guid, ValidationError[]>(guid)
							: Result.Failure<Guid, ValidationError[]>(new[] { MappingError.Create("Error mapping input to Guid.", typeof(string), typeof(Guid)) });

					private string GetValue(ModelBindingContext bindingContext)
						=> bindingContext?.ValueProvider?.GetValue(bindingContext.FieldName).FirstOrDefault() ?? String.Empty;
				}

				public class PathAttribute : BaseAttribute
				{
					public override BindingSource BindingSource { get; } = BindingSource.Path;
				}

				public class QueryAttribute : BaseAttribute
				{
					public override BindingSource BindingSource { get; } = BindingSource.Query;
				}

				public class HeaderAttribute : BaseAttribute
				{
					public override BindingSource BindingSource { get; } = BindingSource.Header;
					public override string Name { get; set; } = "TheHeader";
				}
			}

			public static class Optional
			{
				public abstract class BaseAttribute : MappedGuidValidateModelBinderAttribute
				{
					private readonly Data<Option<MappedGuid>> _data = Valigator.Optional;

					public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
						=> Task.FromResult(BindModelInternal(bindingContext));

					private BindResult BindModelInternal(ModelBindingContext bindingContext)
						=> BindResult
							.Create(GetOptionGuidValue(bindingContext)
								.Match(
									s => s.Match(v => _data.WithMappedValue(v), () => _data.WithUncheckedValue(Option.None<MappedGuid>())),
									e => _data.WithErrors(e)
								));

					private Result<Option<Guid>, ValidationError[]> GetOptionGuidValue(ModelBindingContext bindingContext)
						=> GetValue(bindingContext).Match(
							some: value =>
								Guid.TryParse(value, out var guid)
									? Result.Success<Option<Guid>, ValidationError[]>(Option.Some(guid))
									: Result.Failure<Option<Guid>, ValidationError[]>(new[] { MappingError.Create("Error mapping input to Guid.", typeof(string), typeof(Guid)) }),
							none: () => Result.Success<Option<Guid>, ValidationError[]>(Option.None<Guid>()));

					private Option<string> GetValue(ModelBindingContext bindingContext)
						=> Option.FromNullable(bindingContext.ValueProvider.GetValue(bindingContext.FieldName).FirstOrDefault());

					public override object GetData() => _data;
				}

				public class PathAttribute : BaseAttribute
				{
					public override BindingSource BindingSource { get; } = BindingSource.Path;
				}

				public class QueryAttribute : BaseAttribute
				{
					public override BindingSource BindingSource { get; } = BindingSource.Query;
				}
			}
		}
	}
}
