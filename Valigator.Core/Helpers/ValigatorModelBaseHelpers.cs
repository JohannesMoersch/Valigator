using System.Linq;
using System.Reflection;
using Valigator.Core.Helpers;

namespace Valigator.Core.Helpers
{

	public static class ValigatorModelBaseHelpers
	{
		public static PropertyInfo GetProperty(object obj, string name, BindingFlags bindingFlags)
		 => obj is ValigatorModelBase valigatorModelBase
				? GetProperPropertyInfo(GetProperty(valigatorModelBase.GetInner(), name, bindingFlags), valigatorModelBase)
				: obj.GetType().GetProperty(name, bindingFlags);

		public static PropertyInfo GetProperty(object obj, string name)
		 => obj is ValigatorModelBase valigatorModelBase
				? GetProperPropertyInfo(GetProperty(valigatorModelBase.GetInner(), name), valigatorModelBase)
				: obj.GetType().GetProperty(name);

		public static PropertyInfo[] GetProperties(object obj)
			=> (obj is ValigatorModelBase valigatorModel
					? GetProperties(valigatorModel.GetInner()).Select(p => GetProperPropertyInfo(p, valigatorModel))
					: obj.GetType().GetProperties()
				)
				.ToArray();

		public static PropertyInfo[] GetProperties(object obj, BindingFlags bindingFlags)
			=> (obj is ValigatorModelBase valigatorModel
					? GetProperties(valigatorModel.GetInner(), bindingFlags).Select(p => GetProperPropertyInfo(p, valigatorModel))
					: obj.GetType().GetProperties(bindingFlags)
				)
				.ToArray();

		private static PropertyInfo GetProperPropertyInfo(PropertyInfo p, ValigatorModelBase valigatorModel)
			=> p.IsMissingGetterOrSetter() ? new CustomPropertyInfo(p, valigatorModel) : p;

		private static bool IsMissingGetterOrSetter(this PropertyInfo p)
			=> p.GetGetMethod() == null || p.GetSetMethod() == null;
	}
}
