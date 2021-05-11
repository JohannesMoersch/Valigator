using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class TypeKindExtensions
	{
		public static string ToCSharpCodeString(this TypeKind type)
			=> type switch
			{
				TypeKind.Struct => "struct",
				TypeKind.Interface => "interface",
				_ => "class"
			};
	}
}
