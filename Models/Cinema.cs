using System.ComponentModel.DataAnnotations;

namespace MoviesStore.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string? CinemaDescription { get; set; }
        public string? CinemaImagePath { get; set; }
        public string? CinemaName { get; set; }

        // Relationship with movies -> 1 To Many, One cinema can have many movies so instead of a foreign key we'll define a list of movies
        public List<Movie> Movies { get; set; }
    }
}
