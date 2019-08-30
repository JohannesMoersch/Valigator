using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.DataSources
{
	public struct DataSourceInvertedInverted<TDataContainerFactory, TDataValue, TValue, TSource, TValueValidatorOne, TValueValidatorTwo>
		where TDataContainerFactory : struct, IDataContainerFactory<TDataValue, TValue>
		where TValueValidatorOne : struct, IValueValidator<TValue>
		where TValueValidatorTwo : struct, IValueValidator<TValue>
	{
		private readonly TDataContainerFactory _dataContainerFactory;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;

		public Data<TDataValue> Data => new Data<TDataValue>(_dataContainerFactory.Create(new InvertValidator<TValueValidatorOne, TValue>(_valueValidatorOne), new InvertValidator<TValueValidatorTwo, TValue>(_valueValidatorTwo), DummyValidator<TValue>.Instance));

		public DataSourceInvertedInverted(TDataContainerFactory dataContainerFactory, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo)
		{
			_dataContainerFactory = dataContainerFactory;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
		}

		public static implicit operator Data<TDataValue>(DataSourceInvertedInverted<TDataContainerFactory, TDataValue, TValue, TSource, TValueValidatorOne, TValueValidatorTwo> dataSource)
			=> dataSource.Data;
	}
}
