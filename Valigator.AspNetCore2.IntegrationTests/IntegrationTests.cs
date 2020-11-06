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

namespace Valigator.AspNetCore2.IntegrationTests
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
	}
}
