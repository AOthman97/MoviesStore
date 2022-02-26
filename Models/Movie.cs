using MoviesStore.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesStore.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Display(Name = "Name")]
        public string? MovieName { get; set; }
        [Display(Name = "Description")]
        public string? MovieDescription { get; set; }
        [Display(Name = "Image")]
        public string? MovieImagePath { get; set; }
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Display(Name = "Category")]
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
