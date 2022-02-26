using System.ComponentModel.DataAnnotations;

namespace MoviesStore.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        // The Display property is used to define the way that a property would show in a view page, Just the spelling
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Display(Name = "Image")]
        public string? ProfileImagePath { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }

        // Relationship between the actors and the movies
        public List<ActorsMovies> ActorsMovies { get; set; }
    }
}
