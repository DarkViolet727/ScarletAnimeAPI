using Microsoft.EntityFrameworkCore;
using ScarletAnimeAPI.Models;

namespace ScarletAnimeAPI.Services;

public class TitleService
{
    private readonly AppDbContext _context;

    public TitleService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Title>> GetAllTitlesAsync()
    {
        return await _context.Title.ToListAsync();
    }

    public async Task<Title> GetTitleByIdAsync(int id)
    {
        return await _context.Title.FindAsync(id);
    }

    public async Task<Title> AddTitleAsync(Title title)
    {
        _context.Title.Add(title);
        await _context.SaveChangesAsync();
        return title;
    }

    public async Task<bool> DeleteTitleAsync(int id)
    {
        var title = await _context.Title.FindAsync(id);
        if (title == null) return false;

        _context.Title.Remove(title);
        await _context.SaveChangesAsync();
        return true;
    }
}