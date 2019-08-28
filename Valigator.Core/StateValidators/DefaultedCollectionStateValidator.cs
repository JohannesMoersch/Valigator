using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.DataContainers;
using Valigator.Core.Helpers;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct DefaultedCollectionStateValidator<TValue> : ICollectionStateValidator<TValue[], TValue>
	{
		private static IDataContainer<TValue[]> CreateContainer(DefaultedCollectionStateValidator<TValue> stateValidator)
			=> new CollectionDataContainer<DefaultedCollectionStateValidator<TValue>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance);

		public Data<TValue[]> Data => new Data<TValue[]>(CreateContainer(this));

		private readonly Data<TValue> _item;

		private readonly Option<TValue[]> _defaultValue;

		private readonly Func<TValue[]> _defaultValueFactory;

		public DefaultedCollectionStateValidator(Data<TValue> item, TValue[] defaultValue)
		{
			_item = item;
			_defaultValue = Option.Some(defaultValue ?? throw new NullDefaultException());
			_defaultValueFactory = default;
		}

		public DefaultedCollectionStateValidator(Data<TValue> item, Func<TValue[]> defaultValueFactory)
		{
			_item = item;
			_defaultValue = default;
			_defaultValueFactory = defaultValueFactory ?? throw new ArgumentNullException(nameof(defaultValueFactory));
		}

		private TValue[] GetDefaultValue()
			=> this.GetDefaultValue(_defaultValue, _defaultValueFactory);

		IStateDescriptor IStateValidator<TValue[], Option<TValue>[]>.GetDescriptor()
			=> new DefaultedCollectionStateDescriptor(false, GetDefaultValue(), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<TValue[], Option<TValue>[]>.GetImplicitValueDescriptors()
			=> new[] { new NotNullDescriptor() };

		Result<TValue[], ValidationError[]> IStateValidator<TValue[], Option<TValue>[]>.Validate(Option<Option<Option<TValue>[]>> value)
		{
			List<ValidationError> errors = null;
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
				{
					var values = new TValue[notNull.Length];

					for (int i = 0; i < notNull.Length; ++i)
					{
						if (notNull[i].TryGetValue(out var some))
							values[i] = some;
						else
						{
							var error = ValidationErrors.NotNull();
							error.Path.AddIndex(i);

							if (errors == null)
								errors = new List<ValidationError>();

							errors.Add(error);
						}
					}

					if (errors != null)
						return Result.Failure<TValue[], ValidationError[]>(errors.ToArray());

					return Result.Success<TValue[], ValidationError[]>(values);
				}

				return Result.Failure<TValue[], ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Success<TValue[], ValidationError[]>(GetDefaultValue());
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, TValue[] value)
			=> this.IsCollectionValid(_item, model, value);

		public static implicit operator Data<TValue[]>(DefaultedCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
