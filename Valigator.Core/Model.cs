using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Functional;
using Valigator.Core;
using Valigator.Core.Helpers;

namespace Valigator
{
	public static class Model
	{
		private static readonly ConcurrentDictionary<Type, Func<object, PropertyDescriptor[]>> _getPropertyDescriptorsFunctions = new ConcurrentDictionary<Type, Func<object, PropertyDescriptor[]>>();

		public static PropertyDescriptor[] GetPropertyDescriptors(object model)
		{
			var modelType = model?.GetType() ?? throw new ArgumentNullException(nameof(model));

			if (!_getPropertyDescriptorsFunctions.TryGetValue(modelType, out var function))
			{
				function = CreatePropertyDescriptorsFunction(modelType);

				_getPropertyDescriptorsFunctions.TryAdd(modelType, function);
			}

			return function.Invoke(model);
		}

		private static Func<object, PropertyDescriptor[]> CreatePropertyDescriptorsFunction(Type modelType)
		{
			var modelParameter = Expression.Parameter(typeof(object), "model");

			var method = typeof(Model<>).MakeGenericType(modelType).GetMethod(nameof(Model<object>.GetPropertyDescriptors));

			var expression = Expression.Call(method, Expression.Convert(modelParameter, modelType));

			return Expression.Lambda<Func<object, PropertyDescriptor[]>>(expression, modelParameter).Compile();
		}

		private static readonly ConcurrentDictionary<Type, Func<object, Result<Unit, ValidationError[]>>> _verifyModelFunctions = new ConcurrentDictionary<Type, Func<object, Result<Unit, ValidationError[]>>>();
		private static readonly ConditionalWeakTable<object, object> _objectVerificationResults = new ConditionalWeakTable<object, object>();

		public static Result<Unit, ValidationError[]> Verify<TModel>(TModel model)
		{
			var modelType = model?.GetType() ?? throw new ArgumentNullException(nameof(model));

			if (modelType == typeof(TModel))
				return Model<TModel>.Verify(model);

			if (!_verifyModelFunctions.TryGetValue(modelType, out var function))
			{
				function = CreateVerifyFunction(modelType);

				_verifyModelFunctions.TryAdd(modelType, function);
			}

			if (_objectVerificationResults.TryGetValue(model, out var value))
				return (Result<Unit, ValidationError[]>)value;

			var result = function.Invoke(model);
			_objectVerificationResults.Add(model, result);
			return result;
		}

		private static Func<object, Result<Unit, ValidationError[]>> CreateVerifyFunction(Type modelType)
		{
			var modelParameter = Expression.Parameter(typeof(object), "model");

			var method = typeof(Model<>).MakeGenericType(modelType).GetMethod(nameof(Model<object>.Verify));

			var expression = Expression.Call(method, Expression.Convert(modelParameter, modelType));

			return Expression.Lambda<Func<object, Result<Unit, ValidationError[]>>>(expression, modelParameter).Compile();
		}

		public static TObject CreateNew<TObject>()
			where TObject : class
			=> ModelFactory<TObject>.GetNewObjectInstance();

		public static TObject CreateClone<TObject>()
			where TObject : class
			=> ModelFactory<TObject>.GetClonedObjectInstance();
	}
}
