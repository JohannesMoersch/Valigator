using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.StateDescriptors
{
	public class StateDescriptor : IStateDescriptor, IEquatable<StateDescriptor>
	{
		public Option<object> DefaultValue { get; }

		public StateDescriptor(Option<object> defaultValue) 
			=> DefaultValue = defaultValue;

		public override bool Equals(object obj) 
			=> Equals(obj as StateDescriptor);

		public bool Equals(IStateDescriptor other)
			=> Equals(other as StateDescriptor);

		public bool Equals(StateDescriptor other) 
			=> other != null && DefaultValue.Equals(other.DefaultValue);

		public override int GetHashCode() 
			=> -2090468489 + EqualityComparer<Option<object>>.Default.GetHashCode(DefaultValue);
	}
}
