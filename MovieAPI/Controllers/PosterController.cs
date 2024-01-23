using Microsoft.AspNetCore.Mvc;
using MovieApi.Models;

namespace MovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostersController : ControllerBase
    {
        private readonly MovieApiContext _db;
        public PostersController(MovieApiContext db)
        {
            _db = db;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Poster>> GetPoster(string id)
        {
            Poster poster = await _db.Posters.FindAsync(id);
            if (poster == null)
            {
                return NotFound();
            }

            return poster;
        }

        [HttpPost]
        public async Task<ActionResult<Poster>> Post(Poster poster)
        {
            _db.Posters.Add(poster);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPoster), new { id = poster.PosterId }, poster);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePoster(string id)
        {
            Poster poster = await _db.Posters.FindAsync(id);
            if (poster == null)
            {
                return NotFound();
            }

            _db.Posters.Remove(poster);
            await _db.SaveChangesAsync();

            return NoContent();
        }

    }
}