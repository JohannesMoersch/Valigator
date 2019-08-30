using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.DataContainers.Factories;
using Valigator.Core.DataSources;
using Valigator.Core.StateValidators;

namespace Valigator
{
	internal static class CommonStateValidatorExtensions
	{
		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TValue, TValue>, TValue, TValue, TValueValidator> Add<TValue, TValueValidator>(this RequiredStateValidator<TValue> stateValidator, TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue>
			=> new DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TValue, TValue>, TValue, TValue, TValueValidator>(new DataContainerFactory<RequiredStateValidator<TValue>, TValue, TValue>(stateValidator, Mapping.CreatePassthrough<TValue>()), valueValidator);
	}
}
