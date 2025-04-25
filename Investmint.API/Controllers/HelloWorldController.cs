using Microsoft.AspNetCore.Mvc;

namespace Investmint.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
  [HttpGet]
  public ActionResult<object> Get()
  {
    return new { message = "Hello from Investmint API (.NET 9!)" };
  }
}
