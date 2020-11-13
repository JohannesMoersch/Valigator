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
		private readonly ValigatorModelBase _valigatorModelBase;

		public FieldInfo Inner { get; }

		public CustomFieldInfo(FieldInfo inner, ValigatorModelBase valigatorModelBase)
		{
			Inner = inner;
			_valigatorModelBase = valigatorModelBase;
		}

		public override FieldAttributes Attributes => Inner.Attributes;
		public override RuntimeFieldHandle FieldHandle => Inner.FieldHandle;
		public override Type FieldType => Inner.FieldType;
		public override Type DeclaringType => _valigatorModelBase.GetType();
		public override string Name => Inner.Name;
		public override Type ReflectedType => _valigatorModelBase.GetType();
		public override object[] GetCustomAttributes(bool inherit) => Inner.GetCustomAttributes(inherit).Append(new ValidateContentsAttribute()).ToArray();
		public override object[] GetCustomAttributes(Type attributeType, bool inherit) => Inner.GetCustomAttributes(attributeType, inherit).Append(new ValidateContentsAttribute()).ToArray();
		public override object GetValue(object obj) => Inner.GetValue(obj);
		public override bool IsDefined(Type attributeType, bool inherit) => Inner.IsDefined(attributeType, inherit);
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) => Inner.SetValue(obj, value, invokeAttr, binder, culture);
	}

	internal class CustomMethodInfo : MethodInfo
	{
		private readonly MethodInfo _inner;
		private readonly ValigatorModelBase _valigatorModelBase;

		public CustomMethodInfo(MethodInfo inner, ValigatorModelBase valigatorModelBase)
		{
			_inner = inner;
			_valigatorModelBase = valigatorModelBase;
		}
		
		public override ICustomAttributeProvider ReturnTypeCustomAttributes => _inner.ReturnTypeCustomAttributes;
		public override MethodAttributes Attributes => _inner.Attributes;
		public override RuntimeMethodHandle MethodHandle => _inner.MethodHandle;
		public override Type DeclaringType => _valigatorModelBase.GetType();
		public override string Name => _inner.Name;
		public override Type ReflectedType => _valigatorModelBase.GetType();
		public override MethodInfo GetBaseDefinition() => _inner.GetBaseDefinition();
		public override object[] GetCustomAttributes(bool inherit) => _inner.GetCustomAttributes(inherit);
		public override object[] GetCustomAttributes(Type attributeType, bool inherit) => _inner.GetCustomAttributes(attributeType, inherit);
		public override MethodImplAttributes GetMethodImplementationFlags() => _inner.GetMethodImplementationFlags();
		public override ParameterInfo[] GetParameters() => _inner.GetParameters();
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) => _inner.Invoke(obj, invokeAttr, binder, parameters, culture);
		public override bool IsDefined(Type attributeType, bool inherit) => _inner.IsDefined(attributeType, inherit);
		public override Type ReturnType => _inner.ReturnType;
		public override ParameterInfo ReturnParameter => _inner.ReturnParameter;
	}

	internal class CustomPropertyInfo : PropertyInfo
	{
		public PropertyInfo Inner { get; }
		private readonly ValigatorModelBase _valigatorModelBase;

		public CustomPropertyInfo(PropertyInfo inner, ValigatorModelBase valigatorModelBase)
		{
			Inner = inner;
			_valigatorModelBase = valigatorModelBase;
			Name = inner.Name;
		}

		public override IEnumerable<CustomAttributeData> CustomAttributes => Inner.CustomAttributes;
		public override Module Module => Inner.Module;

		public override PropertyAttributes Attributes => Inner.Attributes;
		public override bool CanRead => true;
		public override bool CanWrite => true;
		public override Type PropertyType => Inner.PropertyType;
		public override Type DeclaringType => _valigatorModelBase.GetType();
		public override string Name { get; }
		public override Type ReflectedType => _valigatorModelBase.GetType();
		public override MethodInfo[] GetAccessors(bool nonPublic) => new[] { GetGetMethod(), GetSetMethod() };
		public override object[] GetCustomAttributes(bool inherit) => Inner.GetCustomAttributes(inherit);
		public override object[] GetCustomAttributes(Type attributeType, bool inherit) => Inner.GetCustomAttributes(attributeType, inherit);

		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			// () => _valigatorModelBase.GetMember<T>("Name")

			//var method = new Func<object>(() => _valigatorModelBase.GetMember<object>(Name)).Method;

			//var name = Expression.Constant(Name);
			//var valigatorModelBase = Expression.Constant(_valigatorModelBase);
			//var method = _valigatorModelBase.GetType().GetMethod(nameof(ValigatorModelBase.GetMember)).MakeGenericMethod(Inner.PropertyType);
			//var call = Expression.Call(valigatorModelBase, method, name);
			//var cast = Expression.Convert(call, typeof(object));
			//return Expression.Lambda<Func<object>>(cast).Compile().Method;
			//var f = Expression.Call(Expression.Convert(Expression.Parameter(Inner.GetType(), "model"), Inner.GetType()), Inner.GetGetMethod());

			return new CustomMethodInfo(_valigatorModelBase.GetType().GetMethod(nameof(ValigatorModelBase.GetMember), BindingFlags.Public | BindingFlags.Instance).MakeGenericMethod(Inner.PropertyType), _valigatorModelBase);
		}
		public override MethodInfo GetMethod => GetGetMethod(true);

		public override MethodInfo GetSetMethod(bool nonPublic) => new CustomMethodInfo(_valigatorModelBase.GetType().GetMethod(nameof(ValigatorModelBase.SetMember), BindingFlags.Public | BindingFlags.Instance).MakeGenericMethod(Inner.PropertyType), _valigatorModelBase); //new Action<object>(value => _valigatorModelBase.SetMember(Name, value)).Method;// 
		public override MethodInfo SetMethod => GetSetMethod(true);
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) => SetValigatorModelValue(value);
		public override void SetValue(object obj, object value, object[] index) => SetValigatorModelValue(value);
		

		public override ParameterInfo[] GetIndexParameters() => Inner.GetIndexParameters();
		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) => GetValigatorModelValue<object>();

		public override object GetValue(object obj, object[] index) => GetValigatorModelValue<object>();


		private void SetValigatorModelValue<T>(T value) => _valigatorModelBase.SetMember(Name, value);
		private T GetValigatorModelValue<T>() => _valigatorModelBase.GetMember<T>(Name);

		public override bool IsDefined(Type attributeType, bool inherit) => Inner.IsDefined(attributeType, inherit);
	}

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
			=> IsMissingGetterOrSetter(p) ? new CustomPropertyInfo(p, valigatorModel) : p;

		public static FieldInfo[] GetFields(object obj, BindingFlags bindingFlags)
			=> (obj is ValigatorModelBase valigatorModel
					? GetFields(valigatorModel.GetInner(), bindingFlags).Select(f => MakeCustomFieldInfo(f, valigatorModel))
					: obj.GetType().GetFields(bindingFlags)
				)
				.ToArray();

		private static FieldInfo MakeCustomFieldInfo(FieldInfo arg, ValigatorModelBase valigatorModelBase)
			=> new CustomFieldInfo(arg, valigatorModelBase);

		private static bool IsMissingGetterOrSetter(this PropertyInfo p)
			=> p.GetGetMethod() == null || p.GetSetMethod() == null;
	}
}
