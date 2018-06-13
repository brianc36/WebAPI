using HelloAPI.Interfaces;

namespace HelloAPI.Services
{
    public class ValueService: IService
    {
        public string GetMessage()
        {
            return "Hello World";
        }

        public string GetMessage(int id)
        {
            return this.GetMessage();
        }
    }
}
