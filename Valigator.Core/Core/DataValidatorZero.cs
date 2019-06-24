using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public class DataValidator<TStateValidator, TSource> : IDataValidatorOrErrors<TSource>
		where TStateValidator : IStateValidator<TSource>
	{
		public DataDescriptor DataDescriptor => new DataDescriptor(typeof(TSource), _stateValidator.GetDescriptor(), _stateValidator.GetImplicitValueDescriptors());

		private readonly TStateValidator _stateValidator;

		public DataValidator(TStateValidator stateValidator) 
			=> _stateValidator = stateValidator;

		public Result<TSource, ValidationError[]> Validate(object model, bool isSet, TSource value)
		{
			if (_stateValidator.Validate(model, isSet, value).TryGetValue(out var success, out var failure))
			{
				if (Model<TSource>.Verify(success).TryGetValue(out var _, out var modelErrors))
					return Result.Success<TSource, ValidationError[]>(success);

				return Result.Failure<TSource, ValidationError[]>(modelErrors);
			}

			return Result.Failure<TSource, ValidationError[]>(failure);
		}

		public Option<ValidationError[]> GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
