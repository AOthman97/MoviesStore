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
    }
}
