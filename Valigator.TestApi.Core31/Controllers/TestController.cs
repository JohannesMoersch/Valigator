using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Functional;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Valigator.TestApi.Core31.Controllers
{
	[Route("test")]
	public class TestController : ControllerBase
	{
		[HttpGet("header")]
		public JsonResult Header([DefaultedModelBinder]Option<string> header)
			=> new JsonResult(header.Match(_ => _, () => null));

		[HttpPost("post")]
		public JsonResult Post([FromBody] InnerBodyClass bodyValue)
			=> new JsonResult("Success");

		[HttpPost("post2")]
		public JsonResult Post([FromBody] GuidBodyClass bodyValue)
			=> new JsonResult("Success");
	}

	public class GuidBodyClass
	{
		public Data<GuidInnerClass[]> IdentifierCollection { get; set; } = Data.Collection<GuidInnerClass>().Required().ItemCount(1);
	}

	public class GuidInnerClass
	{
		public Data<Guid> TheIdentifier { get; set; } = Data.Required<Guid>().NotEmpty();
	}

	public class InnerBodyClass
	{
		public Data<InnerClass[]> IdentifierCollection { get; set; } = Data.Collection<InnerClass>().Required().ItemCount(1);
	}

	public class InnerClass
	{
		public Data<Identifier> TheIdentifier { get; set; } = Identifier.Valigator.Required;
	}

	public struct Identifier : IEquatable<Identifier>
	{
		private readonly Guid? _value;
		public Guid Value => _value ?? throw new Exception("Identifier issue");

		private Identifier(Guid value)
			=> _value = value;

		public override bool Equals(object obj)
			=> obj is Identifier ProductSku && Equals(ProductSku);

		public override int GetHashCode()
			=> -1937169414 + EqualityComparer<Guid?>.Default.GetHashCode(_value);

		public bool Equals(Identifier other)
			=> _value == other._value;

		public static bool operator ==(Identifier identifier1, Identifier identifier2)
			=> identifier1.Equals(identifier2);

		public static bool operator !=(Identifier identifier1, Identifier identifier2)
			=> !(identifier1 == identifier2);

		public override string ToString()
			=> $"{nameof(Identifier)}:{Value}";

		public static Result<Identifier, string> Create(Guid guid)
			=> Result
				.Create
				(
					guid != Guid.Empty,
					() => new Identifier(guid),
					() => "Value cannot be empty Guid."
				);

		public static Result<Identifier, string> Create(string guid)
			=> Guid.TryParse(guid, out var value) ? Create(value) : Result.Failure<Identifier, string>($"'{guid}' must be a valid guid.");

		public static class Valigator
		{
			private static readonly Data<Guid> _data = Data.Required<Guid>().NotEmpty();

			public static Data<Identifier> Required
				=> Data.Required<Identifier>().MappedFrom<Guid>(CreateLineItemIdentifier, _ => _data);

			private static Result<Identifier, ValidationError[]> CreateLineItemIdentifier(Guid guid)
				=> _data.WithValue(guid).Verify().TryGetValue().Select(x => new Identifier(x));
		}
	}

	public class DefaultedModelBinder : ValidateModelBinderAttribute
	{
		private readonly Data<Option<string>> _data = Data.Defaulted("Default").Nullable();

		public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
			=> Task
				.FromResult
				(
					BindResult.Create(
						Option.FromNullable(bindingContext
						.HttpContext
						.Request
						.Headers
						.FirstOrDefault(s => s.Key.ToLower() == "testheader")
						.Value
						.FirstOrDefault())
						.Match(s => _data.WithValue(Option.Some(s)), () => _data)
					)
				);
	}
}
