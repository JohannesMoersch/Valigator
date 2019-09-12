using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using Valigator.Core.Helpers;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public static class Mapping
	{
		private class DelegateCache<TValue, TError>
		{
			public static readonly Func<TValue, Result<TValue, TError>> Success = value => Result.Success<TValue, TError>(value);
		}

		public static Mapping<TValue, TValue> CreatePassthrough<TValue>()
			=> new Mapping<TValue, TValue>(DelegateCache<TValue, ValidationError[]>.Success, Option.None<Data<TValue>>());

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<TResult, ValidationError[]>> mapper)
			=> Create(mapper, Option.None<Data<TInput>>());

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<Option<TResult>, ValidationError[]>> mapper)
			=> Create(mapper, Option.None<Data<TInput>>());

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, TResult> mapper)
			=> Create(mapper, Option.None<Data<TInput>>());

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Option<TResult>> mapper)
			=> Create(mapper, Option.None<Data<TInput>>());

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<TResult, ValidationError[]>> mapper, Func<RequiredStateValidator<TInput>, Data<TInput>> sourceValidations)
			=> Create(mapper, Option.Some(sourceValidations.Invoke(Data.Required<TInput>())));

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<Option<TResult>, ValidationError[]>> mapper, Func<RequiredStateValidator<TInput>, Data<TInput>> sourceValidations)
			=> Create(mapper, Option.Some(sourceValidations.Invoke(Data.Required<TInput>())));

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, TResult> mapper, Func<RequiredStateValidator<TInput>, Data<TInput>> sourceValidations)
			=> Create(mapper, Option.Some(sourceValidations.Invoke(Data.Required<TInput>())));

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Option<TResult>> mapper, Func<RequiredStateValidator<TInput>, Data<TInput>> sourceValidations)
			=> Create(mapper, Option.Some(sourceValidations.Invoke(Data.Required<TInput>())));

		private static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, TResult> mapper, Option<Data<TInput>> sourceValidations)
			=> new Mapping<TInput, TResult>(mapper, sourceValidations);

		private static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Option<TResult>> mapper, Option<Data<TInput>> sourceValidations)
			=> new Mapping<TInput, TResult>(mapper, sourceValidations);

		private static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<TResult, ValidationError[]>> mapper, Option<Data<TInput>> sourceValidations)
			=> new Mapping<TInput, TResult>(mapper, sourceValidations);

		private static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<Option<TResult>, ValidationError[]>> mapper, Option<Data<TInput>> sourceValidations)
			=> new Mapping<TInput, TResult>(mapper, sourceValidations);
	}

	public struct Mapping<TSource, TValue>
	{
		private readonly object _mapper;

		private readonly Option<Data<TSource>> _sourceValidations;

		public MappedFromDescriptor MappingDescriptor => new MappedFromDescriptor(typeof(TSource), _sourceValidations.TryGetValue(out var some) ? some.DataDescriptor.ValueDescriptors.Where(o => !(o is RequiredDescriptor) && !(o is NotNullDescriptor)).ToArray() : Array.Empty<IValueDescriptor>());

		internal Mapping(Func<TSource, TValue> mapper, Option<Data<TSource>> sourceValidations)
		{
			_mapper = mapper;
			_sourceValidations = sourceValidations;
		}

		internal Mapping(Func<TSource, Result<TValue, ValidationError[]>> mapper, Option<Data<TSource>> sourceValidations)
		{
			_mapper = mapper;
			_sourceValidations = sourceValidations;
		}

		internal Mapping(Func<TSource, Option<TValue>> mapper, Option<Data<TSource>> sourceValidations)
		{
			_mapper = mapper;
			_sourceValidations = sourceValidations;
		}

		internal Mapping(Func<TSource, Result<Option<TValue>, ValidationError[]>> mapper, Option<Data<TSource>> sourceValidations)
		{
			_mapper = mapper;
			_sourceValidations = sourceValidations;
		}

		public Result<Option<TValue>, ValidationError[]> Map(TSource input)
		{
			Result<TSource, ValidationError[]> verifiedInput;
			if (_sourceValidations.TryGetValue(out var some))
			{
				verifiedInput = some
					.WithValue(Option.Some(input))
					.Verify(Option.None<TSource>())
					.TryGetValue();
			}
			else
				verifiedInput = Result.Success<TSource, ValidationError[]>(input);

			if (verifiedInput.TryGetValue(out var success, out var failure))
			{
				if (_mapper is Func<TSource, TValue> mapper)
					return Result.Success<Option<TValue>, ValidationError[]>(Option.Some(mapper.Invoke(success)));

				if (_mapper is Func<TSource, Result<TValue, ValidationError[]>> mapperWithErrors)
				{
					if (mapperWithErrors.Invoke(success).TryGetValue(out var s, out var f))
						return Result.Success<Option<TValue>, ValidationError[]>(Option.Some(s));

					return Result.Failure<Option<TValue>, ValidationError[]>(f);
				}

				if (_mapper is Func<TSource, Option<TValue>> nullableMapper)
					return Result.Success<Option<TValue>, ValidationError[]>(nullableMapper.Invoke(success));

				if (_mapper is Func<TSource, Result<Option<TValue>, ValidationError[]>> nullableMapperWithErrors)
				{
					if (nullableMapperWithErrors.Invoke(success).TryGetValue(out var s, out var f))
						return Result.Success<Option<TValue>, ValidationError[]>(s);

					return Result.Failure<Option<TValue>, ValidationError[]>(f);
				}

				return Result.Failure<Option<TValue>, ValidationError[]>(Array.Empty<ValidationError>());
			}

			return Result.Failure<Option<TValue>, ValidationError[]>(failure);
		}
	}
}
