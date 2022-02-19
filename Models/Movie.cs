using MoviesStore.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesStore.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string? MovieName { get; set; }
        public string? MovieDescription { get; set; }
        public string? MovieImagePath { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        // Here fixed values using an enum
        public MovieCategory MovieCategory { get; set; }

        // Relationship between the actors and the movies
        public List<ActorsMovies> ActorsMovies { get; set; }

        // Relationship between the movie and the cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema  { get; set; }

        // Relationship between the movie and the producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
