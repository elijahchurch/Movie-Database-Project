namespace MovieApi.Models
{
    public class Movie
    {
        public string MovieId {get; set;}
        public string Name { get; set;}
        public int Date { get; set;}
        public int Length {get; set;}
        public string Rating { get; set;}
        public string OverView { get; set;}
        #nullable enable
        public Poster? Poster { get; set;}
        
        public CoverPhoto? CoverPhoto { get; set;}
    }
}