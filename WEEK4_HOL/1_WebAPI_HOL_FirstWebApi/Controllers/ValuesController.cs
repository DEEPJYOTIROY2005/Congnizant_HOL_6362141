using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new[] { "value1", "value2" });

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok($"value {id}");

        [HttpPost]
        public IActionResult Post([FromBody] string value) => Ok($"Received: {value}");

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value) => Ok($"Updated {id} to {value}");

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) => Ok($"Deleted value {id}");
    }
}
