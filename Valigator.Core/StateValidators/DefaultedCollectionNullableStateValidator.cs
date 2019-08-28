using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.DataContainers;
using Valigator.Core.Helpers;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct DefaultedCollectionNullableStateValidator<TValue> : ICollectionStateValidator<Option<TValue>[], TValue>
	{
		private static IDataContainer<Option<TValue>[]> CreateContainer(DefaultedCollectionNullableStateValidator<TValue> stateValidator)
			=> new CollectionNullableDataContainer<DefaultedCollectionNullableStateValidator<TValue>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance);

		public Data<Option<TValue>[]> Data => new Data<Option<TValue>[]>(CreateContainer(this));

		private readonly Data<Option<TValue>> _item;

		private readonly Option<Option<TValue>[]> _defaultValue;

		private readonly Func<Option<TValue>[]> _defaultValueFactory;

		public DefaultedCollectionNullableStateValidator(Data<Option<TValue>> item, Option<TValue>[] defaultValue)
		{
			_item = item;
			_defaultValue = Option.Some(defaultValue ?? throw new NullDefaultException());
			_defaultValueFactory = default;
		}

		public DefaultedCollectionNullableStateValidator(Data<Option<TValue>> item, Func<Option<TValue>[]> defaultValueFactory)
		{
			_item = item;
			_defaultValue = default;
			_defaultValueFactory = defaultValueFactory ?? throw new ArgumentNullException(nameof(defaultValueFactory));
		}

		private Option<TValue>[] GetDefaultValue()
			=> this.GetDefaultValue(_defaultValue, _defaultValueFactory);

		IStateDescriptor IStateValidator<Option<TValue>[], Option<TValue>[]>.GetDescriptor()
			=> new DefaultedCollectionStateDescriptor(true, GetDefaultValue(), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Option<TValue>[], Option<TValue>[]>.GetImplicitValueDescriptors()
			=> Array.Empty<IValueDescriptor>();

		Result<Option<TValue>[], ValidationError[]> IStateValidator<Option<TValue>[], Option<TValue>[]>.Validate(Option<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
					return Result.Success<Option<TValue>[], ValidationError[]>(notNull);

				return Result.Failure<Option<TValue>[], ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Success<Option<TValue>[], ValidationError[]>(GetDefaultValue());
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Option<TValue>[] value)
		{
			List<ValidationError> errors = null;
			for (int i = 0; i < value.Length; ++i)
			{
				if (!_item.WithValue(value[i]).Verify(model).TryGetValue().TryGetValue(out var _, out var failure))
				{
					foreach (var error in errors)
						error.Path.AddIndex(i);

					if (errors == null)
						errors = new List<ValidationError>();

					errors.AddRange(failure);
				}
			}

			if (errors != null)
				return Result.Failure<Unit, ValidationError[]>(errors.ToArray());

			return Result.Unit<ValidationError[]>();
		}

		public Result<Option<TValue>[], ValidationError[]> Validate(Option<Option<Option<TValue>[]>> value) => throw new NotImplementedException();

		public static implicit operator Data<Option<TValue>[]>(DefaultedCollectionNullableStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
