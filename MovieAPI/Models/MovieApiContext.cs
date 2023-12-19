using Microsoft.EntityFrameworkCore;

namespace MovieApi.Models
{
    public class MovieApiContext : DbContext
    {
        public DbSet<Movie> Movies { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasOne(e => e.Poster)
                .WithOne(e => e.Movie)
                .HasForeignKey<Photo>("PosterPhotoID")
                .IsRequired(false);
            modelBuilder.Entity<Movie>()
                .HasOne(e => e.Cover)
                .WithOne(e => e.Movie)
                .HasForeignKey<Photo>("CoverPhotoId")
                .IsRequired(false);
        }
        public DbSet<Photo> Photos { get; set;}
        public MovieApiContext(DbContextOptions<MovieApiContext> options) : base(options)
        {
            
        }
    }
}