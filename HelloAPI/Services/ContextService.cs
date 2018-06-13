using HelloData;
using HelloAPI.Interfaces;
using System.Linq;

namespace HelloAPI.Services
{
    public class ContextService : IService
    {
        private readonly HelloContext _helloContext;

        public ContextService(HelloContext helloContext)
        {
            _helloContext = helloContext;
        }

        public string GetMessage()
        {
            return _helloContext.Messages.FirstOrDefault().Message;

        }

        public string GetMessage(int id)
        {
            return _helloContext.Messages.Find(id).Message;

        }
    }
}
