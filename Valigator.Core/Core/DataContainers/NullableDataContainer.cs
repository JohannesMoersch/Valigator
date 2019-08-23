using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.DataContainers
{
	internal class NullableDataContainer<TValue> : IDataContainer<Option<TValue>>, IAcceptValue<Option<TValue>, TValue>
	{
		public DataDescriptor DataDescriptor { get; }

		public Data<Option<TValue>> Verify(Data<Option<TValue>> data, object model, bool isSet, Option<TValue> value)
			=> throw new NotImplementedException();

		public Data<Option<TValue>> WithValue(Data<Option<TValue>> data, Option<TValue> value)
			=> throw new NotImplementedException();

		Option<ValidationError[]> IDataContainer<Option<TValue>>.GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
