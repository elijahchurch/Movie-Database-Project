namespace MovieApi.Models
{
    public class CoverPhoto
    {
        public string CoverPhotoId { get; set;}
        public string Path { get; set;}
        #nullable enable
        public string? MovieId { get; set;}
        public Movie? Movie { get; set;}
    }
}
