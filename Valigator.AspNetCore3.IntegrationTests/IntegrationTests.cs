using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Interrogator.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Valigator.TestApi;
using Valigator.TestApi.Controllers;
using Xunit;
using Microsoft.AspNetCore.Hosting;

namespace Valigator.AspNetCore3.IntegrationTests
{
	public class IntegrationTests
	{
		private static HttpClient CreateNewtonsoftClient()
			=> new WebApplicationFactory<NewtonsoftStartup>().WithWebHostBuilder(builder => builder.UseStartup<NewtonsoftStartup>()).CreateClient();

		private static HttpClient CreateSystemTextClient()
			=> new WebApplicationFactory<SystemTextStartup>().WithWebHostBuilder(builder => builder.UseStartup<SystemTextStartup>()).CreateClient();

		public class HttpClientCreator : HttpClientCreatorWithAnonymousUrl
		{
			public override IEnumerator<object[]> GetEnumerator()
			{
				var baseEnumerator = base.GetEnumerator();

				while(baseEnumerator.MoveNext())
				{
					yield return new[] { baseEnumerator.Current[0] };
				}
			}

		}

		public class HttpClientCreatorWithAnonymousUrl : IEnumerable<object[]>
		{
			public virtual IEnumerator<object[]> GetEnumerator()
			{
				//yield return new object[] { CreateNewtonsoftClient(), "test/newtonsoftAnonymousObjectOutput" };
				yield return new object[] { CreateSystemTextClient(), "test/systemTextAnonymousObjectOutput" };
			}

			IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
		}

		[Theory]
		[ClassData(typeof(HttpClientCreator))]
		public Task WithValue(HttpClient client)
			=> client
				.BuildTest()
				.Get("test/header")
				.WithHeader("testheader", "Value")
				.Send()
				.IsOk()
				.AssertJsonBody(str => str.Should().Be(@"""Value"""));

		[Theory]
		[ClassData(typeof(HttpClientCreator))]
		public Task WithWhitespace(HttpClient client)
			=> client
				.BuildTest()
				.Get("test/header")
				.WithHeader("testheader", " ")
				.Send()
				.IsOk()
				.AssertJsonBody(str => str.Should().Be(@""" """));

		[Theory]
		[ClassData(typeof(HttpClientCreator))]
		public Task WithUnSet(HttpClient client)
			=> client
				.BuildTest()
				.Get("test/header")
				.Send()
				.IsOk()
				.AssertJsonBody(str => str.Should().Be(@"""Default"""));

		[Theory]
		[ClassData(typeof(HttpClientCreator))]
		public Task PostWithIdentifiers(HttpClient client)
			=> client
				.BuildTest()
				.Post("test/post")
				.WithJsonBody($"{{ \"{nameof(BodyClass.IdentifierCollection)}\": [ {{\"{nameof(InnerClass.TheIdentifier)}\" : \"61f45cfd-6389-4380-a803-c23881e982af\"}} ] }}")
				.Send()
				.IsSuccess()
				.AssertJsonBody(str =>
				{
					str.Should().Be("[\"61f45cfd-6389-4380-a803-c23881e982af\"]");
				});

		[Theory]
		[ClassData(typeof(HttpClientCreator))]
		public Task PostWithIdentifiersGuidVersion(HttpClient client)
			=> client
				.BuildTest()
				.Post("test/post2")
				.WithJsonBody($"{{ \"{nameof(BodyClass.IdentifierCollection)}\": [ {{\"{nameof(InnerClass.TheIdentifier)}\" : \"61f45cfd-6389-4380-a803-c23881e982af\"}} ] }}")
				.Send()
				.IsSuccess()
				.AssertJsonBody(str =>
				{
					str.Should().Be("[\"61f45cfd-6389-4380-a803-c23881e982af\"]");
				});

		[Theory]
		[ClassData(typeof(HttpClientCreatorWithAnonymousUrl))]
		public Task AnonymousObjectOutputTest(HttpClient client, string url)
			=> client
				.BuildTest()
				.Post(url)
				.WithJsonBody($"{{ \"{nameof(BodyClass.IdentifierCollection)}\": [ {{\"{nameof(InnerClass.TheIdentifier)}\" : \"61f45cfd-6389-4380-a803-c23881e982af\"}} ] }}")
				.Send()
				.IsSuccess()
				.AssertJsonBody(str =>
				{
					str.Should().Be("{\"TheOutputOfThePost\":[{\"TheIdentifier\":\"61f45cfd-6389-4380-a803-c23881e982af\"}],\"SecondValue\":1}");
				});

		[Theory]
		[ClassData(typeof(HttpClientCreator))]
		public Task ObjectWithNonDataPropertyTest(HttpClient client)
			=> client
				.BuildTest()
				.Post("test/nonDataPropertyObject")
				.WithJsonBody($"{{ \"{nameof(BodyClass.IdentifierCollection)}\": [ {{\"{nameof(InnerClass.TheIdentifier)}\" : \"61f45cfd-6389-4380-a803-c23881e982af\"}} ] }}")
				.Send()
				.IsSuccess()
				.AssertJsonBody(str =>
				{
					str.Should().Be("{\"IdentifierCollection\":[{\"TheIdentifier\":\"61f45cfd-6389-4380-a803-c23881e982af\"}],\"SecondValue\":1}");
				});

		[Theory]
		[ClassData(typeof(HttpClientCreator))]
		public Task MappedGuidEndpointReturnsProperError(HttpClient client)
			=> client
				.BuildTest()
				.Post("mappedGuid/mappedGuid")
				.WithJsonBody($"{{\"Items\":[{{\"MappedGuid\":\"NotAGuid\"}}]}}")
				.Send()
				.IsBadRequest()
				.AssertJsonBody(str =>
				{
					str
						.Should()
						.Be("\"Error converting value \\\"NotAGuid\\\" to type 'System.Guid'. Path 'Items[0].MappedGuid', line 1, position 34.\"");
				});

		[Theory]
		[ClassData(typeof(HttpClientCreator))]
		public async Task MultipleMappedGuidEndpointCallsReturnsProperErrors(HttpClient client)
		{
			await MappedGuidEndpointReturnsProperError(client);
			await MappedGuidEndpointReturnsProperError(client);
		}

		[Theory]
		[ClassData(typeof(HttpClientCreator))]
		public Task MappedGuidEndpointWorks(HttpClient client)
			=> client
				.BuildTest()
				.Post("mappedGuid/mappedGuid")
				.WithJsonBody($"{{\"Items\":[{{\"MappedGuid\":\"61f45cfd-6389-4380-a803-c23881e982af\"}}]}}")
				.Send()
				.IsSuccess()
				.AssertJsonBody(str =>
				{
					str.Should().Be("true");
				});

		[Theory]
		[ClassData(typeof(HttpClientCreator))]
		public Task MappedGuidHeaderEndpointWorks(HttpClient client)
			=> client
				.BuildTest()
				.Post("mappedGuid/mappedGuidHeader")
				.WithHeader("TheHeader", "61f45cfd-6389-4380-a803-c23881e982af")
				.WithJsonBody("")
				.Send()
				.IsBadRequest()
				.AssertJsonBody(str =>
				{
					str
						.Should()
						.Match<string>(str =>
							// Newtonsoft
							str == "[{\"name\":\"TheHeader\",\"source\":1,\"validationError\":{\"message\":\"Error mapping input to Guid.\",\"path\":{},\"valueDescriptor\":{\"fromType\":\"System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e\",\"toType\":\"System.Guid, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e\"}}}]"
						||
							// System.Text
							str == "[{\"name\":\"TheHeader\",\"source\":1,\"validationError\":{\"message\":\"Error mapping input to Guid.\",\"path\":{},\"valueDescriptor\":{}}}]"
						);
				});

		[Theory]
		[ClassData(typeof(HttpClientCreator))]
		public Task MappedGuidHeaderEndpointReturnsProperError(HttpClient client)
			=> client
				.BuildTest()
				.Post("mappedGuid/mappedGuidHeader")
				.WithHeader("TheHeader", "NotAGuid")
				.WithJsonBody("")
				.Send()
				.IsBadRequest()
				.AssertJsonBody(str =>
				{
					str
						.Should()
						.Match<string>(str =>
							// Newtonsoft
							str == "[{\"name\":\"TheHeader\",\"source\":1,\"validationError\":{\"message\":\"Error mapping input to Guid.\",\"path\":{},\"valueDescriptor\":{\"fromType\":\"System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e\",\"toType\":\"System.Guid, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e\"}}}]"
						||
							// System.Text
							str == "[{\"name\":\"TheHeader\",\"source\":1,\"validationError\":{\"message\":\"Error mapping input to Guid.\",\"path\":{},\"valueDescriptor\":{}}}]"
						);
				});
	}
}
