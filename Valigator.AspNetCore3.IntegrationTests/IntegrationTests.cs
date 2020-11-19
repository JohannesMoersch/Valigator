using System;
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

namespace Valigator.AspNetCore3.IntegrationTests
{
	public class IntegrationTests
	{
		private static HttpClient _httpClient;

		private static HttpClient CreateClient()
			=> _httpClient ??= new WebApplicationFactory<Startup>().CreateClient();

		[Fact]
		public Task WithValue()
			=> CreateClient()
				.BuildTest()
				.Get("test/header")
				.WithHeader("testheader", "Value")
				.Send()
				.IsOk()
				.AssertJsonBody(str => str.Should().Be(@"""Value"""));

		[Fact]
		public Task WithWhitespace()
			=> CreateClient()
				.BuildTest()
				.Get("test/header")
				.WithHeader("testheader", " ")
				.Send()
				.IsOk()
				.AssertJsonBody(str => str.Should().Be(@""" """));

		[Fact]
		public Task WithUnSet()
			=> CreateClient()
				.BuildTest()
				.Get("test/header")
				.Send()
				.IsOk()
				.AssertJsonBody(str => str.Should().Be(@"""Default"""));

		[Fact]
		public Task PostWithIdentifiers()
			=> CreateClient()
				.BuildTest()
				.Post("test/post")
				.WithJsonBody($"{{ \"{nameof(BodyClass.IdentifierCollection)}\": [ {{\"{nameof(InnerClass.TheIdentifier)}\" : \"61f45cfd-6389-4380-a803-c23881e982af\"}} ] }}")
				.Send()
				.IsSuccess()
				.AssertJsonBody(str =>
				{
					str.Should().Be("[\"61f45cfd-6389-4380-a803-c23881e982af\"]");
				});

		[Fact]
		public Task PostWithIdentifiersGuidVersion()
			=> CreateClient()
				.BuildTest()
				.Post("test/post2")
				.WithJsonBody($"{{ \"{nameof(BodyClass.IdentifierCollection)}\": [ {{\"{nameof(InnerClass.TheIdentifier)}\" : \"61f45cfd-6389-4380-a803-c23881e982af\"}} ] }}")
				.Send()
				.IsSuccess()
				.AssertJsonBody(str =>
				{
					str.Should().Be("[\"61f45cfd-6389-4380-a803-c23881e982af\"]");
				});

		[Fact]
		public Task AnonymousObjectOutputTest()
			=> CreateClient()
				.BuildTest()
				.Post("test/anonymousObjectOutput")
				.WithJsonBody($"{{ \"{nameof(BodyClass.IdentifierCollection)}\": [ {{\"{nameof(InnerClass.TheIdentifier)}\" : \"61f45cfd-6389-4380-a803-c23881e982af\"}} ] }}")
				.Send()
				.IsSuccess()
				.AssertJsonBody(str =>
				{
					str.Should().Be("{\"TheOutputOfThePost\":[{\"TheIdentifier\":\"61f45cfd-6389-4380-a803-c23881e982af\"}],\"SecondValue\":1}");
				});

		[Fact]
		public Task ObjectWithNonDataPropertyTest()
			=> CreateClient()
				.BuildTest()
				.Post("test/nonDataPropertyObject")
				.WithJsonBody($"{{ \"{nameof(BodyClass.IdentifierCollection)}\": [ {{\"{nameof(InnerClass.TheIdentifier)}\" : \"61f45cfd-6389-4380-a803-c23881e982af\"}} ] }}")
				.Send()
				.IsSuccess()
				.AssertJsonBody(str =>
				{
					str.Should().Be("{\"IdentifierCollection\":[{\"TheIdentifier\":\"61f45cfd-6389-4380-a803-c23881e982af\"}],\"SecondValue\":1}");
				});

		[Fact]
		public Task MappedGuidEndpointReturnsProperError()
			=> CreateClient()
				.BuildTest()
				.Post("mappedGuid/mappedGuid")
				.WithJsonBody($"{{\"Items\":[{{\"MappedGuid\":\"NotAGuid\"}}]}}")
				.Send()
				.IsBadRequest()
				.AssertJsonBody(str =>
				{
					str.Should().Be("");
				});

		[Fact]
		public Task MappedGuidEndpointWorks()
			=> CreateClient()
				.BuildTest()
				.Post("mappedGuid/mappedGuid")
				.WithJsonBody($"{{\"Items\":[{{\"MappedGuid\":\"61f45cfd-6389-4380-a803-c23881e982af\"}}]}}")
				.Send()
				.IsSuccess()
				.AssertJsonBody(str =>
				{
					str.Should().Be("true");
				});

		[Fact]
		public Task MappedGuidHeaderEndpointWorks()
			=> CreateClient()
				.BuildTest()
				.Post("mappedGuid/mappedGuidHeader")
				.WithHeader("TheHeader", "61f45cfd-6389-4380-a803-c23881e982af")
				.WithJsonBody("")
				.Send()
				.IsBadRequest()
				.AssertJsonBody(str =>
				{
					str.Should().Be("");
				});

		[Fact]
		public Task MappedGuidHeaderEndpointReturnsProperError()
			=> CreateClient()
				.BuildTest()
				.Post("mappedGuid/mappedGuidHeader")
				.WithHeader("TheHeader", "NotAGuid")
				.WithJsonBody("")
				.Send()
				.IsBadRequest()
				.AssertJsonBody(str =>
				{
					str.Should().Be("");
				});
	}
}
