using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.DataSources
{
	public struct DataSourceStandardStandardStandard<TDataContainerFactory, TDataValue, TValue, TSource, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree>
		where TDataContainerFactory : struct, IDataContainerFactory<TDataValue, TValue>
		where TValueValidatorOne : struct, IValueValidator<TValue>
		where TValueValidatorTwo : struct, IValueValidator<TValue>
		where TValueValidatorThree : struct, IValueValidator<TValue>
	{
		private readonly TDataContainerFactory _dataContainerFactory;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;
		private readonly TValueValidatorThree _valueValidatorThree;

		public Data<TDataValue> Data => new Data<TDataValue>(_dataContainerFactory.Create(_valueValidatorOne, _valueValidatorTwo, _valueValidatorThree));

		public DataSourceStandardStandardStandard(TDataContainerFactory dataContainerFactory, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_dataContainerFactory = dataContainerFactory;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		public static implicit operator Data<TDataValue>(DataSourceStandardStandardStandard<TDataContainerFactory, TDataValue, TValue, TSource, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree> dataSource)
			=> dataSource.Data;
	}
}
