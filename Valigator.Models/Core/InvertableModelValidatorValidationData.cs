using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Core
{
	public class InvertableModelValidatorValidationData<TModel, TValue> : IInvertableModelValidationData<IInvertableModelValidator<TModel, TValue>, TModel, TValue>, IInvertableValidationData<IInvertableValidator<TValue>, TValue>
	{
		public IInvertableValidator<TValue> WithValidator(IInvertableValidator<TValue> value) 
			=> throw new NotImplementedException();
		
		public IInvertableModelValidator<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value) 
			=> throw new NotImplementedException();
	}
}
