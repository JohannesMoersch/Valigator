using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.ValueDescriptors
{
	public class InSetDescriptor : IValueDescriptor, IEquatable<InSetDescriptor>
	{
		public IReadOnlyList<object> Options { get; }

		public InSetDescriptor(object[] options)
			=> Options = options ?? throw new ArgumentNullException(nameof(options));

		public override bool Equals(object obj)
			=> Equals(obj as InSetDescriptor);

		public bool Equals(InSetDescriptor other)
			=> other != null && Options.SequenceEqual(other.Options));
		
		public bool Equals(IValueDescriptor other)
			=> other is InSetDescriptor inSetDescriptor && Equals(inSetDescriptor);

		public override int GetHashCode()
			=> 37816589 + EqualityComparer<IReadOnlyList<object>>.Default.GetHashCode(Options);
	}
}
