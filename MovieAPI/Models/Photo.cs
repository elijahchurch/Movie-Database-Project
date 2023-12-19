namespace MovieApi.Models
{
    public class Photo
    {
        public int PhotoId { get; set;}
        public string Name { get; set;}
        public string Path { get; set;}
        #nullable enable
        public int? MovieId { get; set;}
        public Movie? Movie { get; set;}
    }
}
