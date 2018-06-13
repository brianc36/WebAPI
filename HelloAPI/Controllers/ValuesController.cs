using HelloAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HelloAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IService _helloService;

        public ValuesController(IService helloService)
        {
            _helloService = helloService;

        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            var msg = _helloService.GetMessage();

            return msg;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if  (id == 1)  return _helloService.GetMessage(id);

            return "Not Found";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
 
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
 
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
