using Microsoft.AspNetCore.Mvc;
using MovieApi.Models;

namespace MovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoverPhotosController : ControllerBase
    {
        private readonly MovieApiContext _db;
        public CoverPhotosController(MovieApiContext db)
        {
            _db = db;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CoverPhoto>> GetCoverPhoto(string id)
        {
            CoverPhoto coverPhoto = await _db.CoverPhotos.FindAsync(id);
            if (coverPhoto == null)
            {
                return NotFound();
            }

            return coverPhoto;
        }

        [HttpPost]
        public async Task<ActionResult<CoverPhoto>> Post(CoverPhoto coverPhoto)
        {
            _db.CoverPhotos.Add(coverPhoto);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCoverPhoto), new { id = coverPhoto.CoverPhotoId }, coverPhoto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCoverPhoto(string id)
        {
            CoverPhoto coverPhoto = await _db.CoverPhotos.FindAsync(id);
            if (coverPhoto == null)
            {
                return NotFound();
            }

            _db.CoverPhotos.Remove(coverPhoto);
            await _db.SaveChangesAsync();

            return NoContent();
        }

    }
}