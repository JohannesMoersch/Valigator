﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.DataContainers.Factories
{
	public struct DataContainerFactory<TStateValidator, TSource, TValue> : IDataContainerFactory<TValue, TValue>
		where TStateValidator : struct, IStateValidator<TValue, TValue>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Mapping<TSource, TValue> _mapping;

		public DataContainerFactory(TStateValidator stateValidator, Mapping<TSource, TValue> mapping)
		{
			_stateValidator = stateValidator;
			_mapping = mapping;
		}

		public IDataContainer<TValue> Create<TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree>(TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
			where TValueValidatorOne : struct, IValueValidator<TValue>
			where TValueValidatorTwo : struct, IValueValidator<TValue>
			where TValueValidatorThree : struct, IValueValidator<TValue>
			=> new DataContainer<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue>(_mapping, _stateValidator, valueValidatorOne, valueValidatorTwo, valueValidatorThree);
	}
}
