using Microsoft.AspNetCore.Mvc;

namespace MyProject.API.Controllers;

[ApiController]
[Route("api/health")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("OK");
}
