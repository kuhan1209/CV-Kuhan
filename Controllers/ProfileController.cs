using Microsoft.AspNetCore.Mvc;

namespace MyCvWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                name = "Kuhan Vimalan",
                title = "Systemutvikler",
                description = "Fullstack utvikler med erfaring i .NET, React og moderne web",
                location = "Oslo, Norge",
                email = "Kuhan2001@hotmail.com",
                projects = new[]
                {
                    new {
                        name = "Arctic Asfalt",
                        description = "CO2-reduksjon og logistikk optimalisering",
                        tech = "C#, .NET, Blazor"
                    },
                    new {
                        name = "Arbeidsvarsling",
                        description = "System brukt av tusenvis langs norske veier",
                        tech = "Java, NodeJS"
                    }
                }
            });
        }
    }
}