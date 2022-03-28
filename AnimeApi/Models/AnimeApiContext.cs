using Microsoft.EntityFrameworkCore;

namespace AnimeApi.Models
{
    public class AnimeApiContext : DbContext
    {
        public AnimeApiContext(DbContextOptions<AnimeApiContext> options)
            : base(options)
        {
        }

        public DbSet<Anime> Animals { get; set; }
    }
}