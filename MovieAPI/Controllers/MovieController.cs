using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApi.Models;

namespace MovieApi.Controllers
{
    [Route("api/[contoller]")]
    [ApiController]
    public class MoviesContoller : ControllerBase
    {
        private readonly MovieApiContext _db;
        public MoviesController(MovieApiContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> Get()
        {
            return await _db.Movies.ToListAsync();
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
    }
}