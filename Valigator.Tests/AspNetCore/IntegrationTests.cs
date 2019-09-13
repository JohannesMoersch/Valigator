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
				.WithJsonBody($"{{ \"{nameof(InnerBodyClass.IdentifierCollection)}\": [ {{\"{nameof(InnerClass.TheIdentifier)}\" : \" \"}} ] }}")
				.Send()
				.IsBadRequest()
				.AssertJsonBody(str =>
				{
					str.Should().Be(@"[{""Name"":""bodyValue"",""Source"":0,""ValidationError"":{""Message"":""Error converting value \"" \"" to type 'System.Guid'. Path 'IdentifierCollection[0].TheIdentifier', line 1, position 50."",""Path"":{},""ValueDescriptor"":{""FromType"":""System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e"",""ToType"":""System.Guid, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e""}}}]");
				});

		[Fact]
		public Task PostWithIdentifiersGuidVersion()
			=> CreateClient()
				.BuildTest()
				.Post("test/post2")
				.WithJsonBody($"{{ \"{nameof(InnerBodyClass.IdentifierCollection)}\": [ {{\"{nameof(InnerClass.TheIdentifier)}\" : \" \"}} ] }}")
				.Send()
				.IsBadRequest()
				.AssertJsonBody(str =>
				{
					str.Should().Be(@"[{""Name"":""bodyValue"",""Source"":0,""ValidationError"":{""Message"":""Error converting value \"" \"" to type 'System.Guid'. Path 'IdentifierCollection[0].TheIdentifier', line 1, position 50."",""Path"":{},""ValueDescriptor"":{""FromType"":""System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e"",""ToType"":""System.Guid, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e""}}}]");
				});
	}
}
