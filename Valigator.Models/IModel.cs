using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	public interface IModel
	{
	}

	public interface IModel<TModelView> : IModel
	{
		TModelView ToView();
	}
}
