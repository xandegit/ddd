using Microsoft.AspNetCore.Mvc;
// using DddMvc.AppServices.Interfaces.Services;
namespace DddMvc.AspNetMvc.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Produces(typeof(string))]
        public async Task<IActionResult> Get()
        {
            var result = "Global User";
            _logger.LogInformation($"Result: {result}");
            return Ok(result);
        }
    }
}