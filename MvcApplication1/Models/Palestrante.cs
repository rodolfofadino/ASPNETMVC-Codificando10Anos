using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Palestrante
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Palestra { get; set; }
    }
}