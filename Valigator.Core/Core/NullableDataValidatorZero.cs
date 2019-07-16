using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public class NullableDataValidator<TStateValidator, TSource> : IDataValidatorOrErrors<Option<TSource>>
		where TStateValidator : IStateValidator<Option<TSource>>
	{
		public DataDescriptor DataDescriptor => new DataDescriptor(typeof(TSource), _stateValidator.GetDescriptor(), _stateValidator.GetImplicitValueDescriptors());

		private readonly TStateValidator _stateValidator;

		public NullableDataValidator(TStateValidator stateValidator) 
			=> _stateValidator = stateValidator;

		public Result<Option<TSource>, ValidationError[]> Validate(object model, bool isSet, Option<TSource> value)
		{
			if (_stateValidator.Validate(model, isSet, value).TryGetValue(out var success, out var failure))
			{
				if (!success.TryGetValue(out var some))
					return Result.Success<Option<TSource>, ValidationError[]>(success);

				if (Model.Verify(some).TryGetValue(out var _, out var modelErrors))
					return Result.Success<Option<TSource>, ValidationError[]>(success);

				return Result.Failure<Option<TSource>, ValidationError[]>(modelErrors);
			}

			return Result.Failure<Option<TSource>, ValidationError[]>(failure);
		}

		public Option<ValidationError[]> GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
