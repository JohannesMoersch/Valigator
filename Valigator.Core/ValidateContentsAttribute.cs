using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ValidateContentsAttribute : Attribute
	{
		public string MemberName { get; set; }
	}
}
