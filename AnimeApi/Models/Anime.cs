using System.ComponentModel.DataAnnotations;
namespace AnimeApi.Models
{
  public class Anime
  {
    public int AnimeId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Genre { get; set; }
    [Required]
    public string Studio { get; set; }
    [Required]
    [Range(0, 500, ErrorMessage = "Maximum number of seasons accepted is 500")]
    public int SeasonCount { get; set; }
    [Required]
    [Range(0, 5000, ErrorMessage = "Maximum number of episodes accepted is 5,000")]
    public int EpisodeCount { get; set; }
    [Required]
    [Range(0, 5000, ErrorMessage = "Maximum number of movies accepted is 5,000")]
    public int MovieCount { get; set; }
  }
}