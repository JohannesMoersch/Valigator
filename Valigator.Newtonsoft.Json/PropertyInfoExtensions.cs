using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Valigator.Newtonsoft.Json
{
	internal static class PropertyInfoExtensions
	{
		public static Func<TObject, Data<TDataValue>> GetGetter<TObject, TDataValue>(this PropertyInfo property)
		{
			if (property.GetCustomAttribute<JsonIgnoreAttribute>() != null)
				return null;

			var objParameter = Expression.Parameter(typeof(TObject), "obj");
			var propertyExpression = Expression.Property(objParameter, property);

			return property.CanRead ? Expression.Lambda<Func<TObject, Data<TDataValue>>>(propertyExpression, objParameter).Compile() : null;
		}

		public static Action<TObject, Data<TDataValue>> GetSetter<TObject, TDataValue>(this PropertyInfo property)
		{
			if (property.GetCustomAttribute<JsonIgnoreAttribute>() != null)
				return null;

			var objParameter = Expression.Parameter(typeof(TObject), "obj");
			var propertyExpression = Expression.Property(objParameter, property);

			var valueParameter = Expression.Parameter(typeof(Data<TDataValue>), "value");

			return property.CanWrite ? Expression.Lambda<Action<TObject, Data<TDataValue>>>(Expression.Assign(propertyExpression, valueParameter), objParameter, valueParameter).Compile() : null;
		}
	}
}
