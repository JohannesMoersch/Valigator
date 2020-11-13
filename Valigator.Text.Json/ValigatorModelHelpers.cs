using Valigator.Text.Json;

namespace Valigator
{
	public static class ValigatorModelHelpers
	{
		public static ValigatorModel ToValigatorModel(this object obj)
			=> ValigatorModel.Create(obj);
	}
}
