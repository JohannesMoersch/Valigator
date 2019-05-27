using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.DataSources;
using Newtonsoft.FluentValidation.ValueValidators;

namespace Newtonsoft.FluentValidation
{
	public static class DataSourceExtensions
	{
		public static ValueTypeNotDefaultValidator<RequiredSource<TValue>, TValue> NotDefault<TValue>(this RequiredSource<TValue> dataSource)
			where TValue : struct
			=> new ValueTypeNotDefaultValidator<RequiredSource<TValue>, TValue>(dataSource);

		public static RangeValidator_Int32<RequiredSource<int>> InRange(this RequiredSource<int> requiredValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
			=> new RangeValidator_Int32<RequiredSource<int>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
	}
}
