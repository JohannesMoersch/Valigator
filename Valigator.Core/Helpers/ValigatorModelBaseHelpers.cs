using System;
using System.Linq;
using System.Reflection;
using Valigator.Core.Helpers;

namespace Valigator.Core.Helpers
{

	public static class ValigatorModelBaseHelpers
	{
		public static PropertyInfo GetProperty(Type type, string name, BindingFlags bindingFlags)
		 => type.IsValigatorModelBase()
				? GetProperPropertyInfo(GetProperty(type.GetValigatorModelBaseInnerType(), name, bindingFlags))
				: type.GetProperty(name, bindingFlags);

		public static PropertyInfo GetProperty(Type type, string name)
		 => type.IsValigatorModelBase()
				? GetProperPropertyInfo(GetProperty(type.GetValigatorModelBaseInnerType(), name))
				: type.GetProperty(name);

		public static PropertyInfo[] GetProperties(Type type)
			=> type.IsValigatorModelBase()
				? GetProperties(type.GetValigatorModelBaseInnerType()).Select(property => GetProperPropertyInfo(property)).ToArray()
				: type.GetProperties();

		public static PropertyInfo[] GetProperties(Type type, BindingFlags bindingFlags)
			=> type.IsValigatorModelBase()
				? GetProperties(type.GetValigatorModelBaseInnerType(), bindingFlags).Select(property => GetProperPropertyInfo(property)).ToArray()
				: type.GetProperties(bindingFlags);

		private static PropertyInfo GetProperPropertyInfo(PropertyInfo property)
			=> property.IsMissingGetterOrSetter() ? new CustomPropertyInfo(property) : property;

		private static bool IsMissingGetterOrSetter(this PropertyInfo p)
			=> p.GetGetMethod() == null || p.GetSetMethod() == null;

		internal static bool IsValigatorModelBase(this Type type)
			=> type.IsGenericType && typeof(ValigatorModelBase).IsAssignableFrom(type.GetGenericTypeDefinition());

		internal static Type GetValigatorModelBaseInnerType(this Type type)
			=> type.GetGenericArguments().First();
	}
}
