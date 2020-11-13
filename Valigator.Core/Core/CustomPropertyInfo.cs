using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace Valigator.Core
{
	internal class CustomPropertyInfo : PropertyInfo
	{
		public PropertyInfo Inner { get; }

		public CustomPropertyInfo(PropertyInfo inner)
		{
			Inner = inner;
		}

		public override Type DeclaringType => typeof(ValigatorModelBase);
		public override Type ReflectedType => typeof(ValigatorModelBase);

		public override MethodInfo GetGetMethod(bool nonPublic)
			=> typeof(ValigatorModelBase).GetMethod(nameof(ValigatorModelBase.GetMember), BindingFlags.Public | BindingFlags.Instance);
		public override MethodInfo GetMethod => GetGetMethod(true);

		public override MethodInfo GetSetMethod(bool nonPublic)
			=> typeof(ValigatorModelBase).GetMethod(nameof(ValigatorModelBase.SetMember), BindingFlags.Public | BindingFlags.Instance);
		public override MethodInfo SetMethod => GetSetMethod(true);

		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) => SetValigatorModelValue(obj, value);
		public override void SetValue(object obj, object value, object[] index) => SetValigatorModelValue(obj, value);

		public override ParameterInfo[] GetIndexParameters() => Inner.GetIndexParameters();
		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) => GetValigatorModelValue(obj);

		public override object GetValue(object obj, object[] index) => GetValigatorModelValue(obj);

		private void SetValigatorModelValue(object valigatorModelBase, object value) => (valigatorModelBase as ValigatorModelBase).SetMember(Name, value);
		private object GetValigatorModelValue(object valigatorModelBase) => (valigatorModelBase as ValigatorModelBase).GetMember(Name);

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
