using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Reflection;
using Valigator.Core;

namespace Valigator
{
	internal static class DescriptorExtensions
	{
		private static readonly ConcurrentDictionary<Type, Func<IDescriptor, DataDescriptor>> _getDescriptorMethods = new ConcurrentDictionary<Type, Func<IDescriptor, DataDescriptor>>();

		public static DataDescriptor GetDataDescriptor(this IDescriptor validateAttribute, Type type)
			=> _getDescriptorMethods
				.GetOrAdd(type, t => GenerateGetDescriptorMethod(type))
				.Invoke(validateAttribute);

		private static Func<IDescriptor, DataDescriptor> GenerateGetDescriptorMethod(Type type)
		{
			var validateType = typeof(IValidateType<>).MakeGenericType(type);

			var validateMethod = typeof(ValidationHelpers).GetMethod(nameof(ValidationHelpers.ValidateType), BindingFlags.Public | BindingFlags.Static).MakeGenericMethod(type);
			var getDataMethod = validateType.GetMethod(nameof(IValidateType<object>.GetData), BindingFlags.Public | BindingFlags.Instance);

			var attributeParameter = Expression.Parameter(typeof(IDescriptor), "attribute");
			var convertedAttributeParameter = Expression.Convert(attributeParameter, typeof(object));

			var validate = Expression.Call(validateMethod, convertedAttributeParameter);

			var data = Expression.Call(Expression.Convert(attributeParameter, validateType), getDataMethod);

			var descriptor = Expression.Property(data, nameof(Data<object>.DataDescriptor));

			var block = Expression.Block(validate, descriptor);

			return Expression.Lambda<Func<IDescriptor, DataDescriptor>>(block, attributeParameter).Compile();
		}
	}
}
