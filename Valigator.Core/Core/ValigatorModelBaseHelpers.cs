using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Valigator.Core
{
	internal class CustomFieldInfo : FieldInfo
	{
		private readonly FieldInfo _inner;

		public CustomFieldInfo(FieldInfo inner)
		{
			_inner = inner;
		}

		public override FieldAttributes Attributes => _inner.Attributes;
		public override RuntimeFieldHandle FieldHandle => _inner.FieldHandle;
		public override Type FieldType => _inner.FieldType;
		public override Type DeclaringType => _inner.DeclaringType;
		public override string Name => _inner.Name;
		public override Type ReflectedType => _inner.ReflectedType;
		public override object[] GetCustomAttributes(bool inherit) => _inner.GetCustomAttributes(inherit).Append(new ValidateContentsAttribute()).ToArray();
		public override object[] GetCustomAttributes(Type attributeType, bool inherit) => GetCustomAttributes(inherit).Where(a => attributeType.IsAssignableFrom(a.GetType())).ToArray();
		public override object GetValue(object obj) => _inner.GetValue(obj);
		public override bool IsDefined(Type attributeType, bool inherit) => _inner.IsDefined(attributeType, inherit);
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) => _inner.SetValue(obj, value, invokeAttr, binder, culture);
	}

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

		public static FieldInfo[] GetFields(object obj, BindingFlags bindingFlags)
			=> obj is ValigatorModelBase valigatorModel
				? GetFields(valigatorModel.GetInner(), bindingFlags).Select(MakeCustomFieldInfo).ToArray()
				: obj.GetType().GetFields(bindingFlags).ToArray();

		private static FieldInfo MakeCustomFieldInfo(FieldInfo arg)
			=> new CustomFieldInfo(arg);

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
