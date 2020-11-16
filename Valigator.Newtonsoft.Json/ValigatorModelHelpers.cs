namespace Valigator
{
	public static class ValigatorModelHelpers
	{
		public static ValigatorModel<T> ToValigatorModel<T>(this T obj)
			=> ValigatorModel.Create(obj);
	}
}
