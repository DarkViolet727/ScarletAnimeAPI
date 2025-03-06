namespace ScarletAnimeAPI.Models;

public class Title
{
    public int id { get; set; }
    
    public string jap_name { get; set; }
    
    public string rus_name { get; set; }
    
    public byte[]? cover_image { get; set; }
    
    public byte[]? background_image { get; set; }
    
    public DateTime created_at { get; set; } = DateTime.UtcNow;
    
    public string description { get; set; }
}