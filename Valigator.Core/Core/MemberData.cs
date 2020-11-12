using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Valigator.Core
{
	internal struct MemberData
	{
		public string Name { get; }
		public Type Type { get; }
		public Type ComponentType { get; }
		public Attribute[] CustomAttributes { get; }

		public MemberData(string name, Type type, Type componentType, IEnumerable<Attribute> customAttributes) : this(name, type, componentType, customAttributes.ToArray()) { }

		public MemberData(string name, Type type, Type componentType, Attribute[] customAttributes) : this()
		{
			Name = name;
			Type = type;
			ComponentType = componentType;
			CustomAttributes = customAttributes;
		}

		public PropertyInfo GetPropertyInfo()
			=> ComponentType?.GetProperty(Name);
	}
}
