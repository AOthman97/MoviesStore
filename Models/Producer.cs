using System.ComponentModel.DataAnnotations;

namespace MoviesStore.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        [Display(Name = "Name")]
        public string? ProducerName { get; set; }
        [Display(Name = "Image")]
        public string? ProfileImagePath { get; set; }
        [Display(Name = "Bio")]
        public string? Bio { get; set; }

        // Relationship with movies -> 1 To Many, One producer can have many movies so instead of a foreign key we'll define a list of movies
        public List<Movie> Movies { get; set; }
    }
}
