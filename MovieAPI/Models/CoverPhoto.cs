namespace MovieApi.Models
{
    public class CoverPhoto
    {
        public int CoverPhotoId { get; set;}
        public string Path { get; set;}
        #nullable enable
        public int? MovieId { get; set;}
        public Movie? Movie { get; set;}
    }
}
