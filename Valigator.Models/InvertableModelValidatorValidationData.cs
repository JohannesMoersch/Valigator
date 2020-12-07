using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public class InvertableModelValidatorValidationData<TModel, TInput, TValue> : IInvertableModelValidationData<IInvertableModelValidator<TModel, TValue>, TModel, TInput, TValue>, IInvertableValidationData<IInvertableValidator<TValue>, TInput, TValue>
	{
		public IInvertableValidator<TValue> WithValidator(IInvertableValidator<TValue> value) 
			=> throw new NotImplementedException();
		
		public IInvertableModelValidator<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value) 
			=> throw new NotImplementedException();
	}
}
