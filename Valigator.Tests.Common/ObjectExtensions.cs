using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Tests.Common
{
	public static class ObjectExtensions
	{
		public static TObject Verify<TObject>(this TObject obj)
		{
			Model.Verify(obj).AssertSuccess();

			return obj;
		}
	}
}
