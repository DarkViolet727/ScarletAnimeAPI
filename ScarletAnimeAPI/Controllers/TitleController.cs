using Microsoft.AspNetCore.Mvc;
using ScarletAnimeAPI.Models;
using ScarletAnimeAPI.Services;

namespace ScarletAnimeAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TitlesController : ControllerBase
{
    private readonly TitleService _service;

    public TitlesController(TitleService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Title>>> GetAllTitles()
    {
        return await _service.GetAllTitlesAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Title>> GetTitleById(int id)
    {
        var title = await _service.GetTitleByIdAsync(id);
        if (title == null)
        {
            return NotFound();
        }

        return title;
    }

    [HttpPost]
    public async Task<ActionResult<Title>> CreateTitle(Title title)
    {
        await _service.AddTitleAsync(title);
        return CreatedAtAction(nameof(GetTitleById), new { id = title.id }, title);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTitle(int id)
    {
        var deleted = await _service.DeleteTitleAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}