using Microsoft.AspNetCore.Mvc;

namespace EmployeeApiDemo.Controllers
{
    [ApiController]
    [Route("Emp")]
    public class EmployeeController : ControllerBase

    {
        [HttpGet]
        public IActionResult Get()
        {
            var employees = new List<string> { "John", "Jane", "Bob" };
            return Ok(employees);
        }
    }
}

