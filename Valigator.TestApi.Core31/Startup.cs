using Functional;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Buffers;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Valigator.AspNetCore;
using Valigator.AspNetCore.Newtonsoft.Json;
//using Valigator.Newtonsoft.Json;
using Valigator.TestApi.Core31.MappedGuid;

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
				/**** Newtonsoft ****/
				.AddControllers()
				.AddNewtonsoftJson(opt =>
				{
					opt.SerializerSettings.Converters.Add(NewtonsoftMappedGuidConverter.Instance);
				})
				.AddValigatorJsonExceptionFilter(valigatorJsonException => new JsonResult(valigatorJsonException.ErrorContext.Error.Message) { StatusCode = 444 })
				.ConfigureApiBehaviorOptions(opt =>
				{
					opt.SuppressMapClientErrors = true;
				})

				/**** System.Text ****/
				//.AddControllers()
				//.AddJsonOptions(opt =>
				//{
				//	opt.JsonSerializerOptions.Converters.Add(SystemTextMappedGuidConverter.Instance);
				//})

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
}
