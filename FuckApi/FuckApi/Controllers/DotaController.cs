using Microsoft.AspNetCore.Mvc;
using FuckApi.Services;

namespace FuckApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DotaController : ControllerBase
{
    private readonly IParsingService _parsingService;

    public DotaController(IParsingService parsingService)
    {
        _parsingService = parsingService;
    }

    [HttpGet]
    public async Task<IActionResult> ParseDota([FromQuery] int count = 10)
    {
        try
        {
            var heroTags = new List<string> { "bounty_hunter", "broodmother", "enigma" };

            var items = await _parsingService.ParseItemsForHeroes(heroTags, count);

            return Ok(items);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}