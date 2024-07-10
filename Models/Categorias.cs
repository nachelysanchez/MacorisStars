using System.ComponentModel.DataAnnotations;

namespace MacoriStars.Models
{
    public class Categorias
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }
}
