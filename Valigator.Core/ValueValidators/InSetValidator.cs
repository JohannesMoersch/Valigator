using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core.ValueValidators
{
	public struct InSetValidator<TValue> : IValueValidator<TValue>
	{
		private readonly TValue[] _options;

		private readonly ISet<TValue> _optionSet;

		public InSetValidator(TValue[] options)
		{
			_options = options ?? throw new ArgumentNullException(nameof(options));
			_optionSet = null;
		}

		public InSetValidator(ISet<TValue> optionSet)
		{
			_options = null;
			_optionSet = optionSet ?? throw new ArgumentNullException(nameof(optionSet));
		}

		IValueDescriptor IValueValidator<TValue>.GetDescriptor()
			=> new InSetDescriptor((_options.AsEnumerable() ?? _optionSet).Cast<object>().ToArray());

		bool IValueValidator<TValue>.IsValid(TValue value)
			=> _options != null
				? _options.Contains(value)
				: _optionSet.Contains(value);

		ValidationError IValueValidator<TValue>.GetError(TValue value, bool inverted)
			=> new ValidationError("");
	}
}
