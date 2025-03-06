using ScarletAnimeAPI;
using Microsoft.EntityFrameworkCore;
using ScarletAnimeAPI.Models;

namespace ScarletAnimeAPI;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Title> Title { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

