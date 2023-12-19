using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApi.Models;

namespace MovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieApiContext _db;
        public MoviesController(MovieApiContext db)
        {
            _db = db;
        }
        private bool MovieExists(int id)
        {
            return _db.Movies.Any(e => e.MovieId == id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> Get(string name, int date, int maxLength)
        {
            IQueryable<Movie> query = _db.Movies.AsQueryable();
            if (name != null)
            {
                query = query.Where(e => e.Name == name);
            }
            if (date != 0)
            {
                query = query.Where(e => e.Date == date);
            }
            if (maxLength > 0)
            {
                query = query.Where(e => e.Length <= maxLength);
            }
            return await query.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            Movie movie = await _db.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> Post(Movie movie)
        {
            _db.Movies.Add(movie);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMovie), new { id = movie.MovieId }, movie);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Movie movie)
        {
            if (id != movie.MovieId)
            {
                return BadRequest();
            }

            _db.Movies.Update(movie);

            try 
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            Movie movie = await _db.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _db.Movies.Remove(movie);
            await _db.SaveChangesAsync();

            return NoContent();
        }

    }
}