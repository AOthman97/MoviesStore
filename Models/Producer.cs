using System.ComponentModel.DataAnnotations;

namespace MoviesStore.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string? ProducerName { get; set; }
        public string? ProfileImagePath { get; set; }
        public string? Bio { get; set; }

        // Relationship with movies -> 1 To Many, One producer can have many movies so instead of a foreign key we'll define a list of movies
        public List<Movie> Movies { get; set; }
    }
}
