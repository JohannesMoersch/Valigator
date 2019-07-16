using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Valigator.Core;

namespace Valigator.AspNetCore
{
	public class ValigatorActionFilter : IActionFilter, IOrderedFilter
	{
		public static int Order => -2500;

		int IOrderedFilter.Order => Order;

		private readonly Func<ModelError[], IActionResult> _resultErrorCreator;

		public ValigatorActionFilter(Func<ModelError[], IActionResult> resultErrorCreator)
			=> _resultErrorCreator = resultErrorCreator;

		public void OnActionExecuting(ActionExecutingContext context)
		{
			List<ModelError> modelErrors = null;

			foreach (var parameter in context.ActionDescriptor.Parameters.OfType<ControllerParameterDescriptor>())
			{
				var validateAttributes = GetValidateAttributes(parameter);

				var (isSet, value) = GetValueForParameter(context, parameter);

				IEnumerable<ValidationError> errors = null;

				if (validateAttributes.Any())
					(context.ActionArguments[parameter.Name], errors) = VerifyValueForParameter(parameter, validateAttributes, isSet, value);
				else if (isSet)
					errors = Model.Verify(value).Match(_ => null, _ => _);

				if (errors != null)
					(modelErrors ?? (modelErrors = new List<ModelError>())).AddRange(CreateModelErrorsForParameter(parameter, errors));
			}

			if (modelErrors?.Any() ?? false)
				context.Result = _resultErrorCreator.Invoke(modelErrors.ToArray());
		}

		private ValidateAttribute[] GetValidateAttributes(ControllerParameterDescriptor parameter)
			=> parameter
				.ParameterInfo
				.GetCustomAttributes(typeof(ValidateAttribute), true)
				.OfType<ValidateAttribute>()
				.ToArray();

		private (bool isSet, object value) GetValueForParameter(ActionExecutingContext context, ControllerParameterDescriptor parameter)
		{
			if (context.ActionArguments.TryGetValue(parameter.Name, out var value))
				return (true, value);

			if (parameter.ParameterInfo.HasDefaultValue)
				return (true, parameter.ParameterInfo.DefaultValue);

			return (false, default);
		}

		private (object value, IEnumerable<ValidationError> errors) VerifyValueForParameter(ControllerParameterDescriptor parameter, ValidateAttribute[] validateAttributes, bool isSet, object value)
		{
			List<ValidationError[]> errors = null;
			foreach (var attribute in validateAttributes)
			{
				Result<object, ValidationError[]> result;

				if (isSet)
					result = attribute.Verify(parameter.ParameterType, value);
				else
					result = attribute.Verify(parameter.ParameterType);

				isSet = true;

				result
					.Match
					(
						success => value = success,
						failure =>
						{
							(errors ?? (errors = new List<ValidationError[]>())).Add(failure);
							return null;
						}
					);
			}

			return (value, errors?.SelectMany(_ => _));
		}

		private ModelSource ConvertBindingSourceToModelSource(BindingSource source)
		{
			if (source == BindingSource.Body)
				return ModelSource.Body;

			if (source == BindingSource.Header)
				return ModelSource.Header;

			if (source == BindingSource.Path)
				return ModelSource.Path;

			if (source == BindingSource.Query)
				return ModelSource.Query;

			return ModelSource.Other;
		}

		private IEnumerable<ModelError> CreateModelErrorsForParameter(ControllerParameterDescriptor parameter, IEnumerable<ValidationError> validationErrors)
		{
			var name = parameter.BindingInfo?.BinderModelName ?? parameter.Name ?? String.Empty;
			var source = ConvertBindingSourceToModelSource(parameter.BindingInfo?.BindingSource);

			return validationErrors.Select(error => new ModelError(name, source, error));
		}

		public void OnActionExecuted(ActionExecutedContext context) { }
	}
}
