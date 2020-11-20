extern alias NewtonsoftValigator;
extern alias SystemTextValigator;
extern alias SystemTextAspNetCoreValigator;
extern alias NewtonsoftAspNetCoreValigator;
using Functional;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Buffers;
using System.Linq;
using System.Threading.Tasks;
using Valigator.TestApi.Core31.MappedGuid;

[assembly: ApiController]
namespace Valigator.TestApi
{

	public class NewtonsoftStartup
	{
		public NewtonsoftStartup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			NewtonsoftAspNetCoreValigator.Valigator.MvcBuilderExtensions.AddValigator(
				NewtonsoftAspNetCoreValigator.Valigator.MvcBuilderExtensions.AddValigatorJsonExceptionFilter(
					services
						.AddControllers()
						.AddNewtonsoftJson(opt =>
						{
							opt.SerializerSettings.Converters.Add(NewtonsoftMappedGuidConverter.Instance);
						})
						.ConfigureApiBehaviorOptions(opt =>
						{
							opt.SuppressMapClientErrors = true;
						}),
						valigatorJsonException => new JsonResult(valigatorJsonException.ErrorContext.Error.Message) { StatusCode = 400 }
					)
					.SetCompatibilityVersion(CompatibilityVersion.Version_3_0),
				errors => new JsonResult(errors) { StatusCode = 400 },
				errors => new JsonResult(errors.Select(e => new { Path = e.Path.ToString(), Message = e.Message }).ToArray()) { StatusCode = 400 }
			);
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

	public class SystemTextStartup
	{
		public SystemTextStartup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			SystemTextAspNetCoreValigator.Valigator.MvcBuilderExtensions.AddValigator(
				SystemTextAspNetCoreValigator.Valigator.MvcBuilderExtensions.AddValigatorJsonExceptionFilter(
					services
					.AddControllers()
					.AddJsonOptions(opt =>
					{
						opt.JsonSerializerOptions.Converters.Add(SystemTextMappedGuidConverter.Instance);
				
					}),
					valigatorJsonException => new JsonResult(valigatorJsonException.Message) { StatusCode = 400 })
					.SetCompatibilityVersion(CompatibilityVersion.Version_3_0),
				errors => new JsonResult(errors) { StatusCode = 400 },
				errors => new JsonResult(errors.Select(e => new { Path = e.Path.ToString(), Message = e.Message }).ToArray()) { StatusCode = 400 }
			);
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

		private class Filter : ExceptionFilterAttribute
		{
			public override void OnException(ExceptionContext context)
			{
				base.OnException(context);
			}

			public override Task OnExceptionAsync(ExceptionContext context)
			{
				return base.OnExceptionAsync(context);
			}
		}
	}
}