using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Models.Generator.Tests
{
	public static class TypeExtensions
	{
		public static IEnumerable<Type> GetContainingTypeHierarchy(this Type type)
		{
			if (type.DeclaringType != null)
				foreach (var t in type.DeclaringType.GetContainingTypeHierarchy())
					yield return t;
			yield return type;
		}

		public static ObjectType GetObjectType(this Type type)
		{
			if (type.IsValueType)
				return ObjectType.Value;

			if (type.IsInterface)
				return ObjectType.Interface;

			return ObjectType.Reference;
		}
	}
}
