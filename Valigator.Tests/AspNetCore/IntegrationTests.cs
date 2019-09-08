using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Interrogator.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Valigator.TestApi;
using Xunit;

namespace Valigator.Tests.AspNetCore
{
	public class IntegrationTests
	{
		private HttpClient CreateClient()
			=> new WebApplicationFactory<Startup>().CreateClient();

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
		public Task WithNull()
			=> CreateClient()
				.BuildTest()
				.Get("test/header")
				.WithHeader("testheader", " ")
				.Send()
				.IsOk()
				.AssertJsonBody(str => str.Should().Be(@"null"));

		[Fact]
		public Task WithUnSet()
			=> CreateClient()
				.BuildTest()
				.Get("test/header")
				.Send()
				.IsOk()
				.AssertJsonBody(str => str.Should().Be(@"""Default"""));
	}
}
