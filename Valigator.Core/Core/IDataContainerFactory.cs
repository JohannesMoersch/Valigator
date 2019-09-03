using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IDataContainerFactory<TDataValue, TValue>
	{
		IDataContainer<TDataValue> Create<TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree>(TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
			where TValueValidatorOne : struct, IValueValidator<TValue>
			where TValueValidatorTwo : struct, IValueValidator<TValue>
			where TValueValidatorThree : struct, IValueValidator<TValue>;
	}
}
