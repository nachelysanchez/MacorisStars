using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MacoriStars.Models
{
    public class Calificaciones
    {
        [Key]
        public int IdCalificacion { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int Valoracion { get; set; }
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuarios Usuario { get; set; }
        public int IdEstablecimiento { get; set; }
        [ForeignKey("IdEstablecimiento")]
        public virtual Establecimientos Establecimiento { get; set; }
    }
}
