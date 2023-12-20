namespace MovieApi.Models
{
    public class Poster
    {
        public int PosterId { get; set;}
        public string Path { get; set;}
        #nullable enable
        public int? MovieId { get; set;}
        public Movie? Movie { get; set;}
    }
}
