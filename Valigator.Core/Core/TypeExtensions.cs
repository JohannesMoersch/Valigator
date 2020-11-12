using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Valigator.Core
{
	internal static class TypeExtensions
	{
		public static bool IsAnonymousType(this Type type)
		{
			// From https://jefclaes.be/2011/05/checking-for-anonymous-types.html
			// HACK: The only way to detect anonymous types right now.
			return Attribute.IsDefined(type, typeof(CompilerGeneratedAttribute), false)
					&& type.IsGenericType
					&& type.Name.Contains("AnonymousType")
					&& (type.Name.StartsWith("<>", StringComparison.OrdinalIgnoreCase) ||
						type.Name.StartsWith("VB$", StringComparison.OrdinalIgnoreCase))
					&& (type.Attributes & TypeAttributes.NotPublic) == TypeAttributes.NotPublic;
		}
	}
}
