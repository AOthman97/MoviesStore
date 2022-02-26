using System.ComponentModel.DataAnnotations;

namespace MoviesStore.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        [Display(Name = "Description")]
        public string? CinemaDescription { get; set; }
        [Display(Name = "Image")]
        public string? CinemaImagePath { get; set; }
        [Display(Name = "Name")]
        public string? CinemaName { get; set; }

        // Relationship with movies -> 1 To Many, One cinema can have many movies so instead of a foreign key we'll define a list of movies
        public List<Movie> Movies { get; set; }
    }
}
