using System;
using System.ComponentModel;
using System.Linq;
using Valigator.Core;

namespace Valigator
{
	public static class ValigatorModel
	{
		public static ValigatorModel<T> Create<T>(T inner)
			=> new ValigatorModel<T>(inner);
	}

	/// <inheritdoc />
	[ValigatorModel]
	public class ValigatorModel<T> : ValigatorModelBase<T>
	{
		internal ValigatorModel(T inner) : base(inner)
		{
		}
	}
}
