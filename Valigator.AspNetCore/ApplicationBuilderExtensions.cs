using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.AspNetCore
{
	public static class ApplicationBuilderExtensions
	{
		public static IApplicationBuilder UseValigator(this IApplicationBuilder app)
			=> app;
	}
}
