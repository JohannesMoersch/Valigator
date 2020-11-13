using System;
using System.ComponentModel;
using System.Linq;
using Valigator.Core;

namespace Valigator.Text.Json
{
	/// <inheritdoc />
	[ValigatorModel]
	public class ValigatorModel : ValigatorModelBase
	{
		internal ValigatorModel(object inner) : base(inner)
		{
		}

		public override AttributeCollection GetAttributes()
			=> new AttributeCollection(base.GetAttributes().OfType<Attribute>().Append(new ValigatorModelAttribute()).ToArray());

		public override string GetClassName()
			=> $"{nameof(ValigatorModel)}_{Inner.GetType().Name}";

		public static ValigatorModel Create(object inner)
			=> new ValigatorModel(inner);
	}
}
