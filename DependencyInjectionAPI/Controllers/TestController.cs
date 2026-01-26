using DependencyInjectionAPI;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionAPI
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly Services.IMyService _service1;
        private readonly Services.IMyService _service2;

        public TestController(Services.IMyService service1, Services.IMyService service2)
        {
            _service1 = service1;
            _service2 = service2;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                FirstInstance = _service1.Id,
                SecondInstance = _service2.Id
            });
        }
    }
}