using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

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
				.AddOpenApiDocument(c =>
				{
					c.Title = "Title";
				})
				.AddSingleton<IModelMetadataProvider>(p => new ValigatorModelMetadataProvider(p.GetRequiredService<ICompositeMetadataDetailsProvider>()))
				.AddControllers()
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

				endpoints.MapGet("/", async context =>
				{
					context.Response.Redirect("/swagger/v1/swagger.json");
					await context.Response.CompleteAsync();
				});
			});
			app.UseOpenApi();
		}
	}

	public class ValigatorModelMetadataProvider : IModelMetadataProvider
	{
		private readonly IModelMetadataProvider _inner;
		private readonly ICompositeMetadataDetailsProvider detailsProvider;

		public ValigatorModelMetadataProvider(ICompositeMetadataDetailsProvider detailsProvider)
		{
			_inner = new DefaultModelMetadataProvider(detailsProvider);
			this.detailsProvider = detailsProvider;
		}

		public IEnumerable<ModelMetadata> GetMetadataForProperties(Type modelType)
		{
			var valigatorAttributes = modelType.CustomAttributes.Where(t => t.AttributeType == typeof(ValigatorModelAttribute)).ToArray();
			if (!valigatorAttributes.Any())
				return _inner.GetMetadataForProperties(modelType);
			return GetPropertyMetadata(modelType, valigatorAttributes);
		}

		private IEnumerable<ModelMetadata> GetPropertyMetadata(Type containerType, CustomAttributeData[] valigatorAttributes)
			=> containerType
				.GetProperties()
				.Select(prop => new CustomPropertyInfo(prop))
				.Select(prop => new DefaultModelMetadata(this, detailsProvider, new DefaultMetadataDetails(ModelMetadataIdentity.ForProperty(prop, prop.PropertyType, containerType), ModelAttributes.GetAttributesForProperty(containerType, prop, prop.PropertyType))));

		public ModelMetadata GetMetadataForType(Type modelType)
		{
			//TODO: Probably should do this if there are Data in the body
			var valigatorAttributes = modelType.CustomAttributes.Where(t => t.AttributeType == typeof(ValigatorModelAttribute)).ToArray();
			if (!valigatorAttributes.Any())
				return _inner.GetMetadataForType(modelType);
			return GetModelMetadata(modelType, valigatorAttributes);
		}

		private ModelMetadata GetModelMetadata(Type modelType, IEnumerable<CustomAttributeData> valigatorAttributes)
		{
			return new DefaultModelMetadata(this, detailsProvider, new DefaultMetadataDetails(ModelMetadataIdentity.ForType(modelType), ModelAttributes.GetAttributesForType(modelType)));
		}

		private class CustomPropertyInfo : PropertyInfo
		{
			private readonly PropertyInfo _inner;

			public CustomPropertyInfo(PropertyInfo inner) 
			{
				_inner = inner;
			}

			public override PropertyAttributes Attributes => _inner.Attributes;

			public override bool CanRead => _inner.CanRead;

			public override bool CanWrite => _inner.CanWrite;

			public override Type PropertyType => _inner.PropertyType.IsGenericType && _inner.PropertyType.GetGenericTypeDefinition() == typeof(Data<>) ? _inner.PropertyType.GenericTypeArguments.First() : _inner.PropertyType;

			public override Type DeclaringType => _inner.DeclaringType;

			public override string Name => _inner.Name;

			public override Type ReflectedType => _inner.ReflectedType;

			public override MethodInfo[] GetAccessors(bool nonPublic)
				=> _inner.GetAccessors(nonPublic);

			public override object[] GetCustomAttributes(bool inherit)
				=> _inner.GetCustomAttributes(inherit);

			public override object[] GetCustomAttributes(Type attributeType, bool inherit)
				=> _inner.GetCustomAttributes(attributeType, inherit);

			public override MethodInfo GetGetMethod(bool nonPublic)
				=> _inner.GetGetMethod(nonPublic);

			public override ParameterInfo[] GetIndexParameters()
				=> _inner.GetIndexParameters();

			public override MethodInfo GetSetMethod(bool nonPublic)
				=> _inner.GetSetMethod(nonPublic);

			public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
				=> _inner.GetValue(obj, invokeAttr, binder, index, culture);

			public override bool IsDefined(Type attributeType, bool inherit)
				=> _inner.IsDefined(attributeType, inherit);

			public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
				=> _inner.SetValue(obj, value, invokeAttr, binder, index, culture);
		}

	}
}
