using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.AddControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"this", "is", "hard", "coded"};
        }
    }
}