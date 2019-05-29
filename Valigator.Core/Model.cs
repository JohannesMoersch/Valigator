using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Valigator.Core.Descriptors;

namespace Valigator.Core
{
	public static class Model
	{
		private static readonly ConcurrentDictionary<Type, Func<object, PropertyDescriptor[]>> _getPropertyDescriptorsFunction = new ConcurrentDictionary<Type, Func<object, PropertyDescriptor[]>>();

		public static PropertyDescriptor[] GetPropertyDescriptors(this object model)
		{
			var modelType = model?.GetType() ?? throw new ArgumentNullException(nameof(model));

			if (!_getPropertyDescriptorsFunction.TryGetValue(modelType, out var function))
			{
				function = CreatePropertyDescriptorsFunction(modelType);

				_getPropertyDescriptorsFunction.TryAdd(modelType, function);
			}

			return function.Invoke(model);
		}

		private static Func<object, PropertyDescriptor[]> CreatePropertyDescriptorsFunction(Type modelType)
		{
			var modelParameter = Expression.Parameter(typeof(object), "model");

			var modelExpression = Expression.Convert(modelParameter, modelType);

			var propertyDescriptors = modelType
				.GetProperties()
				.Where(property => property.PropertyType.IsConstructedGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Data<>))
				.Select(property => Create(modelExpression, property));

			var arrayInitializer = Expression.NewArrayInit(typeof(PropertyDescriptor), propertyDescriptors);

			return Expression.Lambda<Func<object, PropertyDescriptor[]>>(arrayInitializer, modelParameter).Compile();
		}

		private static Expression Create(Expression modelExpression, PropertyInfo property)
		{
			var data = Expression.Property(modelExpression, property);

			var dataDescriptor = Expression.Property(data, nameof(IHasDescriptor.DataDescriptor));

			return CreatePropertyDescriptor(property.Name, dataDescriptor);
		}

		private static Expression CreatePropertyDescriptor(string propertyName, Expression dataDescriptor)
		{
			var constructor = typeof(PropertyDescriptor).GetConstructor(new[] { typeof(string), typeof(Type), typeof(IStateDescriptor), typeof(IEnumerable<IValueDescriptor>) });

			var propertyType = Expression.Property(dataDescriptor, nameof(DataDescriptor.PropertyType));

			var stateDescriptor = Expression.Property(dataDescriptor, nameof(DataDescriptor.StateDescriptor));

			var valueDescriptors = Expression.Property(dataDescriptor, nameof(DataDescriptor.ValueDescriptors));

			return Expression.New(constructor, Expression.Constant(propertyName, typeof(string)), propertyType, stateDescriptor, valueDescriptors);
		}
	}
}
