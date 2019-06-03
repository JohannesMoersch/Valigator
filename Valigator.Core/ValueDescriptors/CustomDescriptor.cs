using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.ValueDescriptors
{
	public class CustomDescriptor : IValueDescriptor, IEquatable<CustomDescriptor>
	{
		public string Description { get; }

		public CustomDescriptor(string criteriaDescription) 
			=> Description = criteriaDescription ?? throw new ArgumentNullException(nameof(criteriaDescription));

		public override bool Equals(object obj) 
			=> Equals(obj as CustomDescriptor);

		public bool Equals(CustomDescriptor other) 
			=> other != null && Description == other.Description;

		public bool Equals(IValueDescriptor other)
			=> other is CustomDescriptor customDescriptor && Equals(customDescriptor);

		public override int GetHashCode() 
			=> -453831141 + EqualityComparer<string>.Default.GetHashCode(Description);
	}
}
