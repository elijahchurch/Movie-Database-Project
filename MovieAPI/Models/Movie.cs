namespace MovieApi.Models
{
    public enum MovieRating 
    {
        G,
        PG,
        PG13,
        R,
        NC17,
        NR,
    }
    public class Movie
    {
        public int MovieId {get; set;}
        public string Name { get; set;}
        public int Date { get; set;}
        public int Length {get; set;}
        public MovieRating Rating { get; set;}
        public string OverView { get; set;}
        #nullable enable
        public Photo? Poster { get; set;}
        
        public Photo? Cover { get; set;}
    }
}