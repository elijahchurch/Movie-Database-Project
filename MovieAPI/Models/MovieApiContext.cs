using Microsoft.EntityFrameworkCore;

namespace MovieApi.Models
{
    public class MovieApiContext : DbContext
    {
        public DbSet<Movie> Movies { get; set;}
        public DbSet<Poster> Posters { get; set;}
        public DbSet<CoverPhoto> CoverPhotos {get; set;}
        public MovieApiContext(DbContextOptions<MovieApiContext> options) : base(options)
        {
            
        }
    }
}