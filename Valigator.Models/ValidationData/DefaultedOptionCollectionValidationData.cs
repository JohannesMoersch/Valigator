﻿using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedOptionCollectionValidationData<TValue> : ValidationDataBase<IReadOnlyList<Option<TValue>>>, IPropertyData<IReadOnlyList<Option<TValue>>, IReadOnlyList<Option<TValue>>>, IRootValidationData<DefaultedOptionCollectionValidationData<TValue>, IReadOnlyList<Option<TValue>>>
	{
		private readonly Func<IReadOnlyList<Option<TValue>>> _defaultValue;

		private readonly ValidationData<IReadOnlyList<Option<TValue>>> _validationData;

		public DefaultedOptionCollectionValidationData(Func<IReadOnlyList<Option<TValue>>> defaultValue, ValidationData<IReadOnlyList<Option<TValue>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedOptionCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedOptionCollectionValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedOptionCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedOptionCollectionValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public override Result<IReadOnlyList<Option<TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Success<IReadOnlyList<Option<TValue>>, ValidationError[]>(_defaultValue.Invoke());

		public override Result<IReadOnlyList<Option<TValue>>, ValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyList<Option<TValue>>, ValidationError[]>(new[] { CoercionValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyList<Option<TValue>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> Result.Success<IReadOnlyList<Option<TValue>>, ValidationError[]>(value);

		public override Result<Unit, ValidationError[]> Validate(IReadOnlyList<Option<TValue>> value)
			=> _validationData.Process(value);
	}
}
