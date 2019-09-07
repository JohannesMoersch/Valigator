using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.StateValidators;

namespace Valigator.Core
{
	public struct NullableCollectionFactory<TValue>
	{
		private readonly Data<Option<TValue>> _item;

		public NullableCollectionFactory(Data<Option<TValue>> item) 
			=> _item = item;

		public RequiredNullableCollectionStateValidator<TValue> Required()
			=> new RequiredNullableCollectionStateValidator<TValue>(_item);

		public OptionalNullableCollectionStateValidator<TValue> Optional()
			=> new OptionalNullableCollectionStateValidator<TValue>(_item);

		public DefaultedNullableCollectionStateValidator<TValue> Defaulted()
			=> new DefaultedNullableCollectionStateValidator<TValue>(_item, Array.Empty<Option<TValue>>());

		public DefaultedNullableCollectionStateValidator<TValue> Defaulted<T>(T?[] defaultValue)
			where T : struct, TValue
		{
			var arr = new Option<TValue>[defaultValue.Length];
			for (int i = 0; i < defaultValue.Length; ++i)
				arr[i] = defaultValue[i].HasValue ? Option.Some((TValue)defaultValue[i].Value) : Option.None<TValue>();

			return new DefaultedNullableCollectionStateValidator<TValue>(_item, arr);
		}

		public DefaultedNullableCollectionStateValidator<TValue> Defaulted(Option<TValue>[] defaultValue)
			=> new DefaultedNullableCollectionStateValidator<TValue>(_item, defaultValue);

		public DefaultedNullableCollectionStateValidator<TValue> Defaulted(Func<Option<TValue>[]> defaultValueFactory)
			=> new DefaultedNullableCollectionStateValidator<TValue>(_item, defaultValueFactory);
	}
}
