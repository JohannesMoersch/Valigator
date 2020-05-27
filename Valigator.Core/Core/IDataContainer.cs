using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public interface IDataContainer { }

	public interface IDataContainer<TValue> : IDataContainer
	{
		DataDescriptor DataDescriptor { get; }

		Result<TValue, ValidationError[]> IsValid(Option<object> model, Optional<TValue> value);

		Option<ValidationError[]> GetErrors();

		/// <summary>
		/// Set a value and run value validators but not state validators.
		/// </summary>
		Data<TValue> WithUncheckedValue(Data<TValue> data, TValue value);
	}
}
