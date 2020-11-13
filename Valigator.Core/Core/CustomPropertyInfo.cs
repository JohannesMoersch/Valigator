using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace Valigator.Core
{
	internal class CustomPropertyInfo : PropertyInfo
	{
		public PropertyInfo Inner { get; }
		private readonly ValigatorModelBase _valigatorModelBase;

		public CustomPropertyInfo(PropertyInfo inner, ValigatorModelBase valigatorModelBase)
		{
			Inner = inner;
			_valigatorModelBase = valigatorModelBase;
		}

		public override Type DeclaringType => _valigatorModelBase.GetType();
		public override Type ReflectedType => _valigatorModelBase.GetType();

		public override MethodInfo GetGetMethod(bool nonPublic)
			=> _valigatorModelBase.GetType().GetMethod(nameof(ValigatorModelBase.GetMember), BindingFlags.Public | BindingFlags.Instance).MakeGenericMethod(Inner.PropertyType);
		public override MethodInfo GetMethod => GetGetMethod(true);

		public override MethodInfo GetSetMethod(bool nonPublic)
			=> _valigatorModelBase.GetType().GetMethod(nameof(ValigatorModelBase.SetMember), BindingFlags.Public | BindingFlags.Instance).MakeGenericMethod(Inner.PropertyType);
		public override MethodInfo SetMethod => GetSetMethod(true);

		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) => SetValigatorModelValue(value);
		public override void SetValue(object obj, object value, object[] index) => SetValigatorModelValue(value);

		public override ParameterInfo[] GetIndexParameters() => Inner.GetIndexParameters();
		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) => GetValigatorModelValue<object>();

		public override object GetValue(object obj, object[] index) => GetValigatorModelValue<object>();

		private void SetValigatorModelValue<T>(T value) => _valigatorModelBase.SetMember(Name, value);
		private T GetValigatorModelValue<T>() => _valigatorModelBase.GetMember<T>(Name);

		public override IEnumerable<CustomAttributeData> CustomAttributes => Inner.CustomAttributes;
		public override Module Module => Inner.Module;
		public override PropertyAttributes Attributes => Inner.Attributes;
		public override bool CanRead => true;
		public override bool CanWrite => true;
		public override Type PropertyType => Inner.PropertyType;
		public override string Name => Inner.Name;
		public override MethodInfo[] GetAccessors(bool nonPublic) => new[] { GetGetMethod(), GetSetMethod() };
		public override object[] GetCustomAttributes(bool inherit) => Inner.GetCustomAttributes(inherit);
		public override object[] GetCustomAttributes(Type attributeType, bool inherit) => Inner.GetCustomAttributes(attributeType, inherit);
		public override bool IsDefined(Type attributeType, bool inherit) => Inner.IsDefined(attributeType, inherit);
	}
}
