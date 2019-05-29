using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Valigator.Core.Helpers
{
	internal static class PropertyHelper
	{
		private static readonly ConcurrentDictionary<(Type modelType, string propertyName), Func<object, object>> _getFunctionCache = new ConcurrentDictionary<(Type modelType, string propertyName), Func<object, object>>();

		private static readonly ConcurrentDictionary<(Type modelType, string propertyName), Action<object, object>> _setFunctionCache = new ConcurrentDictionary<(Type modelType, string propertyName), Action<object, object>>();

		public static object GetPropertyValue(object model, string propertyName)
		{
			var modelType = model?.GetType() ?? throw new ArgumentNullException(nameof(model));

			return GetPropertyGetter(modelType, propertyName).Invoke(model);
		}

		public static Func<object, object> GetPropertyGetter(Type modelType, string propertyName)
		{
			if (!_getFunctionCache.TryGetValue((modelType, propertyName), out var function))
			{
				function = CreateGetFunction(modelType, propertyName);

				_getFunctionCache.TryAdd((modelType, propertyName), function);
			}

			return function;
		}

		private static Func<object, object> CreateGetFunction(Type modelType, string propertyName)
		{
			var property = GetProperty(modelType, propertyName);

			var parameter = Expression.Parameter(typeof(object), "model");

			var memberExpression = Expression.Property(Expression.Convert(parameter, modelType), property);

			return Expression.Lambda<Func<object, object>>(Expression.Convert(memberExpression, typeof(object)), parameter).Compile();
		}

		public static void SetPropertyValue(object model, string propertyName, object value)
		{
			var modelType = model?.GetType() ?? throw new ArgumentNullException(nameof(model));

			GetPropertySetter(modelType, propertyName).Invoke(model, value);
		}

		public static Action<object, object> GetPropertySetter(Type modelType, string propertyName)
		{
			if (!_setFunctionCache.TryGetValue((modelType, propertyName), out var function))
			{
				function = CreateSetFunction(modelType, propertyName);

				_setFunctionCache.TryAdd((modelType, propertyName), function);
			}

			return function;
		}

		private static Action<object, object> CreateSetFunction(Type modelType, string propertyName)
		{
			var property = GetProperty(modelType, propertyName);

			var parameter = Expression.Parameter(typeof(object), "model");

			var value = Expression.Parameter(typeof(object), "value");

			var memberExpression = Expression.Property(Expression.Convert(parameter, modelType), property);

			var assignExpression = Expression.Assign(memberExpression, Expression.Convert(value, property.PropertyType));

			return Expression.Lambda<Action<object, object>>(assignExpression, parameter, value).Compile();
		}

		private static PropertyInfo GetProperty(Type modelType, string propertyName)
			=> modelType.GetProperty(propertyName) ?? throw new ArgumentException($"\"{propertyName}\" does not exist on type \"{modelType.FullName}\".", nameof(propertyName));
	}
}
