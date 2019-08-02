using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core.ValueValidators
{
	public struct UniqueValidator<TValue, TUniqueKey> : IValueValidator<TValue[]>
	{
		private readonly Func<TValue, TUniqueKey> _selector;

		public UniqueValidator(Func<TValue, TUniqueKey> selector) 
			=> _selector = selector;

		IValueDescriptor IValueValidator<TValue[]>.GetDescriptor()
			=> new UniqueDescriptor();

		bool IValueValidator<TValue[]>.IsValid(TValue[] value)
			=> value.Length <= 1 ? true : !GetDuplicates(value).Any();

		ValidationError IValueValidator<TValue[]>.GetError(TValue[] value, bool inverted)
			=> new ValidationError(nameof(UniqueValidator<TUniqueKey, TValue>), (this as IValueValidator<TValue[]>).GetDescriptor());
		
		private IEnumerable<TUniqueKey> GetDuplicates(TValue[] values)
		{
			var set = new HashSet<TUniqueKey>();

			foreach (var item in values.Select(_selector))
			{
				if (!set.Add(item))
					yield return item;
			}
		}
	}
}
