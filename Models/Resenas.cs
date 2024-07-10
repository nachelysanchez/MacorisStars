using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MacoriStars.Models
{
    public class Resenas
    {
        [Key]
        public int IdResena { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Comentario { get; set; } = string.Empty;
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuarios Usuario { get; set; }
        public int IdEstablecimiento { get; set; }
        [ForeignKey("IdEstablecimiento")]
        public virtual Establecimientos Establecimiento { get; set; }

    }
}
