namespace Valigator
{
	public interface IValidateType<TValue>
	{
		Data<TValue> GetData();
	}
}
