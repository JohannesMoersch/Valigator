using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.DataContainers.Factories;
using Valigator.Core.DataSources;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.Extensions
{
	public static class Test
	{
		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TValue, TValue>, TValue, TValue, CustomValidator<TValue>> Stuff<TValue>(this RequiredStateValidator<TValue> stateValidator)
			=> throw new NotImplementedException();

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, CustomValidator<TValue>> Stuff<TSource, TValue>(this DataSource<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue> stateValidator)
			=> throw new NotImplementedException();
	}
}
