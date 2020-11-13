using System;
using System.ComponentModel;
using System.Linq;
using Valigator.Core;

namespace Valigator
{
	/// <inheritdoc />
	[ValigatorModel]
	public class ValigatorModel : ValigatorModelBase
	{
		internal ValigatorModel(object inner) : base(inner)
		{
		}

		public static ValigatorModel Create(object inner)
			=> new ValigatorModel(inner);
	}
}
