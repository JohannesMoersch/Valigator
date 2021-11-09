using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.AspNetCore.IntegrationTests
{
	public static class TestClient
	{
		public static HttpClient Instance { get; } = new WebApplicationFactory<Valigator.AspNetCore.TestAPI.Startup>().CreateClient();
	}
}
