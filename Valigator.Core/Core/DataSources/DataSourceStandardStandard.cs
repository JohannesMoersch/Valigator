using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.DataSources
{
	public struct DataSourceStandardStandard<TDataContainerFactory, TDataValue, TValue, TValueValidatorOne, TValueValidatorTwo>
		where TDataContainerFactory : struct, IDataContainerFactory<TDataValue, TValue>
		where TValueValidatorOne : struct, IValueValidator<TValue>
		where TValueValidatorTwo : struct, IValueValidator<TValue>
	{
		private readonly TDataContainerFactory _dataContainerFactory;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;

		public Data<TDataValue> Data => new Data<TDataValue>(_dataContainerFactory.Create(_valueValidatorOne, _valueValidatorTwo, DummyValidator<TValue>.Instance));

		public DataSourceStandardStandard(TDataContainerFactory dataContainerFactory, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo)
		{
			_dataContainerFactory = dataContainerFactory;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
		}

		public DataSourceStandardStandardStandard<TDataContainerFactory, TDataValue, TValue, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree> Add<TValueValidatorThree>(TValueValidatorThree valueValidator)
			where TValueValidatorThree : struct, IValueValidator<TValue>
			=> new DataSourceStandardStandardStandard<TDataContainerFactory, TDataValue, TValue, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree>(_dataContainerFactory, _valueValidatorOne, _valueValidatorTwo, valueValidator);

		public DataSourceStandardInverted<TDataContainerFactory, TDataValue, TValue, TValueValidatorOne, TValueValidatorTwo> InvertTwo()
			=> new DataSourceStandardInverted<TDataContainerFactory, TDataValue, TValue, TValueValidatorOne, TValueValidatorTwo>(_dataContainerFactory, _valueValidatorOne, _valueValidatorTwo);

		public static implicit operator Data<TDataValue>(DataSourceStandardStandard<TDataContainerFactory, TDataValue, TValue, TValueValidatorOne, TValueValidatorTwo> dataSource)
			=> dataSource.Data;
	}
}
