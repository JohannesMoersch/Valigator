using System;
using System.Collections.Generic;
using System.Linq;
using Functional;
using Valigator.Core.DataContainers.Factories;
using Valigator.Core.DataSources;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator.TestApi.Core31
{
	public static class DataExtensions
	{
		/// <summary>
		/// Elements are Unique
		/// </summary>
		public static DataSourceStandardStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>, CustomValidator<TValue[]>> ElementsUnique<TSource, TValue, TProperty>(
			this DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[], ItemCountValidator<TValue>> collection,
			Func<TValue, Option<TProperty>> propertyComparison,
			string validationMessage)
			=> collection.Assert(validationMessage, coll => ValidateElements(coll, propertyComparison));

		/// <summary>
		/// ValidateElements
		/// </summary>
		private static bool ValidateElements<TValue, TProperty>(TValue[] elements, Func<TValue, Option<TProperty>> propertyComparison)
		{
			var set = new HashSet<TProperty>();
			foreach (var e in elements.Select(propertyComparison))
			{
				var result = e.Match(s => set.Add(s), () => true);

				if (!result)
					return result;
			}

			return true;
		}
	}
}
