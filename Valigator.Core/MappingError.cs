using System;
using Valigator.Core.ValueDescriptors;

namespace Valigator
{
	public static class MappingError
	{
		public static ValidationError Create<TFrom, TTo>()
			=> new ValidationError($"Failed to map from type '{typeof(TFrom).FullName}' to '{typeof(TTo).FullName}'.", new MappingDescriptor(typeof(TFrom), typeof(TTo)));

		public static ValidationError Create(Type fromType, Type toType)
			=> new ValidationError($"Failed to map from type '{fromType.FullName}' to '{toType.FullName}'.", new MappingDescriptor(fromType, toType));

		public static ValidationError Create<TFrom, TTo>(string message)
			=> new ValidationError(message, new MappingDescriptor(typeof(TFrom), typeof(TTo)));

		public static ValidationError Create(string message, Type fromType, Type toType)
			=> new ValidationError(message, new MappingDescriptor(fromType, toType));
	}
}
