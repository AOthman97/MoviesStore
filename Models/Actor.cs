using System.ComponentModel.DataAnnotations;

namespace MoviesStore.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string FullName { get; set; }
        public string? ProfileImagePath { get; set; }
        public string Bio { get; set; }

        // Relationship between the actors and the movies
        public List<ActorsMovies> ActorsMovies { get; set; }
    }
}
