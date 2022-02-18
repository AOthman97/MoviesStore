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
    }
}
