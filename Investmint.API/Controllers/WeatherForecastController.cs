using Microsoft.AspNetCore.Mvc;

namespace Investmint.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecast : ControllerBase
{
  [HttpGet]
  public ActionResult<object> Get()
  {
    return new { message = "weatherforecast weatherforecast weatherforecast from Investmint API (.NET 9!)" };
  }
}
