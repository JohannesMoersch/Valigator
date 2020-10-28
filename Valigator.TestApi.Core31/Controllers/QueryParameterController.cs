using Functional;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Threading.Tasks;

namespace Valigator.TestApi.Controllers
{
	[Route("QueryParameters")]
	public class QueryParameterController : ControllerBase
	{
		[HttpGet]
		public string Get([QueryParametersBinding]QueryParameters queryParameters, CancellationToken cancellationToken)
		=> $"{nameof(QueryParameters)} - {{ Value1: {queryParameters.Value1.Value.ValueOrDefault()}, Value2: {queryParameters.Value2.Value.ValueOrDefault()} }}";
	}

	[ValigatorModel]
	public class QueryParameters
	{
		public Data<Option<int>> Value1 { get; set; } = Data.Optional<int>();
		public Data<Option<int>> Value2 { get; set; } = Data.Optional<int>();
	}

	internal class QueryParametersBindingAttribute : ValidateModelBinderAttribute
	{
		private static readonly Data<QueryParameters> _data = Data.Required<QueryParameters>();

		public override BindingSource BindingSource => BindingSource.Query; // BindingSource.Query; // BindingSource.Query will result generation of OpenAPI json taking a veyr long time to complete (it may never complete).

		/// <inheritdoc />
		public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
		{
			var obj = new QueryParameters();

			bindingContext
				.ValueProvider
				.GetValue(nameof(QueryParameters.Value1))
				.TryFirst()
				.Do(
					value => obj.Value1 = Int32.TryParse(value, out var result) ? obj.Value1.WithValue(result) : obj.Value1.WithErrors(new[] { ValidationError.CreateMappingError(typeof(string), typeof(int)) }),
					() => { }
				);

			bindingContext
				.ValueProvider
				.GetValue(nameof(QueryParameters.Value2))
				.TryFirst()
				.Do(
					value => obj.Value2 = Int32.TryParse(value, out var result) ? obj.Value2.WithValue(result) : obj.Value2.WithErrors(new[] { ValidationError.CreateMappingError(typeof(string), typeof(int)) }),
					() => { }
				);

			return Task.FromResult(BindResult.Create(_data.WithValue(obj)));
		}
	}
}
