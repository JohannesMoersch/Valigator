using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.DataSources
{
	public struct DataSource<TDataContainerFactory, TDataValue, TValue, TSource>
		where TDataContainerFactory : struct, IDataContainerFactory<TDataValue, TValue>
	{
		private readonly TDataContainerFactory _dataContainerFactory;

		public Data<TDataValue> Data => new Data<TDataValue>(_dataContainerFactory.Create(DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance));

		public DataSource(TDataContainerFactory dataContainerFactory) 
			=> _dataContainerFactory = dataContainerFactory;

		public DataSourceStandard<TDataContainerFactory, TDataValue, TValue, TSource, TValueValidatorOne> Add<TValueValidatorOne>(TValueValidatorOne valueValidator)
			where TValueValidatorOne : struct, IValueValidator<TValue>
			=> new DataSourceStandard<TDataContainerFactory, TDataValue, TValue, TSource, TValueValidatorOne>(_dataContainerFactory, valueValidator);

		public static implicit operator Data<TDataValue>(DataSource<TDataContainerFactory, TDataValue, TValue, TSource> dataSource)
			=> dataSource.Data;
	}
}
