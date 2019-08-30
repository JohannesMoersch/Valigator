using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.DataSources
{
	public struct DataSourceStandardInverted<TDataContainerFactory, TDataValue, TValue, TSource, TValueValidatorOne, TValueValidatorTwo>
		where TDataContainerFactory : struct, IDataContainerFactory<TDataValue, TValue>
		where TValueValidatorOne : struct, IValueValidator<TValue>
		where TValueValidatorTwo : struct, IValueValidator<TValue>
	{
		private readonly TDataContainerFactory _dataContainerFactory;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;

		public Data<TDataValue> Data => new Data<TDataValue>(_dataContainerFactory.Create(_valueValidatorOne, new InvertValidator<TValueValidatorTwo, TValue>(_valueValidatorTwo), DummyValidator<TValue>.Instance));

		public DataSourceStandardInverted(TDataContainerFactory dataContainerFactory, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo)
		{
			_dataContainerFactory = dataContainerFactory;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
		}

		public DataSourceStandardInvertedStandard<TDataContainerFactory, TDataValue, TValue, TSource, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree> Add<TValueValidatorThree>(TValueValidatorThree valueValidator)
			where TValueValidatorThree : struct, IValueValidator<TValue>
			=> new DataSourceStandardInvertedStandard<TDataContainerFactory, TDataValue, TValue, TSource, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree>(_dataContainerFactory, _valueValidatorOne, _valueValidatorTwo, valueValidator);

		public static implicit operator Data<TDataValue>(DataSourceStandardInverted<TDataContainerFactory, TDataValue, TValue, TSource, TValueValidatorOne, TValueValidatorTwo> dataSource)
			=> dataSource.Data;
	}
}
