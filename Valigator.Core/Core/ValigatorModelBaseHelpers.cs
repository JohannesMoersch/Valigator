using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Valigator.Core
{
	public static class ValigatorModelBaseHelpers
	{
		public static PropertyInfo GetProperty(object obj, string name, BindingFlags bindingFlags)
		 => obj is ValigatorModelBase valigatorModelBase
				? GetProperty(valigatorModelBase.GetInner(), name, bindingFlags)
				: obj.GetType().GetProperty(name, bindingFlags);

		public static PropertyInfo GetProperty(object obj, string name)
		 => obj is ValigatorModelBase valigatorModelBase
				? GetProperty(valigatorModelBase.GetInner(), name)
				: obj.GetType().GetProperty(name);

		public static PropertyInfo[] GetProperties(object obj)
			=> obj is ValigatorModelBase valigatorModel
				? GetProperties(valigatorModel.GetInner())
				: obj.GetType().GetProperties().ToArray();

		public static PropertyInfo[] GetProperties(object obj, BindingFlags bindingFlags)
			=> obj is ValigatorModelBase valigatorModel
				? GetProperties(valigatorModel.GetInner(), bindingFlags)
				: obj.GetType().GetProperties(bindingFlags).ToArray();

		public static Expression CreateDataExpression<TObject>(Expression objParameter, PropertyInfo propertyInfo, TObject model)
			=> model is ValigatorModelBase
				? Expression.Call(
					objParameter,
					model.GetType().GetMethod(nameof(ValigatorModelBase.GetMember)).MakeGenericMethod(propertyInfo.PropertyType),
					Expression.Constant(propertyInfo.Name)
				)
				: (Expression)Expression.Property(objParameter, propertyInfo);
	}
}
