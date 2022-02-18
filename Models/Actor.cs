using System.ComponentModel.DataAnnotations;

namespace MoviesStore.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public int FullName { get; set; }
        public string? ProfileImagePath { get; set; }
        public int Bio { get; set; }
    }
}
