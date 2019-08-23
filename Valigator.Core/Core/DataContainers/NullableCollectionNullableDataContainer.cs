using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.DataContainers
{
	internal class NullableCollectionNullableDataContainer<TValue> : IDataContainer<Option<Option<TValue>[]>>, IAcceptCollectionValue<Option<Option<TValue>[]>, TValue>
	{
		public DataDescriptor DataDescriptor { get; }

		public Data<Option<Option<TValue>[]>> Verify(Data<Option<Option<TValue>[]>> data, object model, bool isSet, Option<Option<TValue>[]> value)
			=> throw new NotImplementedException();

		public Data<Option<Option<TValue>[]>> WithValue(Data<Option<Option<TValue>[]>> data, Option<Option<TValue>[]> value)
			=> throw new NotImplementedException();

		Option<ValidationError[]> IDataContainer<Option<Option<TValue>[]>>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
