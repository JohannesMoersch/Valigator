// NOTE: GENERATED FILE //
using System;

namespace Valigator
{
	public static class TypeExtensions
	{
		public static bool IsValigatorDataType(this Type type)
			=> type.IsConstructedGenericType && type.GetGenericTypeDefinition() == typeof(Data<>);
	}
}