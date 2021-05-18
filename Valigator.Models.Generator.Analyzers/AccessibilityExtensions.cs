using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class AccessibilityExtensions
	{
		public static bool IsAccessibleInternally(this Accessibility accessibility)
			=> accessibility == Accessibility.Public
				|| accessibility == Accessibility.Internal
				|| accessibility == Accessibility.ProtectedOrInternal;
	}
}
