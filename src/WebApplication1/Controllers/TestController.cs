using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace Mc.Test.Web.Controllers;

[ApiController]
[Consumes(MediaTypeNames.Application.Json)]
public class TestController : ControllerBase
{
    /// <summary>
    /// Test Controller endpoint
    /// </summary>
    /// <returns>Test</returns>
    [HttpGet]
    [Route("/test")]
    public async Task<IActionResult> Test()
    {
        await Task.CompletedTask;
        return Ok("hello world");
    }
}