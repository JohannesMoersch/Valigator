using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Valigator.Core;
using Valigator.Newtonsoft.Json;

namespace Valigator
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class ValigatorModelAttribute : Attribute
	{
		public ValigatorModelConstructionBehaviour ModelConstructionBehaviour { get; set; }
	}

	[ValigatorModel]
	public class ValigatorAnonymousObject : ValigatorAnonymousObjectBase
	{
		internal ValigatorAnonymousObject(object inner) : base(inner)
		{
		}

		public override AttributeCollection GetAttributes()
			=> new AttributeCollection(base.GetAttributes().OfType<Attribute>().Append(new ValigatorModelAttribute()).ToArray());

		public override string GetClassName()
			=> $"{nameof(ValigatorAnonymousObject)}_{Inner.GetType().Name}";

		public static ValigatorAnonymousObject Create(object inner)
			=> new ValigatorAnonymousObject(inner);
	}
}
