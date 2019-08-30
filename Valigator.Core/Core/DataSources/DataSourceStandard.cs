﻿using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.DataSources
{
	public struct DataSourceStandard<TDataContainerFactory, TDataValue, TValue, TSource, TValueValidatorOne>
		where TDataContainerFactory : struct, IDataContainerFactory<TDataValue, TValue>
		where TValueValidatorOne : struct, IValueValidator<TValue>
	{
		private readonly TDataContainerFactory _dataContainerFactory;
		private readonly TValueValidatorOne _valueValidatorOne;

		public Data<TDataValue> Data => new Data<TDataValue>(_dataContainerFactory.Create(_valueValidatorOne, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance));

		public DataSourceStandard(TDataContainerFactory dataContainerFactory, TValueValidatorOne valueValidatorOne)
		{
			_dataContainerFactory = dataContainerFactory;
			_valueValidatorOne = valueValidatorOne;
		}

		public static implicit operator Data<TDataValue>(DataSourceStandard<TDataContainerFactory, TDataValue, TValue, TSource, TValueValidatorOne> dataSource)
			=> dataSource.Data;
	}
}
