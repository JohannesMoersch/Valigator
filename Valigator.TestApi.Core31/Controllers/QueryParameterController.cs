using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Valigator.TestApi.Controllers
{
	[Route("QueryParameters")]
	public class QueryParameterController : ControllerBase
	{
		[HttpGet]
		public string Get([QueryParametersBinding]QueryParameters queryParameters)
		=> $"{nameof(QueryParameters)} - {{ Value1: {queryParameters.Value1}, Value2: {queryParameters.Value2} }}";
	}

	[ValigatorModel]
	public class QueryParameters
	{
		public Data<int> Value1 { get; set; } = Data.Required<int>();
		public Data<string> Value2 { get; set; } = Data.Required<string>();
	}

	internal class QueryParametersBindingAttribute : ValidateModelBinderAttribute
	{
		private static readonly Data<QueryParameters> _data = Data.Required<QueryParameters>();

		public override BindingSource BindingSource => BindingSource.Query; // BindingSource.Query; // BindingSource.Query will result generation of OpenAPI json taking a veyr long time to complete (it may never complete).

		/// <inheritdoc />
		public override Task<BindResult> BindModel(ModelBindingContext bindingContext)
		{
			var obj = new QueryParameters();

			obj.Value1.WithValue(Int32.Parse(bindingContext
				.ValueProvider
				.GetValue(nameof(QueryParameters.Value1))
				.FirstValue));

			obj.Value2.WithValue( bindingContext
				.ValueProvider
				.GetValue(nameof(QueryParameters.Value2))
				.FirstValue);

			return Task.FromResult(BindResult.Create(_data.WithValue(obj)));
		}
	}
}
