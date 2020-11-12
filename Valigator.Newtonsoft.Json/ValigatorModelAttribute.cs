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
	public static class ValigatorAnonymousObject
	{
		public static ValigatorAnonymousObject<T> Create<T>(T inner)
			=> new ValigatorAnonymousObject<T>(inner);
	}

	[ValigatorModel]
	public class ValigatorAnonymousObject<T> : ValigatorAnonymousObjectBase<T>
	{
		internal ValigatorAnonymousObject(object inner) : base(inner)
		{
		}

		public override AttributeCollection GetAttributes()
			=> new AttributeCollection(base.GetAttributes().OfType<Attribute>().Append(new ValigatorModelAttribute()).ToArray());

		public override string GetClassName()
			=> $"{nameof(ValigatorAnonymousObject)}_{Inner.GetType().Name}";
	}
}
