using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Valigator.AspNetCore;

[assembly: ApiController]
namespace Valigator.TestApi
{
	internal class NullObjectModelValidator : IObjectModelValidator
	{
		public void Validate(ActionContext actionContext, ValidationStateDictionary validationState, string prefix, object model)
		{

		}
	}

	/// <summary>
	/// Handle unhandled exceptions by wrapping them in a Service Error and setting the status code to 500
	/// </summary>
	internal class UnhandledExceptionWrappingFilter : ExceptionFilterAttribute
	{
		private readonly IWebHostEnvironment _hostingEnvironment;

		public UnhandledExceptionWrappingFilter(IWebHostEnvironment hostingEnvironment)
		{
			_hostingEnvironment = hostingEnvironment;
		}

		public override void OnException(ExceptionContext context)
		{
		}
	}

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
				.AddSingleton<IObjectModelValidator, NullObjectModelValidator>() //TODO: Disable validation
				.AddControllers()
				//.ConfigureApiBehaviorOptions(opt =>
				//{
				//	opt.InvalidModelStateResponseFactory = Thing;
				//})
				//.AddMvcOptions(opt =>
				//{
				//	opt.Filters.Add<UnhandledExceptionWrappingFilter>();
				//})
				.SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
				.AddValigator(errors => new JsonResult(errors) { StatusCode = 400 }, errors => new JsonResult(errors.Select(e => new { Path = e.Path.ToString(), Message = e.Message }).ToArray()) { StatusCode = 400 });
		}

		private IActionResult Thing(ActionContext arg)
		{
			throw new NotImplementedException();
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
}
