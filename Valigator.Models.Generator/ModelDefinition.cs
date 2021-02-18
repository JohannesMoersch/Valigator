using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.ModelValidationData;

namespace Valigator
{
	public abstract class ModelDefinition<TModel, TModelView>
		where TModel : IModel<TModelView>
	{
		protected static ModelPropertyFactory<TModel> Data => ModelPropertyFactory<TModel>.Instance;

		public class Property<TValue>
		{
			private readonly IModelPropertyData<TModel, TValue> _data;

			public Property(IModelPropertyData<TModel, TValue> data) 
				=> _data = data;

			public Result<TValue, ValidationError[]> CoerceNone()
				=> _data.CoerceNone();

			public Result<TValue, ValidationError[]> CoerceUnset()
				=> _data.CoerceUnset();

			public Result<TValue, ValidationError[]> CoerceValue<TInput>(TInput input)
				=> (_data as IModelPropertyData<TModel, TInput, TValue> ?? throw new Exception()).CoerceValue(input);

			public Result<Unit, ValidationError[]> Validate(TModel model, TValue value)
				=> _data.Validate(model, value);

			public static implicit operator Property<TValue>(ModelValidationDataBase<TModel, TValue> propertyData)
				=> new Property<TValue>(propertyData);
		}
	}
}
