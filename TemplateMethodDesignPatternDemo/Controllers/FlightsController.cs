using Microsoft.AspNetCore.Mvc;
using TemplateMethodDesignPatternDemo.Services;
namespace TemplateMethodDesignPatternDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FlightsController(IFileService fileService) : ControllerBase
{
    [HttpPost]
    public IActionResult Import(IFormFile file)
    {
        var flights = fileService.Import(file);

        return Ok(flights);
    }
}
