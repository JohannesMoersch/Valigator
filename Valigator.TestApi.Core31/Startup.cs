using System;
using System.Buffers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using Newtonsoft.Json;
using Valigator.AspNetCore;
using Valigator.TestApi.Controllers;

[assembly: ApiController]
namespace Valigator.TestApi
{

	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			services
				.AddSingleton<IObjectModelValidator, NullObjectModelValidator>() //Disables ASP.NET Core validation because it skips over the ValigatorFilter and, as a result, the AddValigator Funcs will not be called.
				.AddSingleton<IClientErrorFactory, NullClientErrorFactory>()
				.AddControllers(opt =>
				{
					var ori = opt.InputFormatters.First();
					opt.InputFormatters.Clear();
					opt.InputFormatters.Add(new CustomNewtonsoftJsonInputFormatter(ori));
				})
				.AddNewtonsoftJson(opt =>
				{
					opt.SerializerSettings.Converters.Add(MappedGuidConverter.Instance);
				})
				.SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
				.AddValigator(errors => new JsonResult(errors) { StatusCode = 400 }, errors => new JsonResult(errors.Select(e => new { Path = e.Path.ToString(), Message = e.Message }).ToArray()) { StatusCode = 400 });
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			app.UseStaticFiles();
			app.UseRouting();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}

	public class CustomNewtonsoftJsonInputFormatter : TextInputFormatter, IInputFormatterExceptionPolicy
	{
		private readonly NewtonsoftJsonInputFormatter _inner;

		public CustomNewtonsoftJsonInputFormatter(TextInputFormatter inner) : base()
		{
			_inner = inner;
		}

		public InputFormatterExceptionPolicy ExceptionPolicy { get; } = InputFormatterExceptionPolicy.MalformedInputExceptions;

		public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding)
			=> _inner.ReadRequestBodyAsync(context, encoding);
	}

	public class NullClientErrorFactory : ProblemDetailsFactory, IClientErrorFactory
	{
		public override ProblemDetails CreateProblemDetails(HttpContext httpContext, int? statusCode = null, string title = null, string type = null, string detail = null, string instance = null)
		{
			throw new NotImplementedException();
		}

		public override ValidationProblemDetails CreateValidationProblemDetails(HttpContext httpContext, ModelStateDictionary modelStateDictionary, int? statusCode = null, string title = null, string type = null, string detail = null, string instance = null)
		{
			throw new NotImplementedException();
		}

		public IActionResult GetClientError(ActionContext actionContext, IClientErrorActionResult clientError)
		{
			return new JsonResult("");
		}
	}
}
