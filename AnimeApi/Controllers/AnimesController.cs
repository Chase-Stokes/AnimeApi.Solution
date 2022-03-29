using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimeApi.Models;

namespace AnimeApi.Controllers
{ 
  [Route("api/Anime")]
  [ApiController]
  public class AnimesController : ControllerBase
  {
    private readonly AnimeApiContext _db;
    public AnimesController(AnimeApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Anime>>> Get(string title, string genre, string studio, int seasonCount, int episodeCount, int movieCount)
    {
      var query = _db.Animes.AsQueryable();

      if (title != null)
      {
        query = query.Where(e => e.Title == title);
      }
      if (genre != null)
      {
        query = query.Where(e => e.Genre == genre);
      }
      if (studio != null)
      {
        query = query.Where(e => e.Studio == studio);
      }
      if (seasonCount > 0)
      {
        query = query.Where(e => e.SeasonCount >= seasonCount);
      }
      if (episodeCount > 0)
      {
        query = query.Where(e => e.EpisodeCount >= episodeCount);
      }
      if (movieCount > 0)
      {
        query = query.Where(e => e.MovieCount >= movieCount);
      }
      
      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Anime>> Post(Anime anime)
    {
      _db.Animes.Add(anime);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetAnime), new { id = anime.AnimeId }, anime);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Anime>> GetAnime(int id)
    {
      var anime = await _db.Animes.FindAsync(id);

      if (anime == null)
      {
        return NotFound();
      }
      return anime;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Anime anime)
    {
      if (id != anime.AnimeId)
      {
        return BadRequest();
      }
      _db.Entry(anime).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimeExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }
    private bool AnimeExists(int id)
    {
      return _db.Animes.Any(e => e.AnimeId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnime(int id)
    {
      var anime = await _db.Animes.FindAsync(id);
      if (anime != null)
      {
        return NotFound();
      }
      _db.Animes.Remove(anime);
      await _db.SaveChangesAsync();
      return NoContent();
    }
  }
  
  [ApiVersion("2.0")]
  [Route("api/Anime")]
  [ApiController]
  public class AnimesV2Controller : ControllerBase
  {
    private readonly AnimeApiContext _db;
    public AnimesV2Controller(AnimeApiContext db)
    {
      _db = db;
    }
        [HttpGet]
    public async Task<ActionResult<IEnumerable<Anime>>> Get(string title, string genre, string studio, int seasonCount, int episodeCount, int movieCount)
    {
      var query = _db.Animes.AsQueryable();

      if (title != null)
      {
        query = query.Where(e => e.Title == title);
      }
      if (genre != null)
      {
        query = query.Where(e => e.Genre == genre);
      }
      if (studio != null)
      {
        query = query.Where(e => e.Studio == studio);
      }
      if (seasonCount > 0)
      {
        query = query.Where(e => e.SeasonCount >= seasonCount);
      }
      if (episodeCount > 0)
      {
        query = query.Where(e => e.EpisodeCount >= episodeCount);
      }
      if (movieCount > 0)
      {
        query = query.Where(e => e.MovieCount >= movieCount);
      }
      
      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Anime>> Post(Anime anime)
    {
      _db.Animes.Add(anime);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetAnime), new { id = anime.AnimeId }, anime);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Anime>> GetAnime(int id)
    {
      var anime = await _db.Animes.FindAsync(id);

      if (anime == null)
      {
        return NotFound();
      }
      return anime;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Anime anime)
    {
      if (id != anime.AnimeId)
      {
        return BadRequest();
      }
      _db.Entry(anime).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimeExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }
    private bool AnimeExists(int id)
    {
      return _db.Animes.Any(e => e.AnimeId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnime(int id)
    {
      var anime = await _db.Animes.FindAsync(id);
      if (anime != null)
      {
        return NotFound();
      }
      _db.Animes.Remove(anime);
      await _db.SaveChangesAsync();
      return NoContent();
    }
        //// Random Anime Test
    [HttpGet("random")]
    public async Task<ActionResult<Anime>> GetRandom()
    {
      Random rnd = new Random();
      int dbCount = _db.Animes.Count();
      int id = rnd.Next(1, dbCount);
      var anime = await _db.Animes.FindAsync(id);
      return anime;
    }
    ////
  }
}