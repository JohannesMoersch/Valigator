using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core.DataContainers
{
	internal class NullableCollectionDataContainer<TValue> : IDataContainer<Option<TValue[]>>, IAcceptCollectionValue<Option<TValue[]>, TValue>
	{
		public DataDescriptor DataDescriptor { get; }

		public Data<Option<TValue[]>> Verify(Data<Option<TValue[]>> data, object model, bool isSet, Option<TValue[]> value)
			=> throw new NotImplementedException();

		public Data<Option<TValue[]>> WithValue(Data<Option<TValue[]>> data, Option<Option<TValue>[]> value)
			=> throw new NotImplementedException();

		Option<ValidationError[]> IDataContainer<Option<TValue[]>>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
