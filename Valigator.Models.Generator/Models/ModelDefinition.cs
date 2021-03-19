using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.ModelValidationData;

namespace Valigator.Models
{
	public abstract class ModelDefinition<TModelView>
	{
		protected static ModelPropertyFactory<TModelView> Data => ModelPropertyFactory<TModelView>.Instance;

		public class Property<TValue>
		{
			private readonly IModelPropertyData<TModelView, TValue> _data;

			public Property(IModelPropertyData<TModelView, TValue> data) 
				=> _data = data;

			public Result<TValue, ValidationError[]> CoerceNone()
				=> _data.CoerceNone();

			public Result<TValue, ValidationError[]> CoerceUnset()
				=> _data.CoerceUnset();

			public Result<TValue, ValidationError[]> CoerceValue<TInput>(TInput input)
				=> (_data as IModelPropertyData<TModelView, TInput, TValue> ?? throw new Exception()).CoerceValue(input);

			public Result<Unit, ValidationError[]> Validate(TModelView model, TValue value)
				=> _data.Validate(model, value);

			public static implicit operator Property<TValue>(ModelValidationDataBase<TModelView, TValue> propertyData)
				=> new Property<TValue>(propertyData);
		}
	}
}
