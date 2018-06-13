namespace HelloAPI.Interfaces
{
    public interface IService
    {
        string GetMessage();

        string GetMessage(int id);
    }
}
