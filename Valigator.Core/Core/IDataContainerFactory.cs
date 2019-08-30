using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	internal interface IDataContainerFactory<TDataValue, TValue>
	{
		IDataContainer<TDataValue> Create<TValidatorOne, TValidatorTwo, TValidatorThree>()
			where TValidatorOne : IValueValidator<TValue>
			where TValidatorTwo : IValueValidator<TValue>
			where TValidatorThree : IValueValidator<TValue>;
	}
}
