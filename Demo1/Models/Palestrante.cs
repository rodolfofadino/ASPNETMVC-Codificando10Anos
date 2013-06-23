using System.ComponentModel.DataAnnotations;

namespace Demo1.Models
{
    public class Palestrante
    {
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }
        public string Palestra { get; set; }
    }
}