namespace MoviesStore.Models
{
    // This is a joining table/model that was made because there's a many to many relationship between the actors and the movies, multiple
    // actors can have multiple movies and vice versa
    public class ActorsMovies
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
