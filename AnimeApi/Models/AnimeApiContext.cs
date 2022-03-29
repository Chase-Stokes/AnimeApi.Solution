using Microsoft.EntityFrameworkCore;

namespace AnimeApi.Models
{
    public class AnimeApiContext : DbContext
    {
        public AnimeApiContext(DbContextOptions<AnimeApiContext> options)
            : base(options)
        {
        }

        public DbSet<Anime> Animes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Anime>()
            .HasData(
              new Anime {AnimeId = 1, Title = "Naruto", Genre = "Shonen", Studio = "TV Tokyo", SeasonCount = 30, EpisodeCount = 720, MovieCount=11},
              new Anime {AnimeId = 2, Title = "Pokemon", Genre = "Fantasy", Studio = "OLM", SeasonCount = 13, EpisodeCount = 1189, MovieCount=23},
              new Anime {AnimeId = 3, Title = "One Punch Man", Genre = "Comedy", Studio = "Madhouse", SeasonCount = 2, EpisodeCount = 24, MovieCount=0},
              new Anime {AnimeId = 4, Title = "Boku No Hero Academia", Genre = "Shonen", Studio = "Bones", SeasonCount = 5, EpisodeCount = 113, MovieCount=3},
              new Anime {AnimeId = 5, Title = "Katekyo Hitman Reborn", Genre = "Shonen", Studio = "Artland", SeasonCount = 9, EpisodeCount = 203, MovieCount=0}
            );
        }
    }
}