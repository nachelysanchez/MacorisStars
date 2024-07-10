using System.ComponentModel.DataAnnotations;

namespace MacoriStars.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string NombreUsuario { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
    }
}
