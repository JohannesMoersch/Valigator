using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace Valigator.Core
{
	internal static class ModelFactory<TObject>
		where TObject : class, new()
	{
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

		private static readonly TObject _sourceObj = new TObject();

		internal static TObject GetClonedObjectInstance()
		{
			var targetObj = (TObject)FormatterServices.GetSafeUninitializedObject(typeof(TObject));

			CopyValuesMethod.Invoke(_sourceObj, targetObj);

			return targetObj;
		}
	}
}
