using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace Valigator.Core
{
	internal static class ModelFactory<TObject>
		where TObject : class
	{
		private static Func<TObject> _getNewFunction;

		static ModelFactory()
		{
			var constructor = typeof(TObject).GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).FirstOrDefault(info => info.GetParameters().Length == 0);

			if (constructor != null)
				_getNewFunction = Expression.Lambda<Func<TObject>>(Expression.New(constructor)).Compile();
		}

		public static bool SupportsNew { get; }

		private static Action<TObject, TObject> CreateCopyValuesMethod()
		{
			var sourceParameter = Expression.Parameter(typeof(TObject), "source");

			var targetParameter = Expression.Parameter(typeof(TObject), "target");

			var copyExpressions = new List<Expression>();

			foreach (var field in typeof(TObject).GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
				copyExpressions.Add(Expression.Assign(Expression.Field(targetParameter, field), Expression.Field(sourceParameter, field)));

			var block = Expression.Block(copyExpressions);

			return Expression.Lambda<Action<TObject, TObject>>(block, sourceParameter, targetParameter).Compile();
		}

		private static Action<TObject, TObject> _copyValuesMethod;
		private static Action<TObject, TObject> CopyValuesMethod => _copyValuesMethod ??= CreateCopyValuesMethod();

		private static TObject _sourceObj;

		public static TObject GetNewObjectInstance()
			=> _getNewFunction?.Invoke() ?? throw new MissingConstructorException(typeof(TObject));

		public static TObject GetClonedObjectInstance()
		{
			var sourceObj = _sourceObj ??= GetNewObjectInstance();

			if (sourceObj == null)
				throw new MissingConstructorException(typeof(TObject));

			var targetObj = (TObject)FormatterServices.GetSafeUninitializedObject(typeof(TObject));

			CopyValuesMethod.Invoke(sourceObj, targetObj);

			return targetObj;
		}
	}
}
