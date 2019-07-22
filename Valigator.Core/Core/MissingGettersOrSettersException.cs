using System;
using System.Linq;
using System.Reflection;

namespace Valigator.Core
{
	public class MissingGettersOrSettersException : Exception
	{
		public MissingGettersOrSettersException(PropertyInfo[] missingGetters, PropertyInfo[] missingSetters) : base($"{(missingGetters.Any() ? $"The following properties do not have a getter: {String.Join(", ", missingGetters.Select(n => n.Name))}." : "")}{(missingGetters.Any() && missingSetters.Any() ? " " : String.Empty)}{(missingSetters.Any() ? $"The following properties do not have a setter: {String.Join(", ", missingSetters.Select(n => n.Name))}." : "")}")
		{
			MissingGetters = missingGetters;
			MissingSetters = missingSetters;
		}

		public PropertyInfo[] MissingGetters { get; }
		public PropertyInfo[] MissingSetters { get; }
	}
}
